/*
The MIT License (MIT)

Copyright (c) 2007 - 2021 Microting A/S

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

namespace BackendConfiguration.Pn.Services.BackendConfigurationPropertyAreasService
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using BackendConfigurationLocalizationService;
    using Infrastructure.Data.Seed.Data;
    using Infrastructure.Models.AreaRules;
    using Infrastructure.Models.PropertyAreas;
    using Microsoft.EntityFrameworkCore;
    using Microting.eForm.Dto;
    using Microting.eForm.Infrastructure.Constants;
    using Microting.eFormApi.BasePn.Abstractions;
    using Microting.eFormApi.BasePn.Infrastructure.Helpers;
    using Microting.eFormApi.BasePn.Infrastructure.Models.API;
    using Microting.eFormApi.BasePn.Infrastructure.Models.Common;
    using Microting.EformBackendConfigurationBase.Infrastructure.Data;
    using Microting.EformBackendConfigurationBase.Infrastructure.Data.Entities;
    using Microting.EformBackendConfigurationBase.Infrastructure.Enum;
    using CommonTranslationsModel = Microting.eForm.Infrastructure.Models.CommonTranslationsModel;

    public class BackendConfigurationPropertyAreasService : IBackendConfigurationPropertyAreasService
    {
        private readonly IEFormCoreService _coreHelper;
        private readonly IBackendConfigurationLocalizationService _backendConfigurationLocalizationService;
        private readonly IUserService _userService;
        private readonly BackendConfigurationPnDbContext _backendConfigurationPnDbContext;

        public BackendConfigurationPropertyAreasService(
            IEFormCoreService coreHelper,
            IUserService userService,
            BackendConfigurationPnDbContext backendConfigurationPnDbContext,
            IBackendConfigurationLocalizationService backendConfigurationLocalizationService)
        {
            _coreHelper = coreHelper;
            _userService = userService;
            _backendConfigurationLocalizationService = backendConfigurationLocalizationService;
            _backendConfigurationPnDbContext = backendConfigurationPnDbContext;
        }

        public async Task<OperationDataResult<List<PropertyAreaModel>>> Read(int propertyId)
        {
            try
            {
                var propertyAreas = new List<PropertyAreaModel>();

                var propertyAreasQuery = _backendConfigurationPnDbContext.AreaProperties
                    .Where(x => x.WorkflowState != Constants.WorkflowStates.Removed)
                    .Where(x => x.PropertyId == propertyId)
                    .Include(x => x.Area)
                    .ThenInclude(x => x.AreaRules)
                    .ThenInclude(x => x.AreaRulesPlannings);

                var areas = _backendConfigurationPnDbContext.Areas
                    .Include(x => x.AreaTranslations)
                    .Where(x => x.WorkflowState != Constants.WorkflowStates.Removed)
                    .ToList();

                List<PropertyAreaModel> areasForAdd;
                var language = await _userService.GetCurrentUserLanguage();
                if (propertyAreasQuery.Any())
                {
                    propertyAreas = await propertyAreasQuery
                        .Select(x => new PropertyAreaModel
                        {
                            Id = x.Id,
                            Activated = x.Checked,
                            Description = x.Area.AreaTranslations.Where(y => y.LanguageId == language.Id)
                                .Select(y => y.Description).FirstOrDefault(),
                            Name = x.Area.AreaTranslations.Where(y => y.LanguageId == language.Id).Select(y => y.Name)
                                .FirstOrDefault(),
                            Status = x.Area.AreaRules
                                .Where(y => y.WorkflowState != Constants.WorkflowStates.Removed)
                                .Where(y => y.PropertyId == propertyId)
                                .SelectMany(y => y.AreaRulesPlannings)
                                .Where(y => y.WorkflowState != Constants.WorkflowStates.Removed)
                                .Any(y => y.Status),
                            AreaId = x.AreaId,
                        })
                        .ToListAsync();
                    areasForAdd = areas.Where(x => !propertyAreasQuery.Any(y => y.AreaId == x.Id))
                        .Select(x => new PropertyAreaModel
                        {
                            Id = null,
                            Activated = false,
                            Description = x.AreaTranslations.Where(y => y.LanguageId == language.Id)
                                .Select(y => y.Description).FirstOrDefault(),
                            Name = x.AreaTranslations.Where(y => y.LanguageId == language.Id).Select(y => y.Name)
                                .FirstOrDefault(),
                            Status = false,
                            AreaId = x.Id,
                        })
                        .ToList();
                }
                else
                {
                    areasForAdd = areas
                        .Select(x => new PropertyAreaModel
                        {
                            Id = null,
                            Activated = false,
                            Description = x.AreaTranslations.Where(y => y.LanguageId == language.Id)
                                .Select(y => y.Description).FirstOrDefault(),
                            Name = x.AreaTranslations.Where(y => y.LanguageId == language.Id).Select(y => y.Name)
                                .FirstOrDefault(),
                            Status = false,
                            AreaId = x.Id,
                        })
                        .ToList();
                }

                propertyAreas.AddRange(areasForAdd);

                propertyAreas = propertyAreas.OrderBy(x => x.AreaId).ToList();

                return new OperationDataResult<List<PropertyAreaModel>>(true, propertyAreas);
            }
            catch (Exception e)
            {
                Log.LogException(e.Message);
                Log.LogException(e.StackTrace);
                return new OperationDataResult<List<PropertyAreaModel>>(false,
                    _backendConfigurationLocalizationService.GetString("ErrorWhileReadPropertyAreas"));
            }
        }

        public async Task<OperationResult> Update(PropertyAreasUpdateModel updateModel)
        {
            try
            {
                updateModel.Areas = updateModel.Areas.Where(x => x.Activated).ToList();
                var assignments = await _backendConfigurationPnDbContext.AreaProperties
                 .Where(x => x.WorkflowState != Constants.WorkflowStates.Removed)
                 .Where(x => x.PropertyId == updateModel.PropertyId)
                 .ToListAsync();

                var assignmentsForCreate = updateModel.Areas
                    .Where(x => x.Id == null)
                    .Where(x => x.Activated)
                    .ToList();

                var assignmentsForDelete = assignments
                    .Where(x => !updateModel.Areas.Where(y => y.Id.HasValue).Select(y => y.Id).Contains(x.Id))
                    .ToList();

                var core = await _coreHelper.GetCore();

                await using var sdkDbContext = core.DbContextHelper.GetDbContext();

                foreach (var assignmentForCreate in assignmentsForCreate)
                {
                    var area = await _backendConfigurationPnDbContext.Areas
                        .Include(x => x.AreaTranslations)
                        .FirstAsync(x => x.Id == assignmentForCreate.AreaId);

                    var newAssignment = new AreaProperty
                    {
                        CreatedByUserId = _userService.UserId,
                        UpdatedByUserId = _userService.UserId,
                        AreaId = assignmentForCreate.AreaId,
                        PropertyId = updateModel.PropertyId,
                        Checked = assignmentForCreate.Activated,
                    };
                    await newAssignment.Create(_backendConfigurationPnDbContext);

                    var property = await _backendConfigurationPnDbContext.Properties
                        .Where(x => x.WorkflowState != Constants.WorkflowStates.Removed)
                        .Where(x => x.Id == updateModel.PropertyId)
                        .FirstAsync();
                    switch (area.Type)
                    {
                        case AreaTypesEnum.Type3:
                            {
                                var folderId = await core.FolderCreate(new List<CommonTranslationsModel>
                                {
                                    new()
                                    {
                                        LanguageId = 1, // da
                                        Name = "05. Stalde",
                                        Description = "",
                                    },
                                    new()
                                    {
                                        LanguageId = 2, // en
                                        Name = "05. Stables",
                                        Description = "",
                                    },
                                    new()
                                    {
                                        LanguageId = 3, // ge
                                        Name = "05. Stallungen",
                                        Description = "",
                                    },
                                }, property.FolderId);
                                var assignmentWithOneFolder = new ProperyAreaFolder
                                {
                                    FolderId = folderId,
                                    ProperyAreaAsignmentId = newAssignment.Id,
                                };

                                var assignmentWithTwoFolder = new ProperyAreaFolder
                                {
                                    FolderId = await core.FolderCreate(new List<CommonTranslationsModel>
                                    {
                                        new()
                                        {
                                            LanguageId = 1, // da
                                            Name = "24. Halebid",
                                            Description = "",
                                        },
                                        new()
                                        {
                                            LanguageId = 2, // en
                                            Name = "24. Tail bite",
                                            Description = "",
                                        },
                                        new()
                                        {
                                            LanguageId = 3, // ge
                                            Name = "24. Schwanzbiss",
                                            Description = "",
                                        },
                                    },
                                        property.FolderId),
                                    ProperyAreaAsignmentId = newAssignment.Id,
                                };

                                await assignmentWithOneFolder.Create(_backendConfigurationPnDbContext);
                                await assignmentWithTwoFolder.Create(_backendConfigurationPnDbContext);

                                var groupCreate = await core.EntityGroupCreate(Constants.FieldTypes.EntitySelect, property.Name, "");
                                newAssignment.GroupMicrotingUuid = Convert.ToInt32(groupCreate.MicrotingUUID);
                                await newAssignment.Update(_backendConfigurationPnDbContext);
                                foreach (var areaRule in BackendConfigurationSeedAreas.AreaRules.Where(x => x.AreaId == area.Id))
                                {
                                    areaRule.PropertyId = property.Id;
                                    areaRule.FolderId = folderId;
                                    areaRule.CreatedByUserId = _userService.UserId;
                                    areaRule.UpdatedByUserId = _userService.UserId;
                                    if (!string.IsNullOrEmpty(areaRule.EformName))
                                    {
                                        var eformId = await sdkDbContext.CheckListTranslations
                                            .Where(x => x.Text == areaRule.EformName)
                                            .Select(x => x.CheckListId)
                                            .FirstAsync();
                                        areaRule.EformId = eformId;
                                    }
                                    await areaRule.Create(_backendConfigurationPnDbContext);
                                }
                                break;
                            }
                        case AreaTypesEnum.Type5:
                            {
                                // create folder with stable name
                                var folderId = await core.FolderCreate(
                                    area.AreaTranslations.Select(x => new CommonTranslationsModel
                                    {
                                        Name = x.Name,
                                        LanguageId = x.LanguageId,
                                        Description = "",
                                    }).ToList(),
                                    property.FolderId);
                                //create 7 folders
                                var folderIds = new List<int>
                                {
                                    await core.FolderCreate(new List<CommonTranslationsModel>
                                    {
                                        new()
                                        {
                                            LanguageId = 1, // da
                                            Name = "Søndag",
                                            Description = "",
                                        },
                                        new()
                                        {
                                            LanguageId = 2, // en
                                            Name = "Sunday",
                                            Description = "",
                                        },
                                        new()
                                        {
                                            LanguageId = 3, // ge
                                            Name = "Sonntag",
                                            Description = "",
                                        },
                                    }, folderId),
                                    await core.FolderCreate(new List<CommonTranslationsModel>
                                    {
                                        new()
                                        {
                                            LanguageId = 1, // da
                                            Name = "Mandag",
                                            Description = "",
                                        },
                                        new()
                                        {
                                            LanguageId = 2, // en
                                            Name = "Monday",
                                            Description = "",
                                        },
                                        new()
                                        {
                                            LanguageId = 3, // ge
                                            Name = "Montag",
                                            Description = "",
                                        },
                                    }, folderId),
                                    await core.FolderCreate(new List<CommonTranslationsModel>
                                    {
                                        new()
                                        {
                                            LanguageId = 1, // da
                                            Name = "Tirsdag",
                                            Description = "",
                                        },
                                        new()
                                        {
                                            LanguageId = 2, // en
                                            Name = "Tuesday",
                                            Description = "",
                                        },
                                        new()
                                        {
                                            LanguageId = 3, // ge
                                            Name = "Dienstag",
                                            Description = "",
                                        },
                                    }, folderId),
                                    await core.FolderCreate(new List<CommonTranslationsModel>
                                    {
                                        new()
                                        {
                                            LanguageId = 1, // da
                                            Name = "Onsdag",
                                            Description = "",
                                        },
                                        new()
                                        {
                                            LanguageId = 2, // en
                                            Name = "Wednesday",
                                            Description = "",
                                        },
                                        new()
                                        {
                                            LanguageId = 3, // ge
                                            Name = "Mittwoch",
                                            Description = "",
                                        },
                                    }, folderId),
                                    await core.FolderCreate(new List<CommonTranslationsModel>
                                    {
                                        new()
                                        {
                                            LanguageId = 1, // da
                                            Name = "Torsdag",
                                            Description = "",
                                        },
                                        new()
                                        {
                                            LanguageId = 2, // en
                                            Name = "Thursday",
                                            Description = "",
                                        },
                                        new()
                                        {
                                            LanguageId = 3, // ge
                                            Name = "Donnerstag",
                                            Description = "",
                                        },
                                    }, folderId),
                                    await core.FolderCreate(new List<CommonTranslationsModel>
                                    {
                                        new()
                                        {
                                            LanguageId = 1, // da
                                            Name = "Fredag",
                                            Description = "",
                                        },
                                        new()
                                        {
                                            LanguageId = 2, // en
                                            Name = "Friday",
                                            Description = "",
                                        },
                                        new()
                                        {
                                            LanguageId = 3, // ge
                                            Name = "Freitag",
                                            Description = "",
                                        },
                                    }, folderId),
                                    await core.FolderCreate(new List<CommonTranslationsModel>
                                    {
                                        new()
                                        {
                                            LanguageId = 1, // da
                                            Name = "Lørdag",
                                            Description = "",
                                        },
                                        new()
                                        {
                                            LanguageId = 2, // en
                                            Name = "Saturday",
                                            Description = "",
                                        },
                                        new()
                                        {
                                            LanguageId = 3, // ge
                                            Name = "Samstag",
                                            Description = "",
                                        },
                                    }, folderId),
                                };

                                await new ProperyAreaFolder
                                {
                                    FolderId = folderId,
                                    ProperyAreaAsignmentId = newAssignment.Id,
                                }.Create(_backendConfigurationPnDbContext);

                                foreach (var assignmentWithFolder in folderIds.Select(folderIdLocal => new ProperyAreaFolder
                                {
                                    FolderId = folderIdLocal,
                                    ProperyAreaAsignmentId = newAssignment.Id,
                                }))
                                {
                                    await assignmentWithFolder.Create(_backendConfigurationPnDbContext);
                                }
                                foreach (var areaRule in BackendConfigurationSeedAreas.AreaRules.Where(x => x.AreaId == area.Id))
                                {
                                    areaRule.PropertyId = property.Id;
                                    areaRule.FolderId = folderId;
                                    areaRule.CreatedByUserId = _userService.UserId;
                                    areaRule.UpdatedByUserId = _userService.UserId;
                                    if (!string.IsNullOrEmpty(areaRule.EformName))
                                    {
                                        var eformId = await sdkDbContext.CheckListTranslations
                                            .Where(x => x.Text == areaRule.EformName)
                                            .Select(x => x.CheckListId)
                                            .FirstAsync();
                                        areaRule.EformId = eformId;
                                    }
                                    await areaRule.Create(_backendConfigurationPnDbContext);
                                }
                                break;
                            }
                        default:
                            {
                                var folderId = await core.FolderCreate(
                                    area.AreaTranslations.Select(x => new CommonTranslationsModel
                                    {
                                        Name = x.Name,
                                        LanguageId = x.LanguageId,
                                        Description = "",
                                    }).ToList(),
                                    property.FolderId);
                                var assignmentWithFolder = new ProperyAreaFolder
                                {
                                    FolderId = folderId,
                                    ProperyAreaAsignmentId = newAssignment.Id,
                                };
                                await assignmentWithFolder.Create(_backendConfigurationPnDbContext);
                                foreach (var areaRule in BackendConfigurationSeedAreas.AreaRules.Where(x => x.AreaId == area.Id))
                                {
                                    areaRule.PropertyId = property.Id;
                                    areaRule.FolderId = folderId;
                                    areaRule.CreatedByUserId = _userService.UserId;
                                    areaRule.UpdatedByUserId = _userService.UserId;
                                    if (!string.IsNullOrEmpty(areaRule.EformName))
                                    {
                                        var eformId = await sdkDbContext.CheckListTranslations
                                            .Where(x => x.Text == areaRule.EformName)
                                            .Select(x => x.CheckListId)
                                            .FirstAsync();
                                        areaRule.EformId = eformId;
                                    }
                                    await areaRule.Create(_backendConfigurationPnDbContext);
                                }
                                break;
                            }
                    }

                }

                foreach (var areaPropertyForDelete in assignmentsForDelete)
                {
                    if (areaPropertyForDelete.GroupMicrotingUuid != 0)
                    {
                        await core.EntityGroupDelete(areaPropertyForDelete.GroupMicrotingUuid.ToString());
                    }
                    areaPropertyForDelete.UpdatedByUserId = _userService.UserId;
                    await areaPropertyForDelete.Delete(_backendConfigurationPnDbContext);
                    var foldersIdForDelete = _backendConfigurationPnDbContext.ProperyAreaFolders
                        .Where(x => x.WorkflowState != Constants.WorkflowStates.Removed)
                        .Where(x => x.ProperyAreaAsignmentId == areaPropertyForDelete.Id)
                        .Select(x => x.FolderId)
                        .ToList();

                    foreach (var folderIdForDelete in foldersIdForDelete)
                    {
                        var folder = await sdkDbContext.Folders
                            .Where(x => x.WorkflowState != Constants.WorkflowStates.Removed)
                            .Where(x => x.Id == folderIdForDelete)
                            .FirstAsync();
                        await folder.Delete(sdkDbContext);
                    }
                }

                return new OperationResult(true,
                    _backendConfigurationLocalizationService.GetString("SuccessfullyUpdatePropertyAreas"));
            }
            catch (Exception e)
            {
                Log.LogException(e.Message);
                Log.LogException(e.StackTrace);
                return new OperationResult(false,
                    _backendConfigurationLocalizationService.GetString("ErrorWhileUpdatePropertyAreas"));
            }
        }

        public async Task<OperationDataResult<AreaModel>> ReadArea(int propertyAreaId)
        {
            try
            {
                var areaProperties = await _backendConfigurationPnDbContext.AreaProperties
                    .Where(x => x.WorkflowState != Constants.WorkflowStates.Removed)
                    .Where(x => x.Id == propertyAreaId)
                    .Include(x => x.Area)
                    .ThenInclude(x => x.AreaInitialField)
                    .Include(x => x.Area.AreaTranslations)
                    .Include(x => x.Property)
                    .ThenInclude(x => x.SelectedLanguages)
                    .Include(x => x.Property.PropertyWorkers)
                    .Where(x => x.Area.WorkflowState != Constants.WorkflowStates.Removed)
                    .Where(x => x.Property.WorkflowState != Constants.WorkflowStates.Removed)
                    .FirstOrDefaultAsync();

                if (areaProperties.Property.PropertyWorkers.All(
                    x => x.WorkflowState == Constants.WorkflowStates.Removed))
                {
                    return new OperationDataResult<AreaModel>(false,
                        _backendConfigurationLocalizationService.GetString("NotFoundPropertyWorkerAssignments"));
                }

                if (areaProperties.Area == null)
                {
                    return new OperationDataResult<AreaModel>(false,
                        _backendConfigurationLocalizationService.GetString("NotFoundArea"));
                }

                var core = await _coreHelper.GetCore();
                var sdkDbContex = core.DbContextHelper.GetDbContext();
                var sites = new List<SiteDto>();

                foreach (var worker in areaProperties.Property.PropertyWorkers
                    .Where(x => x.WorkflowState != Constants.WorkflowStates.Removed).Select(x => x.WorkerId))
                {
                    var site = await sdkDbContex.Sites
                        .Where(x => x.Id == worker)
                        .FirstAsync();
                    sites.Add(new SiteDto()
                    {
                        SiteId = worker,
                        SiteName = site.Name,
                    });
                }

                var languages = await sdkDbContex.Languages.AsNoTracking().ToListAsync();
                var language = await _userService.GetCurrentUserLanguage();

                var areaModel = new AreaModel
                {
                    Name = areaProperties.Area.AreaTranslations.Where(x => x.LanguageId == language.Id)
                        .Select(x => x.Name).FirstOrDefault(),
                    Id = areaProperties.AreaId,
                    Languages = areaProperties.Property.SelectedLanguages
                        .Where(x => x.WorkflowState != Constants.WorkflowStates.Removed)
                        .Select(x => new CommonDictionaryModel
                        {
                            Id = x.LanguageId,
                            Name = languages.First(y => y.Id == x.LanguageId).Name,
                        }).ToList(),
                    AvailableWorkers = sites,
                    Type = areaProperties.Area.Type,
                    InitialFields = areaProperties.Area.AreaInitialField != null
                        ? new AreaInitialFields
                        {
                            Alarm = areaProperties.Area.AreaInitialField.Alarm,
                            DayOfWeek = areaProperties.Area.AreaInitialField.DayOfWeek,
                            EformName = areaProperties.Area.AreaInitialField.EformName,
                            SendNotifications = areaProperties.Area.AreaInitialField.Notifications,
                            RepeatType = areaProperties.Area.AreaInitialField.RepeatType,
                            Type = areaProperties.Area.AreaInitialField.Type,
                            RepeatEvery = areaProperties.Area.AreaInitialField.RepeatEvery,
                            EndDate = areaProperties.Area.AreaInitialField.EndDate,
                        }
                        : null,
                };
                if (areaModel.InitialFields != null && !string.IsNullOrEmpty(areaModel.InitialFields.EformName))
                {
                    areaModel.InitialFields.EformId = await sdkDbContex.CheckListTranslations
                        .Where(x => x.Text == areaModel.InitialFields.EformName)
                        .Select(x => x.CheckListId)
                        .FirstOrDefaultAsync();
                }

                return new OperationDataResult<AreaModel>(true, areaModel);
            }
            catch (Exception e)
            {
                Log.LogException(e.Message);
                Log.LogException(e.StackTrace);
                return new OperationDataResult<AreaModel>(false,
                    _backendConfigurationLocalizationService.GetString("ErrorWhileReadArea"));
            }
        }
    }
}
