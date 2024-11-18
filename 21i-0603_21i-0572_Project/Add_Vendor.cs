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
    public partial class Add_Vendor : Form
    {
        public Add_Vendor()
        {
            InitializeComponent();
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            var fname = fname_textBox2.Text;
            var lname = lname_textBox1.Text;
            var email = email_textBox1.Text;
            var phonenum = phonenum_textBox2.Text;

            var connectionString = "Data Source=LAPTOP-S1HUQ0ID\\SQLEXPRESS;Database=CampusBites;Integrated Security=True";

            SqlConnection sqlconn = new SqlConnection(connectionString);
            sqlconn.Open();

            try
            {
                //check if vendor already exists
                string squery = "Select email from vendor where email = '" + email + "' ";
                SqlCommand scmd = new SqlCommand(squery, sqlconn);
                SqlDataReader sreader = scmd.ExecuteReader();

                if (sreader.Read())
                {
                    sreader.Close();
                    MessageBox.Show("Vendor already exists");
                }
                else   //vendor does not already exist
                {
                    sreader.Close();

                    SqlCommand sqlcomm = new SqlCommand("insert into vendor " +
                        "values('" + fname + "', '" + lname + "', '" + email + "', '" + phonenum + "', '" + 1 + "' )", sqlconn);

                    var ifError = sqlcomm.ExecuteNonQuery();
                    if (ifError == 0)
                    {
                        MessageBox.Show("Error");
                    }
                    else
                    {
                        MessageBox.Show("New vendor added");
                        this.Hide();        //close form and open login form
                        var form4 = new Cafe_manager_inventory();
                        form4.Closed += (s, args) => this.Close();
                        form4.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlconn.Close();
            }
        }

        private void back_button2_Click(object sender, EventArgs e)
        {
            this.Hide();        //close form and open login form
            var form4 = new Login();
            form4.Closed += (s, args) => this.Close();
            form4.Show();
        }
    }
}
