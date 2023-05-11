using System;
using System.Configuration;
using System.Data.SqlClient;

namespace SingletonCRUD;

public class DbConnection : IDbConnection
{
    private static DbConnection instance;
    private readonly SqlConnection connection;

    private DbConnection()
    {
        string connectionString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
        connection = new SqlConnection(connectionString);
        connection.Open();
    }

    public static DbConnection Instance
    {
        get => instance ?? (instance = new DbConnection());
    }

    public SqlConnection GetConnection()
    {
        return connection;
    }

    public void Dispose()
    {
        connection.Close();
    }

}

