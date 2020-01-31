using Department.Dapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Department.Dapper
{
    public class ConnectionDB : IConnectionDB
    {
        private readonly ILogger<ConnectionDB> _logger;
        private readonly IConfiguration _configuration;

        public ConnectionDB(ILogger<ConnectionDB> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }
        public IDbConnection ConexionABase()
        {
            try
            {
                IDbConnection db = new SqlConnection("Data Source=CPX-ZH9T5H84KER;Initial Catalog=contoso;Integrated Security=True");
                return db;
            }
            catch (Exception ex)
            {
                _logger.LogError($"ConexionBaseDeDatos(), ex:{ex.ToString()}");
                return null;
            }
        }
    }
}
