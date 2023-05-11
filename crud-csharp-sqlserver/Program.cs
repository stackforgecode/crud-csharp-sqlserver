using System.Security.Cryptography.X509Certificates;
using System;
using System.Data.SqlClient;

namespace SingletonCRUD
{
    class Program
    {
        static void Main(string[] args)
        {

            OperatesRepository repository = new OperatesRepository();

            Console.WriteLine("Inserindo dados...");
            repository.Insert("Marcelo Augusto", 45);
            repository.Insert("Angela Marques", 32);

            Console.WriteLine("\nExibindo todos os registros...");
            SqlDataReader reader = repository.SelectAll();
            while (reader.Read())
            {
                Console.WriteLine($"Nome: {reader["Nome"]}, Idade: {reader["Idade"]}");
            }
            reader.Close();

            Console.WriteLine("\nAtualizando dados...");
            repository.Update(1, "José", 28);

            Console.WriteLine("\nExibindo registro com ID 1...");
            reader = repository.SelectById(1);
            if (reader.Read())
            {
                Console.WriteLine($"Nome: {reader["Nome"]}, Idade: {reader["Idade"]}");
            }
            reader.Close();

            Console.WriteLine("\nExcluindo registro com ID 2...");
            repository.Delete(1005);

            Console.WriteLine("\nExibindo todos os registros...");
            reader = repository.SelectAll();
            while (reader.Read())
            {
                Console.WriteLine($"Nome: {reader["Nome"]}, Idade: {reader["Idade"]}");
            }
            reader.Close();

            Console.ReadKey();
        }
    }
}
