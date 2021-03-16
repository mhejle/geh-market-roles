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

using Energinet.DataHub.MarketData.Domain.Customers;
using FluentAssertions;
using Xunit;

namespace Energinet.DataHub.MarketData.Tests.Domain.CvrNumbers
{
    [Trait("Category", "Unit")]
    public class CvrNumberTests
    {
        [Theory]
        [InlineData("10000000", false)]
        [InlineData("50000000", false)]
        [InlineData("99999999", false)]
        [InlineData("abcdefgh", true)]
        [InlineData("4567895", true)]
        [InlineData("842546194", true)]
        public void Validate_Cvr_Number(string cvrNumber, bool expectedIsBroken)
        {
            var actualIsBroken = CvrNumber.CheckRules(cvrNumber).AreAnyBroken;

            actualIsBroken.Should().Be(expectedIsBroken);
        }
    }
}