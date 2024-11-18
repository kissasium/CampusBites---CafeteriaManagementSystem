using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class Cafe_manager_employee : Form
    {
        public Cafe_manager_employee()
        {
            InitializeComponent();
            populateData();
        }

        private void button1_Click(object sender, EventArgs e)  //log out 
        {
            this.Hide();        //close form and open login form
            var form4 = new Login();
            form4.Closed += (s, args) => this.Close();
            form4.Show();
        }

        void populateData()
        {
            // Clear existing rows and columns in the DataGridView
            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();

            var connectionString = "Data Source=LAPTOP-S1HUQ0ID\\SQLEXPRESS;Database = CampusBites; Integrated Security=True";
            SqlConnection sqlconn22 = new SqlConnection(connectionString);
            sqlconn22.Open();

            //get customerID 
            string query11 = "Select TOP 1 staffid from currentstaff order by id DESC";
            SqlCommand cmd11 = new SqlCommand(query11, sqlconn22);
            SqlDataReader reader11 = cmd11.ExecuteReader();

            if (reader11.Read())
            {
                string staffID = reader11["staffid"].ToString();
                reader11.Close();

                string query = "Select s.hourswork, u.first_name, u.last_name, u.email, u.password, u.phonenumber from users u join staff s on s.userID = u.userID where u.usertype = 'staff' and s.srole <> 'cafe manager' ";
                SqlCommand cmd = new SqlCommand(query, sqlconn22);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    dataGridView2.Columns.Add("first_name", "First name");
                    dataGridView2.Columns.Add("last_name", "Last name");
                    dataGridView2.Columns.Add("email", "Email");
                    dataGridView2.Columns.Add("password", "Password");
                    dataGridView2.Columns.Add("phonenumber", "Phone number");
                    dataGridView2.Columns.Add("hourswork", "Hours Worked");

                    while (reader.Read())
                    {
                        string fname = reader["first_name"].ToString();
                        string lname = reader["last_name"].ToString();
                        string email = reader["email"].ToString();
                        string password = reader["password"].ToString();
                        string phonenumber = reader["phonenumber"].ToString();
                        string hourswork = reader["hourswork"].ToString();

                        dataGridView2.Rows.Add(fname, lname, email, password, phonenumber, hourswork);
                        dataGridView2.DefaultCellStyle.ForeColor = Color.Black;

                    }
                }
                else
                {
                    MessageBox.Show("No data");
                }

                sqlconn22.Close();
            }
        }

        private void back_button2_Click(object sender, EventArgs e)
        {
            this.Hide();        //close form and open cafe manager form
            var form4 = new Cafe_Manager();
            form4.Closed += (s, args) => this.Close();
            form4.Show();
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            var connectionString = "Data Source=LAPTOP-S1HUQ0ID\\SQLEXPRESS;Database = CampusBites; Integrated Security=True";
            SqlConnection sqlconn22 = new SqlConnection(connectionString);
            sqlconn22.Open();

            try
            {
                var fname = fname_textBox2.Text;
                var lname = lname_textBox1.Text;
                var email = email_textBox1.Text;
                var phonenum = phonenum_textBox2.Text;
                var pass = password_textBox4.Text;
                var role = role_comboBox1.SelectedItem;
                var usertype = "staff";
                var hourswork = hours_textBox1.Text + " hours";

                //check if staff member already exists
                string squery = "Select email from users where email = '" + email + "' and usertype = 'staff' ";
                SqlCommand scmd = new SqlCommand(squery, sqlconn22);
                SqlDataReader sreader = scmd.ExecuteReader();

                if (sreader.Read())
                {
                    sreader.Close();
                    MessageBox.Show("Staff Member already signed up");
                }
                else   //staff member does not already exist
                {
                    sreader.Close();

                    //add new member
                    SqlCommand sqlcomm = new SqlCommand("insert into users " +
                        "values('" + fname + "', '" + lname + "', '" + email + "','" + pass + "' , '" + phonenum + "', '" + usertype + "' )", sqlconn22);

                    var ifError = sqlcomm.ExecuteNonQuery();
                    if (ifError == 0)
                    {
                        MessageBox.Show("Unable to add new employee");
                    }
                    else
                    {

                        string query = "Select userID from users where email = '" + email + "'";
                        SqlCommand cmd = new SqlCommand(query, sqlconn22);

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            //get userID of customer
                            string userID = reader["userID"].ToString();
                            reader.Close();
                            SqlCommand sqlcomm1 = new SqlCommand("insert into staff " +
                                 "values('" + userID + "', '" + role + "', '" + hourswork + "', '" + 1 + "','" + 1 + "')", sqlconn22);   

                            var ifError1 = sqlcomm1.ExecuteNonQuery();
                            if (ifError1 == 0)
                            {
                                MessageBox.Show("Error staff");
                            }
                            else
                            {
                                MessageBox.Show("Added successfully");

                                // Clear existing rows in the DataGridView
                                dataGridView2.Rows.Clear();
                                populateData();
                            }
                        }
                    }
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
