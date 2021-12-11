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
    public partial class menu_employee : Form
    {
        public menu_employee()
        {
            InitializeComponent();
        }

        private void menu_employee_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            prosmotr_uslug pr = new prosmotr_uslug();
            pr.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            service pr2 = new service();
            pr2.ShowDialog();
        }
    }
}
