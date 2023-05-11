using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace SingletonCRUD;

// Interface para o repositório de operações no banco de dados. Este é o contrato que a classe OperatesRepository deve seguir.
public interface IOperatesRepository : IDbConnection
{  
    void Insert(string nome, int idade);
    void Update(int id, string nome, int idade);
    void Delete(int id);
    SqlDataReader SelectAll();
    SqlDataReader SelectById(int id);
    SqlConnection GetConnection();

}
