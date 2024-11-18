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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace WinFormsApp1
{
    public partial class Support : Form
    {
        public Support()
        {
            InitializeComponent();
            panelLeft.Height = button1.Height;
            panelLeft.Top = button1.Top;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelLeft.Height = button1.Height;
            panelLeft.Top = button1.Top;

            this.Hide();        //go to home page
            var form4 = new Home();
            form4.Closed += (s, args) => this.Close();
            form4.Show();
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

        private void save_button1_Click(object sender, EventArgs e)     //when feedback is saved
        {
            var connectionString = "Data Source=LAPTOP-S1HUQ0ID\\SQLEXPRESS;Database = CampusBites; Integrated Security=True";
            SqlConnection sqlconn22 = new SqlConnection(connectionString);
            sqlconn22.Open();

            try
            {
                //get customerID 
                string query11 = "Select TOP 1 customerID from currentcustomer order by id DESC";
                SqlCommand cmd11 = new SqlCommand(query11, sqlconn22);
                SqlDataReader reader11 = cmd11.ExecuteReader();

                if (reader11.Read())
                {
                    string customerID = reader11["customerID"].ToString();
                    reader11.Close();

                    //get adminID
                    string query1 = "Select adminID from administrator";
                    SqlCommand cmd1 = new SqlCommand(query1, sqlconn22);
                    SqlDataReader reader1 = cmd1.ExecuteReader();

                    if (reader1.Read())
                    {
                        string adminID = reader1["adminID"].ToString();
                        reader1.Close();

                        string feedback = feedback_richTextBox1.Text;

                        SqlCommand sqlcomm = new SqlCommand("insert into Feedback " +
                        "values('" + feedback + "', '" + customerID + "' )", sqlconn22);

                        var ifError = sqlcomm.ExecuteNonQuery();
                        if (ifError == 0)
                        {
                            MessageBox.Show("Error");
                        }
                        else
                        {
                            MessageBox.Show("Thank you for giving your feedback!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("error in finding admin");
                    }

                }
                else
                {
                    MessageBox.Show("error in finding current customer");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlconn22.Close();
            }
        }
    }
}
