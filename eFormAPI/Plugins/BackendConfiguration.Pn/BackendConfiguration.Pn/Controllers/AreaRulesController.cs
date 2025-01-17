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

namespace BackendConfiguration.Pn.Controllers
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Infrastructure.Models.AreaRules;
    using Microsoft.AspNetCore.Mvc;
    using Microting.eFormApi.BasePn.Infrastructure.Models.API;
    using Services.BackendConfigurationAreaRules;

    [Route("api/backend-configuration-pn/area-rules")]
    public class AreaRulesController : Controller
    {
        private readonly IBackendConfigurationAreaRulesService _backendConfigurationAreaRulesService;

        public AreaRulesController(IBackendConfigurationAreaRulesService backendConfigurationAreaRulesService)
        {
            _backendConfigurationAreaRulesService = backendConfigurationAreaRulesService;
        }

        [HttpGet]
        [Route("index")]
        public async Task<OperationDataResult<List<AreaRuleSimpleModel>>> Index(int propertyAreaId)
        {
            return await _backendConfigurationAreaRulesService.Index(propertyAreaId);
        }

        [HttpGet]
        public async Task<OperationDataResult<AreaRuleModel>> Read(int ruleId, int propertyId)
        {
            return await _backendConfigurationAreaRulesService.Read(ruleId);
        }

        [HttpPut]
        public async Task<OperationResult> Update([FromBody] AreaRuleUpdateModel updateModel)
        {
            return await _backendConfigurationAreaRulesService.Update(updateModel);
        }

        [HttpDelete]
        public async Task<OperationResult> Delete(int areaId)
        {
            return await _backendConfigurationAreaRulesService.Delete(areaId);
        }

        [HttpPost]
        public async Task<OperationResult> Create([FromBody] AreaRulesCreateModel createModel)
        {
            return await _backendConfigurationAreaRulesService.Create(createModel);
        }

        [HttpPut]
        [Route("planning")]
        public async Task<OperationResult> UpdatePlanning([FromBody] AreaRulePlanningModel areaRulePlanningModel)
        {
            return await _backendConfigurationAreaRulesService.UpdatePlanning(areaRulePlanningModel);
        }


        [HttpGet]
        [Route("planning")]
        public async Task<OperationDataResult<AreaRulePlanningModel>> GetPlanning(int ruleId)
        {
            return await _backendConfigurationAreaRulesService.GetPlanning(ruleId);
        }
    }
}