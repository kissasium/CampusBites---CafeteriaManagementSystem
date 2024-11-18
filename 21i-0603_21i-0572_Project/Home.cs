using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            panelLeft.Height = button1.Height;
            panelLeft.Top = button1.Top;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelLeft.Height = button1.Height;
            panelLeft.Top = button1.Top;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelLeft.Height = button2.Height;
            panelLeft.Top = button2.Top;
            panelLeft.BringToFront();

            this.Hide();        //go to menu page
            var form4 = new Menu();
            form4.Closed += (s, args) => this.Close();
            form4.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelLeft.Top = button3.Top;
            panelLeft.Height = button3.Height;
            panelLeft.BringToFront();

            this.Hide();        //go to support form
            var form3 = new Support();
            form3.Closed += (s, args) => this.Close();
            form3.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            panelLeft.Height = button4.Height;
            panelLeft.Top = button4.Top;
            panelLeft.BringToFront();

            this.Hide();         
            var form9 = new Profile();
            form9.Closed += (s, args) => this.Close();
            form9.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();        //go to menu page
            var form4 = new Menu();
            form4.Closed += (s, args) => this.Close();
            form4.Show();
        }
    }
}
