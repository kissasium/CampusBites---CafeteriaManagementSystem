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
    public partial class Admin : Form
    {
        string reorderquantity = "";
        string currentQuantity = "";
        string InventoryID = "";
        string iname = "";
        string vendorID = "";
        string adminid = "";

        public Admin()
        {
            InitializeComponent();
            populateddata();
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

        private void back_button2_Click(object sender, EventArgs e)
        {
            this.Hide();        
            var form4 = new Login();
            form4.Closed += (s, args) => this.Close();
            form4.Show();
        }
    }
}
