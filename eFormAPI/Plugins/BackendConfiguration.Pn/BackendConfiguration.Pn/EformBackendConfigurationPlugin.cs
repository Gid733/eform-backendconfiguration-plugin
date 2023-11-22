﻿/*
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


namespace BackendConfiguration.Pn
{
    using ChemicalsBase.Infrastructure;
    using ChemicalsBase.Infrastructure.Data.Factories;
    using eFormCore;
    using Infrastructure.Data.Seed;
    using Infrastructure.Data.Seed.Data;
    using Infrastructure.Models.Settings;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microting.eForm.Infrastructure;
    using Microting.eForm.Infrastructure.Data.Entities;
    using Microting.eForm.Infrastructure.Models;
    using Microting.eFormApi.BasePn;
    using Microting.eFormApi.BasePn.Abstractions;
    using Microting.eFormApi.BasePn.Infrastructure.Consts;
    using Microting.eFormApi.BasePn.Infrastructure.Database.Extensions;
    using Microting.eFormApi.BasePn.Infrastructure.Helpers;
    using Microting.eFormApi.BasePn.Infrastructure.Models.Application;
    using Microting.eFormApi.BasePn.Infrastructure.Models.Application.NavigationMenu;
    using Microting.eFormApi.BasePn.Infrastructure.Settings;
    using Microting.EformBackendConfigurationBase.Infrastructure.Const;
    using Microting.EformBackendConfigurationBase.Infrastructure.Data;
    using Microting.EformBackendConfigurationBase.Infrastructure.Data.Factories;
    using Microting.eFormCaseTemplateBase.Infrastructure.Data;
    using Microting.eFormCaseTemplateBase.Infrastructure.Data.Factories;
    using Microting.ItemsPlanningBase.Infrastructure.Data;
    using Microting.ItemsPlanningBase.Infrastructure.Data.Entities;
    using Microting.TimePlanningBase.Infrastructure.Data;
    using Rebus.Bus;
    using Services.BackendConfigurationAreaRulePlanningsService;
    using Services.BackendConfigurationAreaRulesService;
    using Services.BackendConfigurationAssignmentWorkerService;
    using Services.BackendConfigurationCaseService;
    using Services.BackendConfigurationCompliancesService;
    using Services.BackendConfigurationDocumentService;
    using Services.BackendConfigurationFilesService;
    using Services.BackendConfigurationFileTagsService;
    using Services.BackendConfigurationLocalizationService;
    using Services.BackendConfigurationPropertiesService;
    using Services.BackendConfigurationPropertyAreasService;
    using Services.BackendConfigurationReportService;
    using Services.BackendConfigurationStatsService;
    using Services.BackendConfigurationTaskManagementService;
    using Services.BackendConfigurationTaskTrackerService;
    using Services.BackendConfigurationTaskWizardService;
    using Services.ChemicalService;
    using Services.ExcelService;
    using Services.RebusService;
    using Services.WordService;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Threading.Tasks;
    using FolderTranslation = Microting.eForm.Infrastructure.Data.Entities.FolderTranslation;

    public class EformBackendConfigurationPlugin : IEformPlugin
    {
        public string Name => "Microting Backend Configuration Plugin";
        public string PluginId => "eform-backend-configuration-plugin";
        public string PluginPath => PluginAssembly().Location;
        public string PluginBaseUrl => "backend-configuration-pn";
        private static IBus _bus;

        private string _connectionString;

        public Assembly PluginAssembly()
        {
            return typeof(EformBackendConfigurationPlugin).GetTypeInfo().Assembly;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IBackendConfigurationAreaRulePlanningsService, BackendConfigurationAreaRulePlanningsService>();
            services.AddTransient<IBackendConfigurationAssignmentWorkerService, BackendConfigurationAssignmentWorkerService>();
            services.AddTransient<IBackendConfigurationTaskManagementService, BackendConfigurationTaskManagementService>();
            services.AddTransient<IBackendConfigurationPropertyAreasService, BackendConfigurationPropertyAreasService>();
            services.AddSingleton<IBackendConfigurationLocalizationService, BackendConfigurationLocalizationService>();
            services.AddTransient<IBackendConfigurationCompliancesService, BackendConfigurationCompliancesService>();
            services.AddTransient<IBackendConfigurationTaskTrackerService, BackendConfigurationTaskTrackerService>();
            services.AddTransient<IBackendConfigurationPropertiesService, BackendConfigurationPropertiesService>();
            services.AddTransient<IBackendConfigurationTaskWizardService, BackendConfigurationTaskWizardService>();
            services.AddTransient<IBackendConfigurationAreaRulesService, BackendConfigurationAreaRulesService>();
            services.AddTransient<IBackendConfigurationDocumentService, BackendConfigurationDocumentService>();
            services.AddTransient<IBackendConfigurationReportService, BackendConfigurationReportService>();
            services.AddTransient<IBackendConfigurationFilesService, BackendConfigurationFilesService>();
            services.AddTransient<IBackendConfigurationStatsService, BackendConfigurationStatsService>();
            services.AddTransient<IBackendConfigurationCaseService, BackendConfigurationCaseService>();
            services.AddTransient<IBackendConfigurationTagsService, BackendConfigurationTagsService>();
            services.AddTransient<IChemicalService, ChemicalService>();
            services.AddSingleton<IRebusService, RebusService>();
            services.AddTransient<IExcelService, ExcelService>();
            services.AddTransient<IWordService, WordService>();
            services.AddControllers();
            SeedEForms(services);
        }

        public void AddPluginConfig(IConfigurationBuilder builder, string connectionString)
        {
            var seedData = new BackendConfigurationSeedData();
            var contextFactory = new BackendConfigurationPnContextFactory();
            builder.AddPluginConfiguration(
                connectionString,
                seedData,
                contextFactory);
        }

        public void ConfigureOptionsServices(
            IServiceCollection services,
            IConfiguration configuration)
        {
            services.ConfigurePluginDbOptions<BackendConfigurationBaseSettings>(
                configuration.GetSection("BackendConfigurationSettings"));
        }

        private static async void SeedEForms(IServiceCollection services)
        {
            var serviceProvider = services.BuildServiceProvider();

            var core = await serviceProvider.GetRequiredService<IEFormCoreService>().GetCore().ConfigureAwait(false);
            var eforms = BackendConfigurationSeedEforms.GetForms();
            var sdkDbContext = core.DbContextHelper.GetDbContext();

            var orgFields = await sdkDbContext.Fields.Where(x => x.OriginalId == "376935").ToListAsync();

            var englishLanguage = await sdkDbContext.Languages.FirstOrDefaultAsync(x => x.LanguageCode == "en-US");
            var germanLanguage = await sdkDbContext.Languages.FirstOrDefaultAsync(x => x.LanguageCode == "de-DE");

            foreach (var orgField in orgFields)
            {
	            var englishFt = await sdkDbContext.FieldTranslations.FirstOrDefaultAsync(x =>
		            x.FieldId == orgField.Id && x.LanguageId == englishLanguage.Id);

	            if (englishFt == null)
	            {
		            var fieldTranslation = new FieldTranslation
		            {
			            FieldId = orgField.Id,
			            LanguageId = englishLanguage.Id,
			            Text = "Priority",
			            Description = ""
		            };
		            await fieldTranslation.Create(sdkDbContext);
	            }

	            var germanFt = await sdkDbContext.FieldTranslations.FirstOrDefaultAsync(x =>
		            x.FieldId == orgField.Id && x.LanguageId == germanLanguage.Id);

	            if (germanFt == null)
	            {
		            var fieldTranslation = new FieldTranslation
		            {
			            FieldId = orgField.Id,
			            LanguageId = germanLanguage.Id,
			            Text = "Priorität",
			            Description = ""
		            };
		            await fieldTranslation.Create(sdkDbContext);
	            }

            }


            var context = serviceProvider.GetRequiredService<BackendConfigurationPnDbContext>();
            var itemsPlanningContext = serviceProvider.GetRequiredService<ItemsPlanningPnDbContext>();
            var caseTemplateContext = serviceProvider.GetRequiredService<CaseTemplatePnDbContext>();
            // seed eforms
            var assembly = Assembly.GetExecutingAssembly();
            foreach (var (eformName, eform) in eforms)
            {
                try
                {
                    var resourceStream =
                        assembly.GetManifestResourceStream($"BackendConfiguration.Pn.Resources.eForms.{eformName}.xml");

                    if (eformName == "00. Info boks")
                    {
                        Console.WriteLine("weffw");
                    }
                    if (resourceStream == null)
                    {
                        Console.WriteLine(eformName);
                    }
                    else
                    {
	                    List<string> hiddenIds = new List<string>
	                    {
		                    "1412",
		                    "142663new2",
		                    "142664new2",
		                    "142665",
		                    "8756",
		                    "142720"
	                    };
	                    string contents;
                        using (var sr = new StreamReader(resourceStream))
                        {
                            contents = await sr.ReadToEndAsync().ConfigureAwait(false);
                        }

                        switch (eformName)
                        {
                            case "05. Halebid og risikovurdering":
                                contents = contents.Replace("SOURCE_REPLACE_ME", "123");
                                break;
                            case "01. Aflæsninger":
                            case "02. Fækale uheld":
                                contents = contents.Replace("REPLACE_ME", "123");
                                break;
                            case "25.01 Registrer produkter":
                                contents = contents.Replace("SOURCE_REPLACE_ME_2", "123");
                                contents = contents.Replace("SOURCE_REPLACE_ME", "456");
                                break;
                        }

                        var newTemplate = await core.TemplateFromXml(contents).ConfigureAwait(false);
                        if (!await sdkDbContext.CheckLists
                                .AnyAsync(x => x.OriginalId == newTemplate.OriginalId
                                               && x.WorkflowState != Microting.eForm.Infrastructure.Constants.Constants.WorkflowStates.Removed).ConfigureAwait(false))
                        {
                            var clId = await core.TemplateCreate(newTemplate).ConfigureAwait(false);
                            var cl = await sdkDbContext.CheckLists.SingleAsync(x => x.Id == clId).ConfigureAwait(false);
                            cl.IsHidden = hiddenIds.Contains(cl.OriginalId);
                            cl.IsLocked = true;
                            cl.IsEditable = false;
                            cl.ReportH1 = eform[0];
                            cl.ReportH2 = eform[1];
                            cl.ReportH3 = eform.Count == 3 ? eform[2] : "";
                            cl.ReportH4 = eform.Count == 4 ? eform[3] : "";
                            cl.IsDoneAtEditable = true;
                            cl.QuickSyncEnabled = 1;
                            await cl.Update(sdkDbContext).ConfigureAwait(false);
                            var subCl = await sdkDbContext.CheckLists.SingleAsync(x => x.ParentId == cl.Id).ConfigureAwait(false);
                            subCl.QuickSyncEnabled = 1;
                            await subCl.Update(sdkDbContext).ConfigureAwait(false);
                        }
                        else
                        {
                            try
                            {
                                var cl = await sdkDbContext.CheckLists.SingleAsync(x =>
                                    x.OriginalId == newTemplate.OriginalId && x.ParentId == null &&
                                    x.WorkflowState != Microting.eForm.Infrastructure.Constants.Constants.WorkflowStates.Removed).ConfigureAwait(false);
                                cl.IsHidden = hiddenIds.Contains(cl.OriginalId);
                                cl.IsLocked = true;
                                cl.IsEditable = false;
                                cl.ReportH1 = eform[0];
                                cl.ReportH2 = eform[1];
                                cl.ReportH3 = eform.Count == 3 ? eform[2] : "";
                                cl.ReportH4 = eform.Count == 4 ? eform[3] : "";
                                cl.IsDoneAtEditable = true;
                                cl.QuickSyncEnabled = 1;
                                await cl.Update(sdkDbContext).ConfigureAwait(false);
                                var subCl = await sdkDbContext.CheckLists.SingleAsync(x => x.ParentId == cl.Id).ConfigureAwait(false);
                                subCl.QuickSyncEnabled = 1;
                                await subCl.Update(sdkDbContext).ConfigureAwait(false);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                        }
                    }
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }
            var cls = await sdkDbContext.CheckLists.Where(x =>
                x.OriginalId == "142719" && x.WorkflowState != Microting.eForm.Infrastructure.Constants
                    .Constants.WorkflowStates.Removed).ToListAsync();
            foreach (var checkList in cls)
            {
                await checkList.Delete(sdkDbContext);
                var clts = await sdkDbContext.CheckListTranslations.Where(x =>
                    x.CheckListId == checkList.Id).ToListAsync();

                foreach (var clt in clts)
                {
                    await clt.Delete(sdkDbContext);
                }
            }

            // Seed areas
            foreach (var newArea in BackendConfigurationSeedAreas.AreasSeed
	                     .Where(newArea => !context.Areas.Any(x => x.Id == newArea.Id))
	                     .Where(x => x.IsDisabled == false))
            {
                await newArea.Create(context).ConfigureAwait(false);
            }

            var tailBitPlanningTag = await itemsPlanningContext.PlanningTags.Where(x => x.Name == "Halebid").FirstOrDefaultAsync();

            if (tailBitPlanningTag != null)
            {
                var plannings = await itemsPlanningContext.Plannings
                    .Where(x => x.RelatedEFormName.Contains("Halebid"))
                    .Where(x => x.ReportGroupPlanningTagId == null)
                    .ToListAsync();

                foreach (var planning in plannings)
                {
                    planning.ReportGroupPlanningTagId = tailBitPlanningTag.Id;
                    await planning.Update(itemsPlanningContext);
                }
            }
        }

		public void ConfigureDbContext(IServiceCollection services, string connectionString)
        {
            var itemsPlannigConnectionString = connectionString.Replace(
                "eform-backend-configuration-plugin",
                "eform-angular-items-planning-plugin");
            var timeRegistrationConnectionString = connectionString.Replace(
                "eform-backend-configuration-plugin",
                "eform-angular-time-planning-plugin");
            var chemicalBaseConnectionString = connectionString.Replace(
                "eform-backend-configuration-plugin",
                "chemical-base-plugin");
            var documentsConnectionString = connectionString.Replace(
                "eform-backend-configuration-plugin",
                "eform-angular-case-template-plugin");

            _connectionString = connectionString;
            services.AddDbContext<BackendConfigurationPnDbContext>(o =>
                o.UseMySql(connectionString, new MariaDbServerVersion(
                    ServerVersion.AutoDetect(connectionString)), mySqlOptionsAction: builder =>
                {
                    builder.EnableRetryOnFailure();
                    builder.MigrationsAssembly(PluginAssembly().FullName);
                }));

            services.AddDbContext<ItemsPlanningPnDbContext>(o =>
                o.UseMySql(itemsPlannigConnectionString, new MariaDbServerVersion(
                    ServerVersion.AutoDetect(itemsPlannigConnectionString)), mySqlOptionsAction: builder =>
                {
                    builder.EnableRetryOnFailure();
                    builder.MigrationsAssembly(PluginAssembly().FullName);
                }));

            services.AddDbContext<TimePlanningPnDbContext>(o =>
                o.UseMySql(timeRegistrationConnectionString, new MariaDbServerVersion(
                    ServerVersion.AutoDetect(timeRegistrationConnectionString)), mySqlOptionsAction: builder =>
                {
                    builder.EnableRetryOnFailure();
                    builder.MigrationsAssembly(PluginAssembly().FullName);
                }));

            services.AddDbContext<ChemicalsDbContext>(o =>
                o.UseMySql(chemicalBaseConnectionString, new MariaDbServerVersion(
                    ServerVersion.AutoDetect(chemicalBaseConnectionString)), mySqlOptionsAction: builder =>
                {
                    builder.EnableRetryOnFailure();
                    builder.MigrationsAssembly(PluginAssembly().FullName);
                }));

            services.AddDbContext<CaseTemplatePnDbContext>(o =>
                o.UseMySql(documentsConnectionString, new MariaDbServerVersion(
                    ServerVersion.AutoDetect(documentsConnectionString)), mySqlOptionsAction: builder =>
                {
                    builder.EnableRetryOnFailure();
                    builder.MigrationsAssembly(PluginAssembly().FullName);
                }));

            var chemicalsContextFactory = new ChemicalsContextFactory();
            var chemicalsDbContext = chemicalsContextFactory.CreateDbContext(new[] { chemicalBaseConnectionString });
            chemicalsDbContext.Database.Migrate();

            var caseTemplatePnContextFactory = new CaseTemplatePnContextFactory();
            var caseTemplateContext = caseTemplatePnContextFactory.CreateDbContext(new[] { documentsConnectionString });
            caseTemplateContext.Database.Migrate();

            var contextFactory = new BackendConfigurationPnContextFactory();
            var context = contextFactory.CreateDbContext(new[] { connectionString });
            context.Database.Migrate();

            // Seed database
            SeedDatabase(connectionString);

            //SeedEForms(services, connectionString);
        }

        public void Configure(IApplicationBuilder appBuilder)
        {
            var serviceProvider = appBuilder.ApplicationServices;

            IRebusService rebusService = serviceProvider.GetService<IRebusService>();
            rebusService!.Start(_connectionString).GetAwaiter().GetResult();
            _bus = rebusService.GetBus();
        }

        public List<PluginMenuItemModel> GetNavigationMenu(IServiceProvider serviceProvider)
        {
            var pluginMenu = new List<PluginMenuItemModel>
            {
                new()
                {
                    Name = "Dropdown",
                    E2EId = "backend-configuration-pn",
                    Link = "",
                    Type = MenuItemTypeEnum.Dropdown,
                    Position = 0,
                    Translations = new List<PluginMenuTranslationModel>
                    {
                        new()
                        {
                            LocaleName = LocaleNames.English,
                            Name = "Backend Configuration",
                            Language = LanguageNames.English
                        },
                        new()
                        {
                            LocaleName = LocaleNames.German,
                            Name = "Aufbau",
                            Language = LanguageNames.German
                        },
                        new()
                        {
                            LocaleName = LocaleNames.Danish,
                            Name = "Konfiguration",
                            Language = LanguageNames.Danish
                        },
                        new()
                        {
                            LocaleName = LocaleNames.Ukrainian,
                            Name = "Конфігурація серверної частини",
                            Language = LanguageNames.Ukrainian
                        }
                    },
                    ChildItems = new List<PluginMenuItemModel>
                    {
                        new()
                        {
                            Name = "Properties",
                            E2EId = "backend-configuration-pn-properties",
                            Link = "/plugins/backend-configuration-pn/properties",
                            Type = MenuItemTypeEnum.Link,
                            Position = 0,
                            MenuTemplate = new PluginMenuTemplateModel
                            {
                                Name = "Properties",
                                E2EId = "backend-configuration-pn-properties",
                                DefaultLink = "/plugins/backend-configuration-pn/properties",
                                Permissions = new List<PluginMenuTemplatePermissionModel>(),
                                Translations = new List<PluginMenuTranslationModel>
                                {
                                    new()
                                    {
                                        LocaleName = LocaleNames.English,
                                        Name = "Properties",
                                        Language = LanguageNames.English
                                    },
                                    new()
                                    {
                                        LocaleName = LocaleNames.German,
                                        Name = "Eigenschaften",
                                        Language = LanguageNames.German
                                    },
                                    new()
                                    {
                                        LocaleName = LocaleNames.Danish,
                                        Name = "Ejendomme",
                                        Language = LanguageNames.Danish
                                    },
                                    new()
                                    {
                                        LocaleName = LocaleNames.Ukrainian,
                                        Name = "Властивості",
                                        Language = LanguageNames.Ukrainian
                                    }
                                }
                            },
                            Translations = new List<PluginMenuTranslationModel>
                            {
                                new()
                                {
                                    LocaleName = LocaleNames.English,
                                    Name = "Properties",
                                    Language = LanguageNames.English
                                },
                                new()
                                {
                                    LocaleName = LocaleNames.German,
                                    Name = "Eigenschaften",
                                    Language = LanguageNames.German
                                },
                                new()
                                {
                                    LocaleName = LocaleNames.Danish,
                                    Name = "Ejendomme",
                                    Language = LanguageNames.Danish
                                },
                                new()
                                {
                                    LocaleName = LocaleNames.Ukrainian,
                                    Name = "Властивості",
                                    Language = LanguageNames.Ukrainian
                                }
                            }
                        },
                        new()
                        {
                            Name = "Workers",
                            E2EId = "backend-configuration-pn-property-workers",
                            Link = "/plugins/backend-configuration-pn/property-workers",
                            Type = MenuItemTypeEnum.Link,
                            Position = 1,
                            MenuTemplate = new PluginMenuTemplateModel
                            {
                                Name = "Workers",
                                E2EId = "backend-configuration-pn-property-workers",
                                DefaultLink = "/plugins/backend-configuration-pn/property-workers",
                                Permissions = new List<PluginMenuTemplatePermissionModel>(),
                                Translations = new List<PluginMenuTranslationModel>
                                {
                                    new()
                                    {
                                        LocaleName = LocaleNames.English,
                                        Name = "Workers",
                                        Language = LanguageNames.English
                                    },
                                    new()
                                    {
                                        LocaleName = LocaleNames.German,
                                        Name = "Mitarbeiter",
                                        Language = LanguageNames.German
                                    },
                                    new()
                                    {
                                        LocaleName = LocaleNames.Danish,
                                        Name = "Medarbejdere",
                                        Language = LanguageNames.Danish
                                    },
                                    new()
                                    {
                                        LocaleName = LocaleNames.Ukrainian,
                                        Name = "Працівники",
                                        Language = LanguageNames.Ukrainian
                                    }
                                }
                            },
                            Translations = new List<PluginMenuTranslationModel>
                            {
                                new()
                                {
                                    LocaleName = LocaleNames.English,
                                    Name = "Workers",
                                    Language = LanguageNames.English
                                },
                                new()
                                {
                                    LocaleName = LocaleNames.German,
                                    Name = "Mitarbeiter",
                                    Language = LanguageNames.German
                                },
                                new()
                                {
                                    LocaleName = LocaleNames.Danish,
                                    Name = "Medarbejdere",
                                    Language = LanguageNames.Danish
                                },
                                new()
                                {
                                    LocaleName = LocaleNames.Ukrainian,
                                    Name = "Працівники",
                                    Language = LanguageNames.Ukrainian
                                }
                            }
                        },
                        new()
                        {
                            Name = "Task management",
                            E2EId = "backend-configuration-pn-task-management",
                            Link = "/plugins/backend-configuration-pn/task-management",
                            Type = MenuItemTypeEnum.Link,
                            Position = 2,
                            MenuTemplate = new PluginMenuTemplateModel
                            {
                                Name = "Task management",
                                E2EId = "backend-configuration-pn-task-management",
                                DefaultLink = "/plugins/backend-configuration-pn/task-management",
                                Permissions = new List<PluginMenuTemplatePermissionModel>(),
                                Translations = new List<PluginMenuTranslationModel>
                                {
                                    new()
                                    {
                                        LocaleName = LocaleNames.English,
                                        Name = "Task management",
                                        Language = LanguageNames.English
                                    },
                                    new()
                                    {
                                        LocaleName = LocaleNames.German,
                                        Name = "Aufgabenverwaltung",
                                        Language = LanguageNames.German
                                    },
                                    new()
                                    {
                                        LocaleName = LocaleNames.Danish,
                                        Name = "Opgavestyring",
                                        Language = LanguageNames.Danish
                                    },
                                    new()
                                    {
                                        LocaleName = LocaleNames.Ukrainian,
                                        Name = "Управління завданнями",
                                        Language = LanguageNames.Ukrainian
                                    }
                                }
                            },
                            Translations = new List<PluginMenuTranslationModel>
                            {
                                new()
                                {
                                    LocaleName = LocaleNames.English,
                                    Name = "Task management",
                                    Language = LanguageNames.English
                                },
                                new()
                                {
                                    LocaleName = LocaleNames.German,
                                    Name = "Aufgabenverwaltung",
                                    Language = LanguageNames.German
                                },
                                new()
                                {
                                    LocaleName = LocaleNames.Danish,
                                    Name = "Opgavestyring",
                                    Language = LanguageNames.Danish
                                },
                                new()
                                {
                                    LocaleName = LocaleNames.Ukrainian,
                                    Name = "Управління завданнями",
                                    Language = LanguageNames.Ukrainian
                                }
                            }
                        },
                        new()
                            {
                                Name = "Reports",
                                E2EId = "backend-configuration-pn-reports",
                                Link = "/plugins/backend-configuration-pn/reports",
                                Type = MenuItemTypeEnum.Link,
                                Position = 3,
                                MenuTemplate = new PluginMenuTemplateModel
                                {
                                    Name = "Reports",
                                    E2EId = "backend-configuration-pn-reports",
                                    DefaultLink = "/plugins/backend-configuration-pn/reports",
                                    Permissions = new List<PluginMenuTemplatePermissionModel>(),
                                    Translations = new List<PluginMenuTranslationModel>
                                    {
                                        new PluginMenuTranslationModel
                                        {
                                            LocaleName = LocaleNames.English,
                                            Name = "Reports",
                                            Language = LanguageNames.English
                                        },
                                        new PluginMenuTranslationModel
                                        {
                                            LocaleName = LocaleNames.German,
                                            Name = "Berichte",
                                            Language = LanguageNames.German
                                        },
                                        new PluginMenuTranslationModel
                                        {
                                            LocaleName = LocaleNames.Danish,
                                            Name = "Rapporter",
                                            Language = LanguageNames.Danish
                                        },
                                        new PluginMenuTranslationModel
                                        {
                                            LocaleName = LocaleNames.Ukrainian,
                                            Name = "Звіти",
                                            Language = LanguageNames.Ukrainian
                                        }
                                    }
                                },
                                Translations = new List<PluginMenuTranslationModel>
                                {
                                    new PluginMenuTranslationModel
                                    {
                                        LocaleName = LocaleNames.English,
                                        Name = "Reports",
                                        Language = LanguageNames.English
                                    },
                                    new PluginMenuTranslationModel
                                    {
                                        LocaleName = LocaleNames.German,
                                        Name = "Berichte",
                                        Language = LanguageNames.German
                                    },
                                    new PluginMenuTranslationModel
                                    {
                                        LocaleName = LocaleNames.Danish,
                                        Name = "Rapporter",
                                        Language = LanguageNames.Danish
                                    },
                                    new PluginMenuTranslationModel
                                    {
                                        LocaleName = LocaleNames.Ukrainian,
                                        Name = "Звіти",
                                        Language = LanguageNames.Ukrainian
                                    }
                                }
                            },
                        new()
                        {
                            Name = "Documents",
                            E2EId = "backend-configuration-pn-documents",
                            Link = "/plugins/backend-configuration-pn/documents",
                            Type = MenuItemTypeEnum.Link,
                            Position = 4,
                            MenuTemplate = new PluginMenuTemplateModel
                            {
                                Name = "Documents",
                                E2EId = "backend-configuration-pn-documents",
                                DefaultLink = "/plugins/backend-configuration-pn/documents",
                                Permissions = new List<PluginMenuTemplatePermissionModel>(),
                                Translations = new List<PluginMenuTranslationModel>
                                {
                                    new()
                                    {
                                        LocaleName = LocaleNames.English,
                                        Name = "Documents",
                                        Language = LanguageNames.English
                                    },
                                    new()
                                    {
                                        LocaleName = LocaleNames.German,
                                        Name = "Unterlagen",
                                        Language = LanguageNames.German
                                    },
                                    new()
                                    {
                                        LocaleName = LocaleNames.Danish,
                                        Name = "Dokumenter",
                                        Language = LanguageNames.Danish
                                    },
                                    new()
                                    {
                                        LocaleName = LocaleNames.Ukrainian,
                                        Name = "Документи",
                                        Language = LanguageNames.Ukrainian
                                    }
                                }
                            },
                            Translations = new List<PluginMenuTranslationModel>
                            {
                                new()
                                {
                                    LocaleName = LocaleNames.English,
                                    Name = "Documents",
                                    Language = LanguageNames.English
                                },
                                new()
                                {
                                    LocaleName = LocaleNames.German,
                                    Name = "Unterlagen",
                                    Language = LanguageNames.German
                                },
                                new()
                                {
                                    LocaleName = LocaleNames.Danish,
                                    Name = "Dokumenter",
                                    Language = LanguageNames.Danish
                                },
                                new()
                                {
                                    LocaleName = LocaleNames.Ukrainian,
                                    Name = "Документи",
                                    Language = LanguageNames.Ukrainian
                                }
                            }
                        },
						new()
						{
							Name = "Files",
							E2EId = "backend-configuration-pn-files",
							Link = "/plugins/backend-configuration-pn/files",
							Type = MenuItemTypeEnum.Link,
							Position = 5,
							MenuTemplate = new PluginMenuTemplateModel
							{
								Name = "Files",
								E2EId = "backend-configuration-pn-files",
								DefaultLink = "/plugins/backend-configuration-pn/files",
								Permissions = new List<PluginMenuTemplatePermissionModel>(),
								Translations = new List<PluginMenuTranslationModel>
								{
									new()
									{
										LocaleName = LocaleNames.English,
										Name = "Files",
										Language = LanguageNames.English
									},
									new()
									{
										LocaleName = LocaleNames.German,
										Name = "Datei",
										Language = LanguageNames.German
									},
									new()
									{
										LocaleName = LocaleNames.Danish,
										Name = "Fil",
										Language = LanguageNames.Danish
									},
									new()
									{
										LocaleName = LocaleNames.Ukrainian,
										Name = "Файли",
										Language = LanguageNames.Ukrainian
									}
								}
							},
							Translations = new List<PluginMenuTranslationModel>
							{
								new()
								{
									LocaleName = LocaleNames.English,
									Name = "Files",
									Language = LanguageNames.English
								},
								new()
								{
									LocaleName = LocaleNames.German,
									Name = "Datei",
									Language = LanguageNames.German
								},
								new()
								{
									LocaleName = LocaleNames.Danish,
									Name = "Fil",
									Language = LanguageNames.Danish
								},
								new()
								{
									LocaleName = LocaleNames.Ukrainian,
									Name = "Файли",
									Language = LanguageNames.Ukrainian
								}
							}
						},
						new()
						{
							Name = "Task tracker",
							E2EId = "backend-configuration-pn-task-tracker",
							Link = "/plugins/backend-configuration-pn/task-tracker",
							Type = MenuItemTypeEnum.Link,
							Position = 6,
							MenuTemplate = new PluginMenuTemplateModel
							{
								Name = "Task tracker",
								E2EId = "backend-configuration-pn-task-tracker",
								DefaultLink = "/plugins/backend-configuration-pn/task-tracker",
								Permissions = new List<PluginMenuTemplatePermissionModel>(),
								Translations = new List<PluginMenuTranslationModel>
								{
									new()
									{
										LocaleName = LocaleNames.English,
										Name = "Task tracker",
										Language = LanguageNames.English
									},
									new()
									{
										LocaleName = LocaleNames.German,
										Name = "Aufgabenverfolgung",
										Language = LanguageNames.German
									},
									new()
									{
										LocaleName = LocaleNames.Danish,
										Name = "Medarbejder",
										Language = LanguageNames.Danish
									},
									new()
									{
										LocaleName = LocaleNames.Ukrainian,
										Name = "Відстежувач завдань",
										Language = LanguageNames.Ukrainian
									}
								}
							},
							Translations = new List<PluginMenuTranslationModel>
							{
								new()
								{
									LocaleName = LocaleNames.English,
									Name = "Task tracker",
									Language = LanguageNames.English
								},
								new()
								{
									LocaleName = LocaleNames.German,
									Name = "Aufgabenverfolgung",
									Language = LanguageNames.German
								},
								new()
								{
									LocaleName = LocaleNames.Danish,
									Name = "Medarbejder",
									Language = LanguageNames.Danish
								},
								new()
								{
									LocaleName = LocaleNames.Ukrainian,
									Name = "Відстежувач завдань",
									Language = LanguageNames.Ukrainian
								}
							}
						},
                        new()
                        {
                            Name = "Task wizard",
                            E2EId = "backend-configuration-pn-task-wizard",
                            Link = "/plugins/backend-configuration-pn/task-wizard",
                            Type = MenuItemTypeEnum.Link,
                            Position = 6,
                            MenuTemplate = new PluginMenuTemplateModel
                            {
                                Name = "Task wizard",
                                E2EId = "backend-configuration-pn-task-wizard",
                                DefaultLink = "/plugins/backend-configuration-pn/task-wizard",
                                Permissions = new List<PluginMenuTemplatePermissionModel>(),
                                Translations = new List<PluginMenuTranslationModel>
                                {
                                    new()
                                    {
                                        LocaleName = LocaleNames.English,
                                        Name = "Task wizard",
                                        Language = LanguageNames.English
                                    },
                                    new()
                                    {
                                        LocaleName = LocaleNames.German,
                                        Name = "Aufgaben-Assistent",
                                        Language = LanguageNames.German
                                    },
                                    new()
                                    {
                                        LocaleName = LocaleNames.Danish,
                                        Name = "Opgaveguide",
                                        Language = LanguageNames.Danish
                                    },
                                    new()
                                    {
                                        LocaleName = LocaleNames.Ukrainian,
                                        Name = "Майстер завдань",
                                        Language = LanguageNames.Ukrainian
                                    }
                                }
                            },
                            Translations = new List<PluginMenuTranslationModel>
                            {
                                new()
                                {
                                    LocaleName = LocaleNames.English,
                                    Name = "Task wizard",
                                    Language = LanguageNames.English
                                },
                                new()
                                {
                                    LocaleName = LocaleNames.German,
                                    Name = "Aufgaben-Assistent",
                                    Language = LanguageNames.German
                                },
                                new()
                                {
                                    LocaleName = LocaleNames.Danish,
                                    Name = "Opgaveguide",
                                    Language = LanguageNames.Danish
                                },
                                new()
                                {
                                    LocaleName = LocaleNames.Ukrainian,
                                    Name = "Майстер завдань",
                                    Language = LanguageNames.Ukrainian
                                }
                            }
                        },
                        new()
                        {
                            Name = "Statistics",
                            E2EId = "backend-configuration-pn-statistics",
                            Link = "/plugins/backend-configuration-pn/statistics",
                            Type = MenuItemTypeEnum.Link,
                            Position = 7,
                            MenuTemplate = new PluginMenuTemplateModel
                            {
                                Name = "Statistics",
                                E2EId = "backend-configuration-pn-statistics",
                                DefaultLink = "/plugins/backend-configuration-pn/statistics",
                                Permissions = new List<PluginMenuTemplatePermissionModel>(),
                                Translations = new List<PluginMenuTranslationModel>
                                {
                                    new()
                                    {
                                        LocaleName = LocaleNames.English,
                                        Name = "Statistics",
                                        Language = LanguageNames.English
                                    },
                                    new()
                                    {
                                        LocaleName = LocaleNames.German,
                                        Name = "Statistik",
                                        Language = LanguageNames.German
                                    },
                                    new()
                                    {
                                        LocaleName = LocaleNames.Danish,
                                        Name = "Statistik",
                                        Language = LanguageNames.Danish
                                    },
                                    new()
                                    {
                                        LocaleName = LocaleNames.Ukrainian,
                                        Name = "Статистика",
                                        Language = LanguageNames.Ukrainian
                                    }
                                }
                            },
                            Translations = new List<PluginMenuTranslationModel>
                            {
                                new()
                                {
                                    LocaleName = LocaleNames.English,
                                    Name = "Statistics",
                                    Language = LanguageNames.English
                                },
                                new()
                                {
                                    LocaleName = LocaleNames.German,
                                    Name = "Statistik",
                                    Language = LanguageNames.German
                                },
                                new()
                                {
                                    LocaleName = LocaleNames.Danish,
                                    Name = "Statistik",
                                    Language = LanguageNames.Danish
                                },
                                new()
                                {
                                    LocaleName = LocaleNames.Ukrainian,
                                    Name = "Статистика",
                                    Language = LanguageNames.Ukrainian
                                }
                            }
                        }
                    }
                }
            };

            return pluginMenu;
        }

        public MenuModel HeaderMenu(IServiceProvider serviceProvider)
        {
            var localizationService = serviceProvider
                .GetService<IBackendConfigurationLocalizationService>();

            var result = new MenuModel();
            result.LeftMenu.Add(new MenuItemModel
            {
                Name = localizationService?.GetString("BackendConfiguration"),
                E2EId = "backend-configuration-pn",
                Link = "",
                Guards = new List<string> { BackendConfigurationClaims.AccessBackendConfigurationPlugin },
                MenuItems = new List<MenuItemModel>
                {
                    new()
                    {
                        Name = localizationService?.GetString("Properties"),
                        E2EId = "backend-configuration-properties",
                        Link = "/plugins/backend-configuration/properties",
                        Guards = new List<string>(),
                        Position = 0
                    },
                    new()
                    {
                        Name = localizationService?.GetString("Property workers"),
                        E2EId = "backend-configuration-workers",
                        Link = "/plugins/backend-configuration/workers",
                        Guards = new List<string>(),
                        Position = 1
                    },
                    new()
                    {
                        Name = localizationService?.GetString("Task management"),
                        E2EId = "backend-configuration-task-management",
                        Link = "/plugins/backend-configuration/task-management",
                        Guards = new List<string>(),
                        Position = 2
                    },
                    new()
                    {
                        Name = localizationService?.GetString("Documents"),
                        E2EId = "backend-configuration-documents",
                        Link = "/plugins/backend-configuration/documents",
                        Guards = new List<string>(),
                        Position = 3
                    },
                    new()
                    {
	                    Name = localizationService?.GetString("Files"),
	                    E2EId = "backend-configuration-files",
	                    Link = "/plugins/backend-configuration/files",
	                    Guards = new List<string>(),
	                    Position = 4
                    },
                    new()
                    {
	                    Name = localizationService?.GetString("Task tracker"),
	                    E2EId = "backend-configuration-task-tracker",
	                    Link = "/plugins/backend-configuration/task-tracker",
	                    Guards = new List<string>(),
	                    Position = 5
                    },
                    new()
                    {
                        Name = localizationService?.GetString("Task wizard"),
                        E2EId = "backend-configuration-task-wizard",
                        Link = "/plugins/backend-configuration/task-wizard",
                        Guards = new List<string>(),
                        Position = 6
                    },
                    new()
                    {
                        Name = localizationService?.GetString("Statistics"),
                        E2EId = "backend-configuration-statistics",
                        Link = "/plugins/backend-configuration/statistics",
                        Guards = new List<string>(),
                        Position = 7
                    }
                }
            });
            return result;
        }

        public void SeedDatabase(string connectionString)
        {
            // Get DbContext
            var contextFactory = new BackendConfigurationPnContextFactory();
            using var context = contextFactory.CreateDbContext(new[] { connectionString });
            // Seed configuration
            BackendConfigurationPluginSeed.SeedData(context);
        }

        public PluginPermissionsManager GetPermissionsManager(string connectionString)
        {
            var contextFactory = new BackendConfigurationPnContextFactory();
            var context = contextFactory.CreateDbContext(new[] { connectionString });
			return new PluginPermissionsManager(context);
		}
	}
}