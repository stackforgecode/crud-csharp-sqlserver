using System;
using System.Data.SqlClient;


namespace SingletonCRUD
{
    class Program
    {
        static void Main(string[] args)
        {
            DbOperates dbOperates = new DbOperates();

            Console.WriteLine("Inserindo dados...");
            dbOperates.Insert("Antônio", 65);
            dbOperates.Insert("Bastiana", 60);

            Console.WriteLine("\nExibindo todos os registros...");
            SqlDataReader reader = dbOperates.SelectAll();
            while (reader.Read())
            {
                Console.WriteLine($"Nome: {reader["Nome"]}, Idade: {reader["Idade"]}");
            }
            reader.Close();

            // Console.WriteLine("\nAtualizando dados...");
            // dbOperates.Update(1, "João", 75);

            // Console.WriteLine("\nExibindo registro com ID 1...");
            // reader = dbOperates.SelectById(1);
            // if (reader.Read())
            // {
            //     Console.WriteLine($"Nome: {reader["Nome"]}, Idade: {reader["Idade"]}");
            // }
            // reader.Close();

            // Console.WriteLine("\nExcluindo registro com ID 2...");
            // dbOperates.Delete(2);

            Console.WriteLine("\nExibindo todos os registros...");
            reader = dbOperates.SelectAll();
            while (reader.Read())
            {
                Console.WriteLine($"Nome: {reader["Nome"]}, Idade: {reader["Idade"]}");
            }
            reader.Close();

            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
