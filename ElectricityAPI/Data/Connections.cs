using Microsoft.Data.SqlClient;
using System.Data;

namespace ElectricityAPI.Data
{
    public class Connections
    {
        public readonly IConfiguration _config;

        public Connections(IConfiguration config)
        {
            _config = config;
        }

        public IDbConnection LocalConnection => new SqlConnection(_config.GetConnectionString("localDB"));

    }
}
