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
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
            panelLeft.Height = button1.Height;
            panelLeft.Top = button1.Top;
            panelLeft.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelLeft.Height = button1.Height;
            panelLeft.Top = button1.Top;
            panelLeft.BringToFront();

            this.Hide();        //go to home form
            var form3 = new Home();
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelLeft.Height = button2.Height;
            panelLeft.Top = button2.Top;
            panelLeft.BringToFront();

            this.Hide();        //go to menu form
            var form3 = new Menu();
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelLeft.Height = button3.Height;
            panelLeft.Top = button3.Top;
            panelLeft.BringToFront();

            this.Hide();        //go to support form
            var form3 = new Support();
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            var connectionString = "Data Source=LAPTOP-S1HUQ0ID\\SQLEXPRESS;Database = CampusBites; Integrated Security=True";
            SqlConnection sqlconn = new SqlConnection(connectionString);
            sqlconn.Open();

            try
            {
                var fname = fnametextBox.Text;  
                var lname = lnametextBox.Text;
                var email = emailtextBox.Text;
                var phonenum = phonenumtextBox.Text;
                var password = passwordtextBox.Text;

                string query11 = "Select TOP 1 customerID from currentcustomer order by id DESC";
                SqlCommand cmd11 = new SqlCommand(query11, sqlconn);
                SqlDataReader reader11 = cmd11.ExecuteReader();

                if (reader11.Read())
                {
                    string customerID = reader11["customerID"].ToString();
                    reader11.Close();

                    if (fname == "")
                    {
                        string query = "Select first_name from users where userID = '"+customerID+"'";
                        SqlCommand cmd = new SqlCommand(query, sqlconn);
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            string first_name = reader["first_name"].ToString();
                            reader.Close();

                            fname = first_name;

                        }
                    }
                    if(lname == "")
                    {
                        string query = "Select last_name from users where userID = '" + customerID + "'";
                        SqlCommand cmd = new SqlCommand(query, sqlconn);
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            string last_name = reader["last_name"].ToString();
                            reader.Close();

                            lname = last_name;
                        }
                    }
                    if(email == "")
                    {
                        string query = "Select email from users where userID = '" + customerID + "'";
                        SqlCommand cmd = new SqlCommand(query, sqlconn);
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            string eemail = reader["email"].ToString();
                            reader.Close();

                            email = eemail;
                        }
                    }
                    if(password == "")
                    {
                        string query = "Select password from users where userID = '" + customerID + "'";
                        SqlCommand cmd = new SqlCommand(query, sqlconn);
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            string pass = reader["password"].ToString();
                            reader.Close();

                            password = pass;
                        }
                    }
                    if(phonenum == "")
                    {
                        string query = "Select phonenumber from users where userID = '" + customerID + "'";
                        SqlCommand cmd = new SqlCommand(query, sqlconn);
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            string phonenumber = reader["phonenumber"].ToString();
                            reader.Close();

                            phonenum = phonenumber;
                        }
                    }

                    string query3 = "Update users set first_name = '" + fname + "', last_name = '" + lname + "'," +
                        "email = '" + email + "', password = '" + password + "', phonenumber = '" + phonenum + "' where userID = '" + customerID + "' ";
                    SqlCommand cmd322 = new SqlCommand(query3, sqlconn);
                    var ifError = cmd322.ExecuteNonQuery();
                    if(ifError == 0)
                    {
                        MessageBox.Show("Error in updation");
                    }
                    else
                    {
                        MessageBox.Show("Updated successfully!");

                        this.Hide();        
                        var form9 = new Profile();
                        form9.Closed += (s, args) => this.Close();
                        form9.Show();
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
    }
}
