using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Data.SqlClient;

namespace PetsPortalApp.Context
{
    public class PetContext : DbContext
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;

        public PetContext(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("SqlConnection");
        }

        public IDbConnection CreateConnection()
            => new SqlConnection(_connectionString);
    }
}
