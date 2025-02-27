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

using System.IO;
using System.Threading.Tasks;

namespace Energinet.DataHub.SoapAdapter.Application.Infrastructure
{
    /// <summary>
    /// Common interface for serializers
    /// </summary>
    public interface IResponseSerializer
    {
        /// <summary>
        /// Serialize a response
        /// </summary>
        /// <param name="response">A response</param>
        /// <typeparam name="TResponse">Type of the response</typeparam>
        /// <returns>The response as a <see cref="string"/></returns>
        Task<Stream> SerializeAsync<TResponse>(TResponse response);
    }
}
