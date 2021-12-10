using System;
using MySql.Data.MySqlClient;

namespace Library
{
    public class ConnBaza
    {
        public MySqlConnection ConnBaz()
        {
            //Создание строки подключения
            string port = "33333";
            string host = "caseum.ru";
            string user = "test_user";
            string password = "test_pass";
            string db = "db_test";
            string connStr = $"server={host};port={port};user={user};database={db};password={password};";
            MySqlConnection conn = new MySqlConnection(connStr);
            return conn; //Возврат строки подключения
        }

    }
}
