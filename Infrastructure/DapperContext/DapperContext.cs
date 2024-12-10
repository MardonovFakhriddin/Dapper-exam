using Npgsql;

namespace Infrastructure.DapperContext;

public class DapperContext
{
    private readonly string connectionString = "Server = localhost;Port = 5432;Database = School_db;Username = postgres;Password = LMard1909";

    public NpgsqlConnection Connection
    {
        get
        {
            return new NpgsqlConnection(connectionString); 
            
        }
    }
}