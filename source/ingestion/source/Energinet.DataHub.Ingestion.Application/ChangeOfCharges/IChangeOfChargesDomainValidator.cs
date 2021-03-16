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

using System.Threading.Tasks;
using Energinet.DataHub.Ingestion.Domain.ChangeOfCharges;
using GreenEnergyHub.Queues.ValidationReportDispatcher.Validation;

namespace Energinet.DataHub.Ingestion.Application.ChangeOfCharges
{
    /// <summary>
    /// Validator for validating change of charges business rules.
    /// </summary>
    public interface IChangeOfChargesDomainValidator
    {
        /// <summary>
        /// Validates business rules
        /// </summary>
        /// <param name="changeOfChargesMessage"></param>
        /// <returns>Validation result with errors if any</returns>
        Task<HubRequestValidationResult> ValidateAsync(ChangeOfChargesMessage changeOfChargesMessage);
    }
}