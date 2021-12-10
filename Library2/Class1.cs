using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Library2
{
    public class ConnBaza
    {
        public MySqlConnection ConnBaz()
        {
            //Создание строки подключения
            string port = "33333";
            string host = "caseum.ru";
            string user = "st_3_6_19";
            string password = "18734518";
            string db = "st_3_6_19";
            string connStr = $"server={host};port={port};user={user};database={db};password={password};";
            MySqlConnection conn = new MySqlConnection(connStr);
            return conn; //Возврат строки подключения
        }
    }
}
