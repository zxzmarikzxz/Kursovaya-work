using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Library2;

namespace Kursovaya_work
{
    public partial class authorization : Form
    {
        public authorization()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
           
        }
        public void Proverka(string loginpassword)
        {
            switch(loginpassword)
            {
                case "fast_mobile_artem 1111":
                menu_employee fr = new menu_employee();
                fr.ShowDialog();
                break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Proverka($"{textBox1.Text} {textBox2.Text}");
        }

        private void authorization_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
  
    }
}
