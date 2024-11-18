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

namespace WinFormsApp1
{
    public partial class Cafe_manager_inventory : Form
    {
        string reorderquantity = "";
        string currentQuantity = "";
        string InventoryID = "";
        string iname = "";
        string vendorID = "";
        string adminid = "";
        public Cafe_manager_inventory()
        {
            InitializeComponent();
            populateddata();
            populatedata();
        }

        private void button1_Click(object sender, EventArgs e)  //log out
        {
            this.Hide();        //close form and open login form
            var form4 = new Login();
            form4.Closed += (s, args) => this.Close();
            form4.Show();
        }

        private void back_button2_Click(object sender, EventArgs e)
        {
            this.Hide();        //close form and open cafe manager form
            var form4 = new Cafe_Manager();
            form4.Closed += (s, args) => this.Close();
            form4.Show();
        }

        void populateddata()
        {
            var connectionString = "Data Source=LAPTOP-S1HUQ0ID\\SQLEXPRESS;Database = CampusBites; Integrated Security=True";
            SqlConnection sqlconn = new SqlConnection(connectionString);
            sqlconn.Open();

            try
            {
                string vendorID = "";

                string query11 = "SELECT i.InventoryID, v.vendorID, i.iname, i.currentQuantity, i.reorderquantity, i.adminid " +
                                 "FROM inventory i " +
                                 "JOIN vendor v ON v.inventoryID = i.inventoryID";
                SqlCommand cmd11 = new SqlCommand(query11, sqlconn);
                SqlDataReader reader11 = cmd11.ExecuteReader();

                if (reader11.HasRows)
                {
                    dataGridView1.Columns.Add("InventoryID", "Inventory ID");
                    dataGridView1.Columns.Add("iname", "Inventory Name");
                    dataGridView1.Columns.Add("currentQuantity", "Current Quantity");
                    dataGridView1.Columns.Add("reorderquantity", "Reorder Quantity");
                    dataGridView1.Columns.Add("vendorID", "Vendor ID");  // Add the missing column

                    while (reader11.Read())
                    {
                        InventoryID = reader11["InventoryID"].ToString();
                        iname = reader11["iname"].ToString();
                        currentQuantity = reader11["currentQuantity"].ToString();
                        reorderquantity = reader11["reorderquantity"].ToString();
                        adminid = reader11["adminid"].ToString();
                        vendorID = reader11["vendorID"].ToString();
                        dataGridView1.Rows.Add(InventoryID, iname, currentQuantity, reorderquantity, vendorID);
                        dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
                    }
                }
                else
                {
                    reader11.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error 1" + ex.Message);
            }
        }

        void populatedata()
        {
            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();

            var connectionString = "Data Source=LAPTOP-S1HUQ0ID\\SQLEXPRESS;Database = CampusBites; Integrated Security=True";
            SqlConnection sqlconn = new SqlConnection(connectionString);
            sqlconn.Open();

            try
            {
                string vendorID = "";
                string first_name = "";
                string last_name = "";
                string email = "";
                string phonenumber = "";

                string query11 = "Select i.InventoryID, v.vendorID, v.first_name, v.last_name, v.email, v.phonenumber from inventory i join vendor v on v.inventoryID = i.inventoryID";
                SqlCommand cmd11 = new SqlCommand(query11, sqlconn);
                SqlDataReader reader11 = cmd11.ExecuteReader();

                if (reader11.HasRows)
                {
                    dataGridView2.Columns.Add("InventoryID", "Inventory ID");
                    dataGridView2.Columns.Add("vendorID", "Vendor ID");
                    dataGridView2.Columns.Add("first_name", "First Name");
                    dataGridView2.Columns.Add("last_name", "Last Name");
                    dataGridView2.Columns.Add("email", "Email");
                    dataGridView2.Columns.Add("phonenumber", "Phone number");

                    while (reader11.Read())
                    {
                        string InventoryID = reader11["InventoryID"].ToString();
                        vendorID = reader11["vendorID"].ToString();
                        first_name = reader11["first_name"].ToString();
                        last_name = reader11["last_name"].ToString();
                        email = reader11["email"].ToString();
                        phonenumber = reader11["phonenumber"].ToString();
                        dataGridView2.Rows.Add(InventoryID, vendorID, first_name, last_name, email, phonenumber);
                        dataGridView2.DefaultCellStyle.ForeColor = Color.Black;
                    }
                }
                else
                {
                    reader11.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error 1" + ex.Message);
            }
        }


        private void ok_button1_Click(object sender, EventArgs e)
        {
            var reorderamt = textBox1.Text;

            var connectionString = "Data Source=LAPTOP-S1HUQ0ID\\SQLEXPRESS;Database = CampusBites; Integrated Security=True";
            SqlConnection sqlconn = new SqlConnection(connectionString);
            sqlconn.Open();
            try
            {
                double x = (double)Decimal.Parse(reorderamt);
                double y = (double)Decimal.Parse(reorderquantity);
                double z = y - x;

                if (z == 0)
                {
                    try
                    {
                        SqlCommand sqlcomm = new SqlCommand("update inventory set currentQuantity = '" + currentQuantity + "',reorderquantity =  '" + z + "' where  adminID ='" + 1 + "'", sqlconn);
                        var ifError = sqlcomm.ExecuteNonQuery();
                        if (ifError == 0)
                        {
                            MessageBox.Show("ERROR WHILE INSERTING");
                        }
                        else
                        {
                            // Clear existing rows in the DataGridView
                            dataGridView1.Rows.Clear();
                            populateddata();
                        }
                    }
                    catch (Exception er)
                    {
                        MessageBox.Show(er.Message);
                    }
                }
                else if (z > 0)
                {
                    try
                    {
                        SqlCommand sqlcomm = new SqlCommand("update inventory set iname = '" + iname + "',  currentQuantity = '" + currentQuantity + "'," +
                            "reorderquantity =  '" + z + "' where  adminID ='" + 1 + "'", sqlconn);

                        var ifError = sqlcomm.ExecuteNonQuery();
                        if (ifError == 0)
                        {
                            MessageBox.Show("ERROR WHILE INSERTING");
                        }
                        else
                        {
                            dataGridView1.Rows.Clear();
                            populateddata();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ytvgbhjvgcfdxfcgv" + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid entry");
                }
            }
            catch (Exception a)
            {
                MessageBox.Show("fcbhebc" + a.Message);
            }
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form4 = new Add_Vendor();
            form4.Closed += (s, args) => this.Close();
            form4.Show();
        }
    }
}
