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
    public partial class Cashier : Form
    {
        public Cashier()
        {
            InitializeComponent();
            populateData();
        }

        private void Cashier_Load(object sender, EventArgs e)
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

                        //get customerID 
                        string query111 = "Select TOP 1 customerID from currentcustomer order by id DESC";
                        SqlCommand cmd111 = new SqlCommand(query111, sqlconn);
                        SqlDataReader reader111 = cmd111.ExecuteReader();

                        if (reader111.Read())
                        {
                            string customerID = reader111["customerID"].ToString();
                            reader111.Close();

                            string query1 = "Select u.first_name, u.last_name from users u join customer c on c.userID = u.userID where u.userID = '" + customerID + "'";
                            SqlCommand cmd1 = new SqlCommand(query1, sqlconn);
                            SqlDataReader reader1 = cmd1.ExecuteReader();

                            if (reader1.Read())
                            {
                                string customername = reader1["first_name"].ToString() + " " + reader1["last_name"].ToString();
                                reader1.Close();

                                textBox2.Text = customername;
                            }
                            else
                            {
                                MessageBox.Show("Error in finding customer name");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Error in finding current customer");
                        }

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

        void populateData()
        {
            var connectionString = "Data Source=LAPTOP-S1HUQ0ID\\SQLEXPRESS;Database = CampusBites; Integrated Security=True";
            SqlConnection sqlconn22 = new SqlConnection(connectionString);
            sqlconn22.Open();

            //get customerID 
            string query11 = "Select TOP 1 customerID from currentcustomer order by id DESC";
            SqlCommand cmd11 = new SqlCommand(query11, sqlconn22);
            SqlDataReader reader11 = cmd11.ExecuteReader();

            if (reader11.Read())
            {
                string customerID = reader11["customerID"].ToString();
                reader11.Close();

                string query = "Select TOP 1 cartID from OrderCart where customerID = '" + customerID + "' order by cartID desc";
                SqlCommand cmd = new SqlCommand(query, sqlconn22);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string cartID = reader["cartID"].ToString();
                    reader.Close();

                    string squery = "Select i.itemName, oi.Quantity from OrderHistory oi JOIN item i ON i.ItemID = oi.itemID where oi.CartID = '" + cartID + "' and oi.Quantity <> 0";
                    SqlCommand scmd = new SqlCommand(squery, sqlconn22);
                    SqlDataReader sreader = scmd.ExecuteReader();

                    if (sreader.HasRows)
                    {
                        dataGridView2.Columns.Add("itemName", "Item name");
                        dataGridView2.Columns.Add("Quantity", "Quantity");

                        while (sreader.Read())
                        {
                            string itemName = sreader["itemName"].ToString();
                            string Quantity = sreader["Quantity"].ToString();
                            dataGridView2.Rows.Add(itemName, Quantity);
                            dataGridView2.DefaultCellStyle.ForeColor = Color.Black;

                        }
                    }
                    else
                    {
                        MessageBox.Show("No data");
                    }

                }
                sqlconn22.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)  //log out button
        {
            this.Hide();        //close employee form and open login form
            var form4 = new Login();
            form4.Closed += (s, args) => this.Close();
            form4.Show();
        }
    }
}
