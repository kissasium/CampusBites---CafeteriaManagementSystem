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
    public partial class Cafe_manager_menu : Form
    {
        public Cafe_manager_menu()
        {
            InitializeComponent();
            populateDatamenu();
        }

        void populateDatamenu()
        {
            // Clear existing rows in the DataGridView
            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();

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

        private void button2_Click(object sender, EventArgs e)  //add button
        {
            var connectionString = "Data Source=LAPTOP-S1HUQ0ID\\SQLEXPRESS;Database = CampusBites; Integrated Security=True";
            SqlConnection sqlconn22 = new SqlConnection(connectionString);
            sqlconn22.Open();

            try
            {
                var iname = name_textBox2.Text;
                var iprice = price_textBox1.Text;

                //check if item already exists
                string squery = "Select itemName, price from item where itemName = '" + iname + "'";
                SqlCommand scmd = new SqlCommand(squery, sqlconn22);
                SqlDataReader sreader = scmd.ExecuteReader();

                if (sreader.Read())
                {
                    sreader.Close();
                    MessageBox.Show("Item already exists");
                }
                else   //item does not already exist
                {
                    sreader.Close();

                    //insert in item table
                    SqlCommand sqlcomm1 = new SqlCommand("insert into item " +
                                 "values('" + iname + "', '" + iprice + "')", sqlconn22);
                    var ifError1 = sqlcomm1.ExecuteNonQuery();
                    if (ifError1 == 0)
                    {
                        MessageBox.Show("Unabke to insert new item");
                    }
                    else
                    {
                        MessageBox.Show("Inserted successfully");

                        // Clear existing rows in the DataGridView
                        dataGridView2.Rows.Clear();
                        populateDatamenu();
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

        private void Update_button_Click(object sender, EventArgs e)
        {
            var connectionString = "Data Source=LAPTOP-S1HUQ0ID\\SQLEXPRESS;Database = CampusBites; Integrated Security=True";
            SqlConnection sqlconn22 = new SqlConnection(connectionString);
            sqlconn22.Open();

            try
            {
                var iname = textBox2.Text;
                var iprice = textBox1.Text;

                //check if item already exists
                string squery = "Select itemName, price from item where itemName = '" + iname + "'";
                SqlCommand scmd = new SqlCommand(squery, sqlconn22);
                SqlDataReader sreader = scmd.ExecuteReader();

                if (sreader.Read())     //item exists in table
                {
                    string itemname = sreader["itemName"].ToString();
                    sreader.Close();

                    //update in item table
                    string query3 = "Update item set price  = '" + iprice + "' where itemName = '" + iname + "' ";
                    SqlCommand cmd322 = new SqlCommand(query3, sqlconn22);
                    var ifError1 = cmd322.ExecuteNonQuery();

                    if (ifError1 == 0)
                    {
                        MessageBox.Show("Unable to update item");
                    }
                    else
                    {
                        MessageBox.Show("Updated successfully");

                        // Clear existing rows in the DataGridView
                        dataGridView2.Rows.Clear();
                        populateDatamenu();
                    }
                }
                else   //item does not exist
                {
                    sreader.Close();
                    MessageBox.Show("Item does not exist");
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

        private void Delete_button_Click(object sender, EventArgs e)
        {
            var connectionString = "Data Source=LAPTOP-S1HUQ0ID\\SQLEXPRESS;Database = CampusBites; Integrated Security=True";
            SqlConnection sqlconn22 = new SqlConnection(connectionString);
            sqlconn22.Open();

            try
            {
                var iname = textBox5.Text;

                //check if item exists
                string squery = "Select itemName, price from item where itemName = '" + iname + "'";
                SqlCommand scmd = new SqlCommand(squery, sqlconn22);
                SqlDataReader sreader = scmd.ExecuteReader();

                if (sreader.Read())
                {
                    string itemname = sreader["itemName"].ToString();
                    sreader.Close();

                    //delete in item table
                    string query3 = "Delete from item where itemName = '" + iname + "' ";
                    SqlCommand cmd322 = new SqlCommand(query3, sqlconn22);
                    var ifError1 = cmd322.ExecuteNonQuery();
                    if (ifError1 == 0)
                    {
                        MessageBox.Show("Unable to delete item");
                    }
                    else
                    {
                        MessageBox.Show("Deleted successfully");

                        // Clear existing rows in the DataGridView
                        dataGridView2.Rows.Clear();
                        populateDatamenu();
                    }
                }
                else   //item does not already exist
                {
                    MessageBox.Show("Item does not exist");
                    sreader.Close();
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

        private void back_button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();        //close form and open cafe manager form
            var form4 = new Cafe_Manager();
            form4.Closed += (s, args) => this.Close();
            form4.Show();
        }
    }
}
