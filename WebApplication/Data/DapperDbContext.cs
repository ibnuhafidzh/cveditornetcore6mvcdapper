using Dapper;
using Microsoft.Extensions.Options;
using Npgsql;
using System;
using System.Data;

namespace WebApplication.Data
{
    public class DapperDbContext
    {
        private DbSettings _dbSettings;

        public DapperDbContext(IOptions<DbSettings> dbSettings)
        {
            _dbSettings = dbSettings.Value;
        }
        public IDbConnection CreateConnection()
        {
            var connectionString = $"Host={_dbSettings.Server}; Port={_dbSettings.Port}; Database={_dbSettings.Database}; Username={_dbSettings.UserId}; Password={_dbSettings.Password};";
            return new NpgsqlConnection(connectionString);
        }
    }
}
