using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Collections.Specialized;

namespace WinFormsApp1
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }
   
        private void signupbutton_Click(object sender, EventArgs e)
        {
            var fname = fnametextBox.Text;
            var lname = lnametextBox.Text;
            var email = emailtextBox.Text;
            var phonenum = phonenumtextBox.Text;
            var password = passwordtextBox.Text;
            var usertype = "customer";

            var connectionString = "Data Source=LAPTOP-S1HUQ0ID\\SQLEXPRESS;Database=CampusBites;Integrated Security=True";

            SqlConnection sqlconn = new SqlConnection(connectionString);
            sqlconn.Open();

            try
            {
                SqlCommand sqlcomm = new SqlCommand("insert into users " +
                        "values('" + fname + "', '" + lname + "', '" + email + "','" + password + "' , '" + phonenum + "', '" + usertype + "' )", sqlconn);

                var ifError = sqlcomm.ExecuteNonQuery();
                if (ifError == 0)
                {
                    MessageBox.Show("Error");
                }
                else
                {
                    //get adminID
                    string query1 = "Select adminID from administrator";
                    SqlCommand cmd1 = new SqlCommand(query1, sqlconn);
                    SqlDataReader reader1 = cmd1.ExecuteReader();

                    if (reader1.Read())
                    {
                        string adminID = reader1["adminID"].ToString();
                        reader1.Close();

                        string query = "Select userID from users where email = '" + email + "'";
                        SqlCommand cmd = new SqlCommand(query, sqlconn);

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            //get userID of customer
                            string userID = reader["userID"].ToString();
                            reader.Close();

                            SqlCommand sqlcomm1 = new SqlCommand("insert into customer " +
                                 "values('" + userID + "', '" + adminID + "')", sqlconn);

                            var ifError1 = sqlcomm1.ExecuteNonQuery();
                            if (ifError1 == 0)
                            {
                                MessageBox.Show("Error");
                            }
                            else
                            {
                                MessageBox.Show("Welcome to CampusBites!");
                                this.Hide();        //close login form and open register form
                                var form3 = new Home();
                                form3.Closed += (s, args) => this.Close();
                                form3.Show();
                            }

                            //create points row for customer
                            SqlCommand sqlcomm11 = new SqlCommand("insert into customerPoints " +
                            "values('" + 0 + "', '" + userID + "' )", sqlconn);

                            var ifError11 = sqlcomm11.ExecuteNonQuery();
                            if (ifError11 == 0)
                            {
                                MessageBox.Show("Error");
                            }
                            else
                            {
                                MessageBox.Show("Current points: 0");
                            }

                            //curent customer
                            SqlCommand sqlcomm1112 = new SqlCommand("insert into currentcustomer " +
                            "values('" + userID + "' )", sqlconn);

                            var ifError1112 = sqlcomm1112.ExecuteNonQuery();
                            if (ifError1112 == 0)
                            {
                                MessageBox.Show("Error in current customer");
                            }

                            //insert in pointsEARNEDprogram
                            //no membership when intially customer signs up
                            string q = "Select pointsID from customerPoints where customerID = '" + userID + "' ";
                            SqlCommand cmd111 = new SqlCommand(q, sqlconn);
                            SqlDataReader readerr = cmd111.ExecuteReader();

                            if (readerr.Read())
                            {
                                string pointsID = readerr["pointsID"].ToString();
                                readerr.Close();

                                MessageBox.Show(pointsID);

                                SqlCommand sql = new SqlCommand("insert into pointsEARNEDprogram " +
                                "values('" + 0 + "', '" + pointsID + "')", sqlconn);

                                var ifErr = sql.ExecuteNonQuery();
                                if (ifErr == 0)
                                {
                                    MessageBox.Show("Error in inserting into pointsEARNEDprogram");
                                }
                            }
                            else
                            {
                                MessageBox.Show("AHHAHAHA");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Incorrect email or password");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Admin error");
                    }
                }    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("ERROR");
            }
            finally
            {
                sqlconn.Close();
            }

        }
    }
}
