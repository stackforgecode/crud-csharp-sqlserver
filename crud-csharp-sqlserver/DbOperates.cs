using System.Data.SqlClient;

namespace SingletonCRUD
{
    public class DbOperates
    {
        private readonly SqlConnection connection;

        public DbOperates()
        {
            connection = DbConnection.Instance.GetConnection();
        }

        public void Insert(string nome, int idade)
        {
            string query = "INSERT INTO Tbl_Teste (Nome, Idade) VALUES (@Nome, @Idade)";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Nome", nome);
                command.Parameters.AddWithValue("@Idade", idade);
                command.ExecuteNonQuery();
            }
        }

        public void Update(int id, string nome, int idade)
        {
            string query = "UPDATE Tbl_Teste SET Nome = @Nome, Idade = @Idade WHERE Id = @Id";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Nome", nome);
                command.Parameters.AddWithValue("@Idade", idade);
                command.Parameters.AddWithValue("@Id", id);
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            string query = "DELETE FROM Tbl_Teste WHERE Id = @Id";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Id", id);
                command.ExecuteNonQuery();
            }
        }

        public SqlDataReader SelectAll()
        {
            string query = @"SELECT * FROM Tbl_Teste";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                return command.ExecuteReader();
            }
        }

        public SqlDataReader SelectById(int id)
        {
            string query = @"SELECT * FROM Tbl_Teste WHERE Id = @Id";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Id", id);
                return command.ExecuteReader();
            }
        }
    }
}
