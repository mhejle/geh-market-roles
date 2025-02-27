﻿// Copyright 2020 Energinet DataHub A/S
//
// Licensed under the Apache License, Version 2.0 (the "License2");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Energinet.DataHub.Ingestion.Application.ChangeOfCharges.Repositories;
using Energinet.DataHub.Ingestion.Application.ChangeOfCharges.ValidationRules;
using Energinet.DataHub.Ingestion.Infrastructure.ChangeOfCharges.Context;
using Energinet.DataHub.Ingestion.Infrastructure.ChangeOfCharges.Mapping;
using Microsoft.EntityFrameworkCore;

namespace Energinet.DataHub.Ingestion.Infrastructure.ChangeOfCharges.Repositories
{
    public class RuleConfigurationRepository : IRuleConfigurationRepository
    {
        private readonly IChargesDatabaseContext _chargesDatabaseContext;

        public RuleConfigurationRepository(IChargesDatabaseContext chargesDatabaseContext)
        {
            _chargesDatabaseContext = chargesDatabaseContext;
        }

        public async Task<IEnumerable<ValidationRuleConfiguration>> GetRuleConfigurationsAsync()
        {
            var rulesConfigurations = await _chargesDatabaseContext.ValidationRuleConfiguration.ToListAsync();
            return rulesConfigurations.Select(ConfigurationRuleMapper.MapConfigurationRuleToChargesValidationRuleConfiguration);
        }
    }
}
