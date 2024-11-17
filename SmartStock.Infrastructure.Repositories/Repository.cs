using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartStock.Infrastructure.Repositories
{
    public class Repository
    {

        protected MySqlConnection? mySqlConnection;
        protected MySqlTransaction? mySqlTransaction;

        protected MySqlCommand CreateCommand(string query) // Creamos un comand para consultas en un bd de MySQL
        {
            return new MySqlCommand(query, mySqlConnection, mySqlTransaction);
        }


    }
}
