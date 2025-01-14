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

namespace Energinet.DataHub.MarketData.Domain.MeteringPoints
{
    public class MeteringPointSnapshot
    {
        public MeteringPointSnapshot(int id, string gsrnNumber, int meteringPointType, List<RelationshipSnapshot> relationships, bool isProductionObligated, int physicalState, int version)
        {
            Id = id;
            GsrnNumber = gsrnNumber;
            MeteringPointType = meteringPointType;
            Relationships = relationships;
            IsProductionObligated = isProductionObligated;
            PhysicalState = physicalState;
            Version = version;
        }

        public int Id { get; set; }

        public string GsrnNumber { get; set; }

        public int MeteringPointType { get; set; }

        public List<RelationshipSnapshot> Relationships { get; }

        public bool IsProductionObligated { get; set; }

        public int PhysicalState { get; set; }

        public int Version { get; set; }
    }
}
