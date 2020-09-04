using Microsoft.Extensions.Logging;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace ReactApp.Services
{
    public class DatabaseService : IDisposable
    {
        private MySqlConnection Connection { get; set; }
        private readonly ILogger<DatabaseService> _logger;

        public DatabaseService(ILogger<DatabaseService> logger, string connectionString)
        {
            _logger = logger;
            Connection = new MySqlConnection(connectionString);
            Connection.Open();
        }

        public MySqlCommand CreateCommand() => Connection.CreateCommand() as MySqlCommand;

        public async void Dispose()
        {
            await Connection.CloseAsync();
        }
    }
}
