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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            panelLeft.Height = button2.Height;
            panelLeft.Top = button2.Top;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelLeft.Height = button2.Height;
            panelLeft.Top = button2.Top;
            panelLeft.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelLeft.Height = button1.Height;
            panelLeft.Top = button1.Top;

            this.Hide();        //go to home form
            var form3 = new Home();
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }

        private void button3_Click(object sender, EventArgs e)      //Support
        {
            panelLeft.Height = button3.Height;
            panelLeft.Top = button3.Top;

            this.Hide();        //go to support form
            var form3 = new Support();
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panelLeft.Height = button4.Height;
            panelLeft.Top = button4.Top;

            this.Hide();        //go to profile form
            var form3 = new Profile();
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();        //go to beverage form
            var form5 = new Beverage();
            form5.Closed += (s, args) => this.Close();
            form5.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();        //go to meal form
            var form6 = new Meal();
            form6.Closed += (s, args) => this.Close();
            form6.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();        //go to breakfast form
            var form7 = new Breakfast();
            form7.Closed += (s, args) => this.Close();
            form7.Show();
        }

        private void button8_Click(object sender, EventArgs e)  //snacks button
        {
            this.Hide();        //go to Snacks form
            var form7 = new Snacks();
            form7.Closed += (s, args) => this.Close();
            form7.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();        //go to Dessert form
            var form7 = new Dessert();
            form7.Closed += (s, args) => this.Close();
            form7.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();        //go to cafe form
            var form7 = new Cafe();
            form7.Closed += (s, args) => this.Close();
            form7.Show();
        }
    }
}
