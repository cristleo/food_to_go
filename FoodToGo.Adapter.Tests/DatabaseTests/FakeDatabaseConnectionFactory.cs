using System.Collections.Generic;
using System.Data;
using Microsoft.Data.Sqlite;
using Dapper;

namespace FoodToGo.Adapter.Tests.Database
{
    public class FakeDatabaseConnectionFactory
    {
        private string _connectionString = "Data Source=:memory:;";
        private IDbConnection _connection;

        public FakeDatabaseConnectionFactory()
        {
            _connection = new SqliteConnection(_connectionString);
            _connection.Open();
        }

        protected IDbConnection GetConnection()
        {
            return _connection;
        }




    }
}