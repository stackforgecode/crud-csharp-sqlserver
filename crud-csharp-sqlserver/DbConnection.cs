using System;
using System.Configuration;
using System.Data.SqlClient;

namespace SingletonCRUD
{
    public class DbConnection : IDisposable
    {
        private static DbConnection instance;
        private readonly SqlConnection connection;

        private DbConnection()
        {
            string connectionString = @"Data Source=localhost,1433;Initial Catalog=AppSingleton;User ID=sa;Password=Local@123456789;";
            connection = new SqlConnection(connectionString);    
            connection.Open();
        }

        // Padrão Singleton
        public static DbConnection Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DbConnection();
                }
                return instance;
            }            
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
}
