using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace SingletonCRUD; 

public interface IDbConnection : IDisposable
{
    SqlConnection GetConnection();          
    public void Dispose();     
    
}
