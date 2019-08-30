using System.Collections.Generic;
using System.Data;
using Microsoft.Data.Sqlite;
using Dapper;

namespace FoodToGo.Adapter.Tests.Database
{
    public class BaseRepository:FakeDatabaseConnectionFactory
    {
        public BaseRepository()
        {
            CreateClientsTable();   
        }

        private void CreateClientsTable()
        {
            IDbConnection connection = GetConnection();

            var sql = @"CREATE TABLE Clients(
                            Id int NOT NULL,
                            Name varchar(50) NOT NULL,
                            CONSTRAINT PK_Clients PRIMARY KEY (Id)
                        )
                        ";

            connection.Execute(sql);
            
        }
    }
}