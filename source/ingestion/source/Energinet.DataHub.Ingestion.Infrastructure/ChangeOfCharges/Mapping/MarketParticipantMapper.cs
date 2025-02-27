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

using Energinet.DataHub.Ingestion.Domain.Common;

namespace Energinet.DataHub.Ingestion.Infrastructure.ChangeOfCharges.Mapping
{
    public class MarketParticipantMapper : IMarketParticipantMapper
    {
        public MarketParticipant ToDomainObject(Context.Model.MarketParticipant persistenceModel)
        {
            return new MarketParticipant
            {
                Id = persistenceModel.Id,
                MRid = persistenceModel.MRid,
                Name = persistenceModel.Name,
                Role = MarketParticipantRoleMapper.FromDatabaseValue(persistenceModel.Role!),
            };
        }
    }
}
