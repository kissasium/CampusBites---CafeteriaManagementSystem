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
    public partial class Cook : Form
    {
        public Cook()
        {
            InitializeComponent();
            populateDatamenu();
        }

        private void Cook_Load(object sender, EventArgs e)
        {
            var connectionString = "Data Source=LAPTOP-S1HUQ0ID\\SQLEXPRESS;Database = CampusBites; Integrated Security=True";
            SqlConnection sqlconn = new SqlConnection(connectionString);
            sqlconn.Open();

            try
            {
                //get staffID 
                string query11 = "Select TOP 1 staffid from currentstaff order by id DESC";
                SqlCommand cmd11 = new SqlCommand(query11, sqlconn);
                SqlDataReader reader11 = cmd11.ExecuteReader();

                if (reader11.Read())
                {
                    string staffID = reader11["staffid"].ToString();
                    reader11.Close();

                    string query = "Select s.staffID, u.first_name, u.last_name from users u join staff s on s.userID = u.userID where u.userID = '" + staffID + "'";
                    SqlCommand cmd = new SqlCommand(query, sqlconn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string staffname = reader["first_name"].ToString() + " " + reader["last_name"].ToString();
                        string page_staffID = reader["staffID"].ToString();
                        reader.Close();

                        textBox4.Text = staffname;
                        textBox1.Text = page_staffID;

                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                }
                else
                {
                    MessageBox.Show("Current Staff member not found");
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

        void populateDatamenu()
        {
            var connectionString = "Data Source=LAPTOP-S1HUQ0ID\\SQLEXPRESS;Database = CampusBites; Integrated Security=True";
            SqlConnection sqlconn22 = new SqlConnection(connectionString);
            sqlconn22.Open();


            string squery = "Select itemName, price from item ";
            SqlCommand scmd = new SqlCommand(squery, sqlconn22);
            SqlDataReader sreader = scmd.ExecuteReader();

            if (sreader.HasRows)
            {
                dataGridView2.Columns.Add("itemName", "Item name");
                dataGridView2.Columns.Add("price", "Price");

                while (sreader.Read())
                {
                    string itemName = sreader["itemName"].ToString();
                    string price = sreader["price"].ToString();
                    dataGridView2.Rows.Add(itemName, price);
                    dataGridView2.DefaultCellStyle.ForeColor = Color.Black;
                }
            }
            else
            {
                MessageBox.Show("No data");
            }
            sqlconn22.Close();

        }

        private void logout_button1_Click(object sender, EventArgs e)
        {
            this.Hide();        //close employee form and open login form
            var form4 = new Login();
            form4.Closed += (s, args) => this.Close();
            form4.Show();
        }
    }
}
