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
using System.Data;
using System.Data.SqlClient;
using Energinet.DataHub.MarketData.Application.Common;

namespace Energinet.DataHub.MarketData.Infrastructure.DataPersistence
{
    public class SqlDbConnectionFactory : IDbConnectionFactory, IDisposable
    {
        private readonly string _connectionString;
        private IDbConnection? _connection;
        private bool _disposed;

        public SqlDbConnectionFactory(string connectionString)
        {
            _connectionString = connectionString ?? throw new ArgumentNullException(nameof(connectionString));
        }

        public IDbConnection GetOpenConnection()
        {
            if (_connection == null)
            {
                _connection = new SqlConnection(_connectionString);
                _connection.Open();
            }

            if (_connection.State == ConnectionState.Broken)
            {
                _connection.Close();
                _connection.Open();
            }

            return _connection;
        }

        public void ResetConnection()
        {
            if (_connection != null && _connection.State != ConnectionState.Closed)
            {
                _connection.Close();
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
            {
                return;
            }

            if (disposing)
            {
                _connection?.Dispose();
            }

            _disposed = true;
        }
    }
}
