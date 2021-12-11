using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Добавление MySql
using MySql.Data.MySqlClient;
//Добавление библиотеки классов
using Library2;

namespace Kursovaya_work
{
    public partial class authorization : Form
    {
        MySqlConnection conbaza = ConnBaza.ConnBaz();
        private BindingSource bSource = new BindingSource(); //Унифицированный доступ к источнику данных          
        private DataTable table = new DataTable();
        private MySqlDataAdapter adapter = new MySqlDataAdapter(); //Получение данных из источника  
        public int Podkluchenie(string login,string password)
        {
            int a = 0;
            //Открытие соединения
            try
            {
                conbaza.Open();
                string commandStr = $"SELECT count(*) FROM Staff WHERE login = '{login}' AND password = {password}";
                MySqlCommand comm1 = new MySqlCommand(commandStr,conbaza);                        
                int k = Convert.ToInt32(comm1.ExecuteScalar());
                if (k != 0)
                {
                    string commandStr2 = $"SELECT access FROM Staff WHERE login = '{login}' AND password = {password}";
                    MySqlCommand comm2 = new MySqlCommand(commandStr2, conbaza);
                    a = Convert.ToInt32(comm2.ExecuteScalar());
                }             
            }
            //Обработка исключений
            catch 
            {
                
            }
            //Закрытие соединения
            conbaza.Close();
            return a;
        }
        public authorization()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
           
        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            if (Podkluchenie(textBox1.Text,textBox2.Text) == 1)
            {
                menu_employee me = new menu_employee();
                me.ShowDialog();
            }
            else if(Podkluchenie(textBox1.Text,textBox2.Text) == 2)
            {
                menu_director me2 = new menu_director();
                me2.ShowDialog();

                
            }
            else
            {
                MessageBox.Show("Введите правильные данные");
            }
        }

        private void authorization_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
  
    }
}
