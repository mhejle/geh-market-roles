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

using System;
using Energinet.DataHub.Ingestion.Domain.Common;

namespace Energinet.DataHub.Ingestion.Infrastructure.ChangeOfCharges.Mapping
{
    public static class MarketParticipantRoleMapper
    {
        private const string EnergySupplierDatabaseValue = "DDQ";

        public static string ToDatabaseValue(this MarketParticipantRole role)
        {
            return role switch
            {
                MarketParticipantRole.EnergySupplier => EnergySupplierDatabaseValue,
                _ => throw new NotImplementedException(role.ToString()),
            };
        }

        public static MarketParticipantRole FromDatabaseValue(string role)
        {
            return role switch
            {
                EnergySupplierDatabaseValue => MarketParticipantRole.EnergySupplier,
                _ => throw new NotImplementedException(role),
            };
        }
    }
}
