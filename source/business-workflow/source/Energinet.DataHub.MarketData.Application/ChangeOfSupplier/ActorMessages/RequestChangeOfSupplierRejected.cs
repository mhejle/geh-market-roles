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

namespace Energinet.DataHub.MarketData.Application.ChangeOfSupplier.ActorMessages
{
    public class RequestChangeOfSupplierRejected
    {
        //TODO: Temporarly pragma. Stylecop complains about unused empty ctor. Will use another serialization method when physical database is implemented
#pragma warning disable 8618
        public RequestChangeOfSupplierRejected()
#pragma warning restore 8618
        {
        }

        public RequestChangeOfSupplierRejected(string messageId, string transactionId, string meteringPointId, IReadOnlyList<string> reasonCodes)
        {
            MessageId = messageId;
            TransactionId = transactionId;
            MeteringPointId = meteringPointId;
            ReasonCodes = reasonCodes;
        }

        public string MessageId { get; set; }

        public string TransactionId { get; set; }

        public string MeteringPointId { get; set; }

        public IReadOnlyList<string> ReasonCodes { get; set; }
    }
}
