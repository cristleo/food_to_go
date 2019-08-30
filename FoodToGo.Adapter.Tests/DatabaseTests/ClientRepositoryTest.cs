using System.Collections.Generic;
using System.Data;
using Microsoft.Data.Sqlite;
using Dapper;
using Xunit;
using FoodToGo.Domain.Entities;

namespace FoodToGo.Adapter.Tests.Database
{
    public class ClientRepositoryTest: BaseRepository
    {
        private IDbConnection connection;
        public ClientRepositoryTest()
        {
            var sql = @"INSERT INTO CLIENTS (ID, NAME) VALUES(1, 'CRISTLEO CARVALHO');";
            connection = GetConnection();
            connection.Execute(sql);

        }


        [Fact]
        public void ShouldBeTrud()
        {
            var sql = @"SELECT * FROM CLIENTS";
            var result = connection.Query<Client>(sql);

            Assert.NotEmpty(result);



        }
    }
}