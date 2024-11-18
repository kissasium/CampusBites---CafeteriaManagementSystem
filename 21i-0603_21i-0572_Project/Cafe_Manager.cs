using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Cafe_Manager : Form
    {
        public Cafe_Manager()
        {
            InitializeComponent();
        }

        private void logout_button1_Click(object sender, EventArgs e)
        {
            this.Hide();        //close cafe manager form and open login form
            var form4 = new Login();
            form4.Closed += (s, args) => this.Close();
            form4.Show();
        }

        private void employee_button1_Click(object sender, EventArgs e)
        {
            this.Hide();        //close cafe manager form and open employee form
            var form4 = new Cafe_manager_employee();
            form4.Closed += (s, args) => this.Close();
            form4.Show();
        }

        private void menu_button1_Click(object sender, EventArgs e)
        {
            this.Hide();        //close cafe manager form and open menu form
            var form4 = new Cafe_manager_menu();
            form4.Closed += (s, args) => this.Close();
            form4.Show();
        }

        private void inventory_button2_Click(object sender, EventArgs e)
        {
            this.Hide();        //close cafe manager form and open inventory form
            var form4 = new Cafe_manager_inventory();
            form4.Closed += (s, args) => this.Close();
            form4.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();        //close cafe manager form and open inventory form
            var form4 = new report();
            form4.Closed += (s, args) => this.Close();
            form4.Show();
        }
    }
}
