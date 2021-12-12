using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovaya_work
{
    public partial class menu_director : Form
    {
        public menu_director()
        {
            InitializeComponent();
        }

        private void menu_director_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            change_service cs = new change_service();
            this.Hide();
            cs.ShowDialog();
        }

        private void menu_director_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
