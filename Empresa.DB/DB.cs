using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.DB
{
    public static class DB
    {
        public static string Connection
        {
            get 
            {
                return @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=EmpresaDB;Integrated Security=True;Pooling=False"; 
            }
        }
    }
}
