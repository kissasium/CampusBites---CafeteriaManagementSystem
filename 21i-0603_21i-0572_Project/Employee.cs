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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
            populateData();
        }

        void populateData()
        {
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

                string query = "Select s.hourswork, u.first_name, u.last_name, u.email, u.password, u.phonenumber from users u join staff s on s.userID = u.userID where u.userID = '" + staffID + "' ";
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

        private void button1_Click(object sender, EventArgs e)  //log out buttom
        {
            this.Hide();        //close employee form and open login form
            var form4 = new Login();
            form4.Closed += (s, args) => this.Close();
            form4.Show();
        }
    }
}
