/*
The MIT License (MIT)

Copyright (c) 2007 - 2022 Microting A/S

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/

using System.Threading;
using BackendConfiguration.Pn.Infrastructure.Helpers;
using BackendConfiguration.Pn.Messages;
using BackendConfiguration.Pn.Services.RebusService;
using ImageMagick;
using Rebus.Bus;

namespace BackendConfiguration.Pn.Services.BackendConfigurationTaskManagementService;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using BackendConfigurationLocalizationService;
using Infrastructure.Models.TaskManagement;
using Microsoft.EntityFrameworkCore;
using Microting.eForm.Infrastructure.Constants;
using Microting.eFormApi.BasePn.Abstractions;
using Microting.eFormApi.BasePn.Infrastructure.Helpers;
using Microting.eFormApi.BasePn.Infrastructure.Models.API;
using Microting.EformBackendConfigurationBase.Infrastructure.Data;
using Microting.EformBackendConfigurationBase.Infrastructure.Data.Entities;
using Microting.EformBackendConfigurationBase.Infrastructure.Enum;

public class BackendConfigurationTaskManagementService : IBackendConfigurationTaskManagementService
{
    private readonly IEFormCoreService _coreHelper;
    private readonly IBackendConfigurationLocalizationService _localizationService;
    private readonly IUserService _userService;

    private readonly BackendConfigurationPnDbContext _backendConfigurationPnDbContext;
    private readonly IBus _bus;

    public BackendConfigurationTaskManagementService(
        IBackendConfigurationLocalizationService localizationService,
        IEFormCoreService coreHelper, IUserService userService,
        // ItemsPlanningPnDbContext itemsPlanningPnDbContext,
        BackendConfigurationPnDbContext backendConfigurationPnDbContext, IRebusService rebusService)
    {
        _localizationService = localizationService;
        _coreHelper = coreHelper;
        _userService = userService;
        _backendConfigurationPnDbContext = backendConfigurationPnDbContext;
        _bus = rebusService.GetBus();
    }

    public async Task<List<WorkorderCaseModel>> Index(TaskManagementFiltersModel filtersModel)
    {
        if (filtersModel.Delayed)
        {
            Thread.Sleep(3000);
        }
        try
        {
            var timeZoneInfo = await _userService.GetCurrentUserTimeZoneInfo();
            var query = _backendConfigurationPnDbContext.WorkorderCases
                .Include(x => x.PropertyWorker)
                .ThenInclude(x => x.Property)
                .Where(x => x.WorkflowState != Constants.WorkflowStates.Removed)
                .Where(x => x.PropertyWorker.Property.WorkorderEnable)
                .Where(x => x.LeadingCase == true)
                .Where(x => x.CaseStatusesEnum != CaseStatusesEnum.NewTask);

            if (filtersModel.PropertyId != -1)
            {
                query = query
                    .Where(x => x.PropertyWorker.PropertyId == filtersModel.PropertyId);
            }

            if (filtersModel.Status != null)
            {
                query = filtersModel.Status switch
                {
                    -1 => query,
                    1 => query.Where(x => x.CaseStatusesEnum == CaseStatusesEnum.Ongoing),
                    2 => query.Where(x => x.CaseStatusesEnum == CaseStatusesEnum.Completed),
                    3 => query.Where(x => x.CaseStatusesEnum == CaseStatusesEnum.Ordered),
                    4 => query.Where(x => x.CaseStatusesEnum == CaseStatusesEnum.Awaiting),
                    _ => query
                };
            }

            if (!string.IsNullOrEmpty(filtersModel.AreaName))
            {
                query = query.Where(x => filtersModel.AreaName == x.SelectedAreaName);
            }

            if (!string.IsNullOrEmpty(filtersModel.CreatedBy))
            {
                query = query.Where(x => x.CreatedByName == filtersModel.CreatedBy);
            }

            if (filtersModel.Priority != null)
            {
                query = filtersModel.Priority == 3 ?
                    query.Where(x => x.Priority == null || x.Priority == "3") :
                    query.Where(x => x.Priority == filtersModel.Priority.ToString());
            }

            if (filtersModel.DateFrom.HasValue && filtersModel.DateTo.HasValue)
            {
                query = query
                    .Where(x => x.CaseInitiated >= filtersModel.DateFrom.Value)
                    .Where(x => x.CaseInitiated <= new DateTime(filtersModel.DateTo.Value.Year,
                        filtersModel.DateTo.Value.Month, filtersModel.DateTo.Value.Day, 23, 59, 59));
            }

            if (filtersModel.LastAssignedTo.HasValue && filtersModel.LastAssignedTo.Value != 0)
            {
                var core = await _coreHelper.GetCore().ConfigureAwait(false);
                var sdkDbContext = core.DbContextHelper.GetDbContext();
                var siteName = await sdkDbContext.Sites
                    .Where(x => x.Id == filtersModel.LastAssignedTo.Value)
                    .Select(x => x.Name)
                    .FirstOrDefaultAsync();
                if (!string.IsNullOrEmpty(siteName))
                {
                    query = query.Where(x => x.LastAssignedToName == siteName);
                }
            }

            var excludeSort = new List<string>
            {
                "PropertyName"
            };
            query = QueryHelper.AddFilterAndSortToQuery(query, filtersModel, new List<string>(), excludeSort);

            var workOrderCaseFromDb = await query
                .Select(x => new WorkorderCaseModel
                {
                    AreaName = x.SelectedAreaName,
                    CreatedByName = x.CreatedByName,
                    CreatedByText = x.CreatedByText,
                    CaseInitiated = TimeZoneInfo.ConvertTimeFromUtc(x.CaseInitiated, timeZoneInfo),
                    Id = x.Id,
                    Status = x.CaseStatusesEnum.ToString(),
                    Description = x.Description.Replace("\n", "<br />"),
                    PropertyName = x.PropertyWorker.Property.Name,
                    LastUpdateDate = x.UpdatedAt != null ? TimeZoneInfo.ConvertTimeFromUtc((DateTime)x.UpdatedAt, timeZoneInfo) : null,
                    //x.CaseId,
                    LastUpdatedBy = x.LastUpdatedByName,
                    LastAssignedTo = x.LastAssignedToName,
                    ParentWorkorderCaseId = x.ParentWorkorderCaseId,
                    Priority = string.IsNullOrEmpty(x.Priority) ? 3 : int.Parse(x.Priority) == 0 ? 3 : int.Parse(x.Priority)
                })
                .ToListAsync().ConfigureAwait(false);

            if (excludeSort.Contains(filtersModel.Sort))
            {
                workOrderCaseFromDb = QueryHelper
                    .AddFilterAndSortToQuery(workOrderCaseFromDb.AsQueryable(), filtersModel, new List<string>())
                    .ToList();
            }

            return workOrderCaseFromDb;
        }
        catch (Exception e)
        {
            Log.LogException(e.Message);
            Log.LogException(e.StackTrace);
            throw;
        }
    }

    public async Task<OperationDataResult<WorkOrderCaseReadModel>> GetTaskById(int workOrderCaseId)
    {
        try
        {
            var core = await _coreHelper.GetCore().ConfigureAwait(false);
            var sdkDbContext = core.DbContextHelper.GetDbContext();
            var task = await _backendConfigurationPnDbContext.WorkorderCases
                .Where(x => x.WorkflowState != Constants.WorkflowStates.Removed)
                .Where(x => x.Id == workOrderCaseId)
                .Include(x => x.PropertyWorker)
                .Select(x => new
                {
                    x.SelectedAreaName,
                    x.Description,
                    x.Id,
                    x.CaseId,
                    x.ParentWorkorderCaseId,
                    x.PropertyWorker.PropertyId,
                    x.LastAssignedToName,
                    x.Priority,
                    x.CaseStatusesEnum
                }).FirstOrDefaultAsync().ConfigureAwait(false);
            if (task == null)
            {
                return new OperationDataResult<WorkOrderCaseReadModel>(false,
                    _localizationService.GetString("TaskNotFound"));
            }

            var uploadIds = await _backendConfigurationPnDbContext.WorkorderCaseImages
                .Where(x => x.WorkflowState != Constants.WorkflowStates.Removed)
                .Where(task.ParentWorkorderCaseId != null ? x => x.WorkorderCaseId == task.ParentWorkorderCaseId : x => x.WorkorderCaseId == task.Id)
                .Select(x => x.UploadedDataId)
                .ToListAsync().ConfigureAwait(false);

            var fileNames = new List<string>();
            foreach (var uploadId in uploadIds)
            {
                var fileName = await sdkDbContext.UploadedDatas
                    .Where(x => x.Id == uploadId)
                    .Select(x => x.FileName)
                    .FirstOrDefaultAsync().ConfigureAwait(false);
                fileNames.Add(fileName);
            }

            var assignedSiteId = await sdkDbContext.Sites
                .Where(x => x.Name == task.LastAssignedToName)
                .Select(x => x.Id)
                .FirstOrDefaultAsync().ConfigureAwait(false);

            var taskForReturn = new WorkOrderCaseReadModel
            {
                AreaName = task.SelectedAreaName,
                AssignedSiteId = assignedSiteId,
                Description = task.Description.Replace("<div>", "").Replace("</div>", ""),
                Id = task.Id,
                PictureNames = fileNames,
                PropertyId = task.PropertyId,
                Priority = string.IsNullOrEmpty(task.Priority) ? 3 : int.Parse(task.Priority),
                Status = task.CaseStatusesEnum.ToString(),
                CaseStatusEnum = task.CaseStatusesEnum

            };
            return new OperationDataResult<WorkOrderCaseReadModel>(true, taskForReturn);
        }
        catch (Exception e)
        {
            Log.LogException(e.Message);
            Log.LogException(e.StackTrace);
            return new OperationDataResult<WorkOrderCaseReadModel>(false,
                $"{_localizationService.GetString("ErrorWhileReadTask")}: {e.Message}");
        }
    }

    public async Task<OperationDataResult<List<string>>> GetItemsEntityListByPropertyId(int propertyId)
    {
        try
        {
            var core = await _coreHelper.GetCore().ConfigureAwait(false);
            var sdkDbContext = core.DbContextHelper.GetDbContext();
            var entityListId = await _backendConfigurationPnDbContext.Properties
                .Where(x => x.WorkflowState != Constants.WorkflowStates.Removed)
                .Where(x => x.Id == propertyId)
                .Select(x => x.EntitySelectListAreas)
                .FirstOrDefaultAsync().ConfigureAwait(false);
            if (entityListId == null)
            {
                return new OperationDataResult<List<string>>(false,
                    _localizationService.GetString("PropertyNotFoundOrEntityListNotCreated"));
            }

            var items = await sdkDbContext.EntityItems
                .Where(x => x.EntityGroupId == entityListId)
                .Where(x => x.WorkflowState != Constants.WorkflowStates.Removed)
                .OrderBy(x => x.DisplayIndex)
                .Select(x => x.Name)
                .ToListAsync().ConfigureAwait(false);
            return new OperationDataResult<List<string>>(true, items);
        }
        catch (Exception e)
        {
            Log.LogException(e.Message);
            Log.LogException(e.StackTrace);
            return new OperationDataResult<List<string>>(false,
                $"{_localizationService.GetString("ErrorWhileReadEntityList")}: {e.Message}");
        }
    }

    public async Task<OperationResult> DeleteTaskById(int workOrderCaseId)
    {
        var core = await _coreHelper.GetCore().ConfigureAwait(false);
        try
        {
            var workOrderCase = await _backendConfigurationPnDbContext.WorkorderCases
                .Where(x => x.WorkflowState != Constants.WorkflowStates.Removed)
                .Where(x => x.Id == workOrderCaseId)
                .Include(x => x.PropertyWorker)
                .FirstOrDefaultAsync().ConfigureAwait(false);

            if (workOrderCase == null)
            {
                return new OperationDataResult<WorkOrderCaseReadModel>(false,
                    _localizationService.GetString("TaskNotFound"));
            }

            if (workOrderCase.CaseId != 0)
            {
                try { await core.CaseDelete(workOrderCase.CaseId).ConfigureAwait(false); }
                catch (Exception e)
                {
                    Log.LogException(e.Message);
                    Log.LogException(e.StackTrace);
                }
                // await core.CaseDelete(workOrderCase.CaseId).ConfigureAwait(false);
            }

            await workOrderCase.Delete(_backendConfigurationPnDbContext).ConfigureAwait(false);

            var allChildTasks = await _backendConfigurationPnDbContext.WorkorderCases
                .Where(x => x.ParentWorkorderCaseId == workOrderCase.Id)
                .ToListAsync().ConfigureAwait(false);

            foreach (var childTask in allChildTasks)
            {
                childTask.UpdatedByUserId = _userService.UserId;

                if (childTask.CaseId != 0)
                {
                    await core.CaseDelete(childTask.CaseId).ConfigureAwait(false);
                }

                await childTask.Delete(_backendConfigurationPnDbContext).ConfigureAwait(false);
            }

            if (workOrderCase.ParentWorkorderCaseId != null)
            {
                var parentTask = await _backendConfigurationPnDbContext.WorkorderCases
                    .Where(x => x.Id == workOrderCase.ParentWorkorderCaseId)
                    .FirstOrDefaultAsync().ConfigureAwait(false);

                if (parentTask != null)
                {
                    parentTask.UpdatedByUserId = _userService.UserId;
                    await parentTask.Delete(_backendConfigurationPnDbContext).ConfigureAwait(false);

                    if (parentTask.CaseId != 0)
                    {
                        try
                        {
                            await core.CaseDelete(parentTask.CaseId).ConfigureAwait(false);
                        }
                        catch (Exception e)
                        {
                            Log.LogException(e.Message);
                            Log.LogException(e.StackTrace);
                        }
                    }
                    // await core.CaseDelete(parentTask.CaseId).ConfigureAwait(false);

                    allChildTasks = await _backendConfigurationPnDbContext.WorkorderCases
                        .Where(x => x.ParentWorkorderCaseId == parentTask.Id)
                        .ToListAsync().ConfigureAwait(false);

                    foreach (var childTask in allChildTasks)
                    {
                        childTask.UpdatedByUserId = _userService.UserId;

                        if (childTask.CaseId != 0)
                        {
                            try
                            {
                                await core.CaseDelete(childTask.CaseId).ConfigureAwait(false);
                            }
                            catch (Exception e)
                            {
                                Log.LogException(e.Message);
                                Log.LogException(e.StackTrace);
                            }
                        }

                        await childTask.Delete(_backendConfigurationPnDbContext).ConfigureAwait(false);
                    }
                }
            }

            return new OperationResult(true, _localizationService.GetString("TaskDeletedSuccessful"));
        }
        catch (Exception e)
        {
            Log.LogException(e.Message);
            Log.LogException(e.StackTrace);
            return new OperationResult(false,
                $"{_localizationService.GetString("ErrorWhileDeleteTask")}: {e.Message}");
        }
    }

    public async Task<OperationResult> CreateTask(WorkOrderCaseCreateModel createModel)
    {
        try
        {
            var core = await _coreHelper.GetCore().ConfigureAwait(false);
            var sdkDbContext = core.DbContextHelper.GetDbContext();
            var property = await _backendConfigurationPnDbContext.Properties
                .Where(x => x.WorkflowState != Constants.WorkflowStates.Removed)
                .Where(x => x.Id == createModel.PropertyId)
                .Include(x => x.PropertyWorkers)
                .FirstOrDefaultAsync().ConfigureAwait(false);
            if (property == null)
            {
                return new OperationDataResult<WorkOrderCaseReadModel>(false,
                    _localizationService.GetString("PropertyNotFound"));
            }

            var propertyWorkers = property.PropertyWorkers
                .Where(x => x.WorkflowState != Constants.WorkflowStates.Removed)
                .Where(x => x.TaskManagementEnabled == true || x.TaskManagementEnabled == null)
                .ToList();

            var site = await sdkDbContext.Sites
                .Where(x => x.Id == createModel.AssignedSiteId)
                .FirstAsync().ConfigureAwait(false);

            createModel.Description = string.IsNullOrEmpty(createModel.Description)
                ? ""
                : createModel.Description.Replace("<div>", "").Replace("</div>", "");
            var newWorkOrderCase = new WorkorderCase
            {
                ParentWorkorderCaseId = null,
                CaseId = 0,
                PropertyWorkerId = propertyWorkers.First().Id,
                SelectedAreaName = createModel.AreaName,
                CreatedByName = await _userService.GetCurrentUserFullName().ConfigureAwait(false),
                CreatedByText = "",
                CaseStatusesEnum = createModel.CaseStatusEnum,
                Description = createModel.Description,
                CaseInitiated = DateTime.UtcNow,
                LeadingCase = true,
                LastAssignedToName = site.Name,
                AssignedToSdkSiteId = site.Id,
                Priority = createModel.Priority.ToString()
            };
            await newWorkOrderCase.Create(_backendConfigurationPnDbContext).ConfigureAwait(false);

            var picturesOfTasks = new List<string>();
            var hasImages = false;
            if (createModel.Files.Any())
            {
                foreach (var picture in createModel.Files)
                {
                    MemoryStream baseMemoryStream = new MemoryStream();
                    await picture.CopyToAsync(baseMemoryStream).ConfigureAwait(false);
                    var hash = "";
                    using (var md5 = MD5.Create())
                    {
                        var grr = await md5.ComputeHashAsync(baseMemoryStream).ConfigureAwait(false);
                        hash = BitConverter.ToString(grr).Replace("-", "").ToLower();
                    }

                    var uploadData = new Microting.eForm.Infrastructure.Data.Entities.UploadedData
                    {
                        Checksum = hash,
                        FileName = picture.FileName,
                        FileLocation = "",
                        Extension = $".{picture.ContentType.Split("/")[1]}"
                    };
                    await uploadData.Create(sdkDbContext).ConfigureAwait(false);

                    var fileName = $"{uploadData.Id}_{hash}{uploadData.Extension}";
                    string smallFilename = $"{uploadData.Id}_300_{hash}{uploadData.Extension}";
                    string bigFilename = $"{uploadData.Id}_700_{hash}{uploadData.Extension}";
                    uploadData.FileName = smallFilename;
                    await uploadData.Update(sdkDbContext).ConfigureAwait(false);
                    baseMemoryStream.Seek(0, SeekOrigin.Begin);
                    MemoryStream s3Stream = new MemoryStream();
                    await baseMemoryStream.CopyToAsync(s3Stream).ConfigureAwait(false);
                    s3Stream.Seek(0, SeekOrigin.Begin);
                    await core.PutFileToS3Storage(s3Stream, fileName).ConfigureAwait(false);
                    baseMemoryStream.Seek(0, SeekOrigin.Begin);
                    using (var image = new MagickImage(baseMemoryStream))
                    {
                        decimal currentRation = image.Height / (decimal)image.Width;
                        int newWidth = 300;
                        int newHeight = (int)Math.Round((currentRation * newWidth));

                        image.Resize(newWidth, newHeight);
                        image.Crop(newWidth, newHeight);
                        MemoryStream memoryStream = new MemoryStream();
                        await image.WriteAsync(memoryStream).ConfigureAwait(false);
                        await core.PutFileToS3Storage(memoryStream, smallFilename).ConfigureAwait(false);
                        await memoryStream.DisposeAsync().ConfigureAwait(false);
                        memoryStream.Close();
                        image.Dispose();
                        baseMemoryStream.Seek(0, SeekOrigin.Begin);
                    }

                    using (var image = new MagickImage(baseMemoryStream))
                    {
                        decimal currentRation = image.Height / (decimal)image.Width;
                        int newWidth = 700;
                        int newHeight = (int)Math.Round(currentRation * newWidth);

                        image.Resize(newWidth, newHeight);
                        image.Crop(newWidth, newHeight);
                        MemoryStream memoryStream = new MemoryStream();
                        await image.WriteAsync(memoryStream).ConfigureAwait(false);
                        await core.PutFileToS3Storage(memoryStream, bigFilename).ConfigureAwait(false);
                        await memoryStream.DisposeAsync().ConfigureAwait(false);
                        memoryStream.Close();
                        image.Dispose();
                    }

                    await baseMemoryStream.DisposeAsync().ConfigureAwait(false);
                    baseMemoryStream.Close();

                    var workOrderCaseImage = new WorkorderCaseImage
                    {
                        WorkorderCaseId = newWorkOrderCase.Id,
                        UploadedDataId = uploadData.Id
                    };
                    picturesOfTasks.Add($"{uploadData.Id}_700_{uploadData.Checksum}{uploadData.Extension}");
                    await workOrderCaseImage.Create(_backendConfigurationPnDbContext).ConfigureAwait(false);
                }
                hasImages = true;
            }

            var eformIdForOngoingTasks = await sdkDbContext.CheckLists
                .Where(x => x.OriginalId == "142664new2")
                .Select(x => x.Id)
                .FirstOrDefaultAsync();

            var deviceUsersGroupMicrotingUid = await sdkDbContext.EntityGroups
                .Where(x => x.Id == property.EntitySelectListDeviceUsers)
                .Select(x => int.Parse(x.MicrotingUid))
                .FirstAsync().ConfigureAwait(false);

            // var description = $"<strong>{_localizationService.GetString("AssignedTo")}:</strong> {site.Name}<br>" +
            //                   $"<strong>{_localizationService.GetString("Location")}:</strong> {property.Name}<br>" +
            //                   $"<strong>{_localizationService.GetString("Area")}:</strong> {createModel.AreaName}<br>" +
            //                   $"<strong>{_localizationService.GetString("Description")}:</strong> {createModel.Description}<br><br>" +
            //                   $"<strong>{_localizationService.GetString("CreatedBy")}:</strong> {await _userService.GetCurrentUserFullName().ConfigureAwait(false)}<br>" +
            //                   $"<strong>{_localizationService.GetString("CreatedDate")}:</strong> {DateTime.UtcNow: dd.MM.yyyy}<br><br>" +
            //                   $"<strong>{_localizationService.GetString("Status")}:</strong> {_localizationService.GetString("Ongoing")}<br><br>";
            var priorityText = "";
            var textStatus = "";
            switch (newWorkOrderCase.CaseStatusesEnum)
            {
                case CaseStatusesEnum.Ongoing:
                    textStatus = _localizationService.GetString("Ongoing");
                    break;
                case CaseStatusesEnum.Completed:
                    textStatus = _localizationService.GetString("Completed");
                    break;
                case CaseStatusesEnum.Ordered:
                    textStatus = _localizationService.GetString("Ordered");
                    break;
                case CaseStatusesEnum.Awaiting:
                    textStatus = _localizationService.GetString("Awaiting");
                    break;
            }

            switch (createModel.Priority)
            {
                case 1:
                    priorityText = $"<strong>{_localizationService.GetString("Priority")}:</strong> {_localizationService.GetString("Urgent")}<br>";
                    break;
                case 2:
                    priorityText = $"<strong>{_localizationService.GetString("Priority")}:</strong> {_localizationService.GetString("High")}<br>";
                    break;
                case 3:
                    priorityText = $"<strong>{_localizationService.GetString("Priority")}:</strong> {_localizationService.GetString("Medium")}<br>";
                    break;
                case 4:
                    priorityText = $"<strong>{_localizationService.GetString("Priority")}:</strong> {_localizationService.GetString("Low")}<br>";
                    break;
            }
            var description = $"<strong>{_localizationService.GetString("AssignedTo")}:</strong> {site.Name}<br>";
            description += $"<strong>{_localizationService.GetString("Location")}:</strong> {property.Name}<br>" +
                           (!string.IsNullOrEmpty(newWorkOrderCase.SelectedAreaName)
                               ? $"<strong>{_localizationService.GetString("Area")}:</strong> {newWorkOrderCase.SelectedAreaName}<br>"
                               : "") +
                           $"<strong>{_localizationService.GetString("Description")}:</strong> {newWorkOrderCase.Description}<br>" +
                           priorityText +
                           $"<strong>{_localizationService.GetString("CreatedBy")}:</strong> {newWorkOrderCase.CreatedByName}<br>" +
                           (!string.IsNullOrEmpty(newWorkOrderCase.CreatedByText)
                               ? $"<strong>{_localizationService.GetString("CreatedBy")}:</strong> {newWorkOrderCase.CreatedByText}<br>"
                               : "") +
                           $"<strong>{_localizationService.GetString("CreatedDate")}:</strong> {newWorkOrderCase.CaseInitiated: dd.MM.yyyy}<br><br>" +
                           $"<strong>{_localizationService.GetString("LastUpdatedBy")}:</strong> {await _userService.GetCurrentUserFullName().ConfigureAwait(false)}<br>" +
                           $"<strong>{_localizationService.GetString("LastUpdatedDate")}:</strong> {DateTime.UtcNow: dd.MM.yyyy}<br><br>" +
                           $"<strong>{_localizationService.GetString("Status")}:</strong> {textStatus}<br><br>";

            var pushMessageTitle = !string.IsNullOrEmpty(createModel.AreaName)
                ? $"{property.Name}; {createModel.AreaName}"
                : $"{property.Name}";
            var pushMessageBody = createModel.Description;

            var propertyWorkerKvpList = new List<KeyValuePair<int, int>>();

            foreach (var propertyWorker in propertyWorkers)
            {
                var kvp = new KeyValuePair<int, int>(propertyWorker.Id, propertyWorker.WorkerId);
                propertyWorkerKvpList.Add(kvp);
            }

            if (newWorkOrderCase.CaseStatusesEnum != CaseStatusesEnum.Completed)
            {
                await _bus.SendLocal(new WorkOrderCreated(
                    propertyWorkerKvpList,
                    eformIdForOngoingTasks,
                    (int)property.FolderIdForOngoingTasks!,
                    description,
                    createModel.CaseStatusEnum,
                    newWorkOrderCase.Id,
                    createModel.Description,
                    deviceUsersGroupMicrotingUid,
                    pushMessageBody,
                    pushMessageTitle,
                    createModel.AreaName,
                    _userService.UserId,
                    picturesOfTasks,
                    site,
                    property.Name,
                    (int)property.FolderIdForOngoingTasks!,
                    (int) property.FolderIdForTasks!,
                    (int) property.FolderIdForCompletedTasks!, hasImages)).ConfigureAwait(false);
            }

            return new OperationResult(true, _localizationService.GetString("TaskCreatedSuccessful"));
        }
        catch (Exception e)
        {
            Log.LogException(e.Message);
            Log.LogException(e.StackTrace);
            return new OperationResult(false,
                $"{_localizationService.GetString("ErrorWhileCreateTask")}: {e.Message}");
        }
    }

    public async Task<OperationResult> UpdateTask(WorkOrderCaseUpdateModel updateModel)
    {
        var core = await _coreHelper.GetCore().ConfigureAwait(false);
        return await BackendConfigurationTaskManagementHelper.UpdateTask(updateModel, _localizationService, core,
            _userService, _backendConfigurationPnDbContext, _bus, true);
    }
}