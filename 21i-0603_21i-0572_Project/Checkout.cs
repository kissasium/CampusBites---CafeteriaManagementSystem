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
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WinFormsApp1
{
    public partial class Checkout : Form
    {
        double totale;
        string cartIDe;
        public Checkout()
        {
            totale = 0;
            cartIDe = " ";

            InitializeComponent();
            populateData();
            panelLeft.Height = button1.Height;
            panelLeft.Top = button1.Top;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelLeft.Height = button1.Height;
            panelLeft.Top = button1.Top;

            this.Hide();        //go to home page
            var form1 = new Home();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelLeft.Height = button2.Height;
            panelLeft.Top = button2.Top;
            panelLeft.BringToFront();

            this.Hide();        //go to menu page
            var form4 = new Menu();
            form4.Closed += (s, args) => this.Close();
            form4.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelLeft.Top = button3.Top;
            panelLeft.Height = button3.Height;
            panelLeft.BringToFront();

            this.Hide();        //go to support form
            var form3 = new Support();
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panelLeft.Height = button4.Height;
            panelLeft.Top = button4.Top;
            panelLeft.BringToFront();

            this.Hide();        
            var form9 = new Profile();
            form9.Closed += (s, args) => this.Close();
            form9.Show();
        }

        private void Checkout_Load(object sender, EventArgs e)
        {
            var connectionString = "Data Source=LAPTOP-S1HUQ0ID\\SQLEXPRESS;Database = CampusBites; Integrated Security=True";
            SqlConnection sqlconn = new SqlConnection(connectionString);
            sqlconn.Open();

            try
            {
                //get customerID 
                string query11 = "Select TOP 1 customerID from currentcustomer order by id DESC";
                SqlCommand cmd11 = new SqlCommand(query11, sqlconn);
                SqlDataReader reader11 = cmd11.ExecuteReader();

                if (reader11.Read())
                {
                    string customerID = reader11["customerID"].ToString();
                    reader11.Close();

                    //get totalprice from ordercart 
                    string query22 = "Select TOP 1 TotalPrice from OrderCart where customerID = '" + customerID + "' order by CartID DESC";
                    SqlCommand cmd32 = new SqlCommand(query22, sqlconn);
                    SqlDataReader reader32 = cmd32.ExecuteReader();

                    if (reader32.Read())
                    {
                        string TotalPricee = reader32["TotalPrice"].ToString();
                        reader32.Close();
                        textBox4.Text = TotalPricee;

                        totale = (double)Decimal.Parse(TotalPricee);

                        string q1 = " Select TOP 1 name from loyaltyProgram lp " +
                            "join pointsEARNEDprogram p on lp.programID = p.programID join customerPoints cp on cp.pointsID = p.pointsID " +
                            "join users u on u.userID = cp.customerID where u.userID = '" + customerID + "' order by p.pointsID DESC ";

                        SqlCommand cmd1 = new SqlCommand(q1, sqlconn);
                        SqlDataReader reader321 = cmd1.ExecuteReader();

                        if (reader321.Read())
                        {
                            string name = reader321["name"].ToString();
                            reader321.Close();

                            if (name == "Silver Membership")
                            {
                                totale = 0.95 * totale;

                                textBox1.Text = "5% on all orders";
                                textBox2.Text = (totale).ToString();
                            }
                            else if (name == "Gold Membership")
                            {
                                totale = 0.90 * totale;

                                textBox1.Text = "10% on all orders";
                                textBox2.Text = (totale).ToString();
                            }
                        }
                        else
                        {
                            MessageBox.Show("discount not displayed");
                        }
                    }
                    else
                    {
                        MessageBox.Show("total price not diplayed");
                    }


                }
                else
                {
                    MessageBox.Show("unable to get customer id");
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
        //payment method buttons
        private void button8_Click(object sender, EventArgs e)  //credit card
        {
            var connectionString = "Data Source=LAPTOP-S1HUQ0ID\\SQLEXPRESS;Database = CampusBites; Integrated Security=True";
            SqlConnection sqlconn22 = new SqlConnection(connectionString);
            sqlconn22.Open();

            try
            {
                //get customerID 
                string query11 = "Select TOP 1 customerID from currentcustomer order by id DESC";
                SqlCommand cmd11 = new SqlCommand(query11, sqlconn22);
                SqlDataReader reader11 = cmd11.ExecuteReader();

                if (reader11.Read())
                {
                    string customerID = reader11["customerID"].ToString();
                    MessageBox.Show(customerID);
                    reader11.Close();

                    string query = "Select TOP 1 cartID from OrderCart where customerID = '" + customerID + "' ";
                    SqlCommand cmd = new SqlCommand(query, sqlconn22);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string cartID = reader["cartID"].ToString();
                        reader.Close();

                        string insertQuery = "INSERT INTO payment (amount, method, transactionDate, cartID) " +
                        "VALUES ('" + totale + "', 'credit card', '" + DateTime.Now + "', '" + cartID + "')";

                        SqlCommand cmdq = new SqlCommand(insertQuery, sqlconn22);

                        try
                        {
                            int rowsAffected = cmdq.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Payment method: Credit Card");
                            }
                            else
                            {
                                MessageBox.Show("Error in inserting payment method");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
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

        private void button5_Click(object sender, EventArgs e)  //debit card
        {
            var connectionString = "Data Source=LAPTOP-S1HUQ0ID\\SQLEXPRESS;Database = CampusBites; Integrated Security=True";
            SqlConnection sqlconn22 = new SqlConnection(connectionString);
            sqlconn22.Open();

            try
            {
                //get customerID 
                string query11 = "Select TOP 1 customerID from currentcustomer order by id DESC";
                SqlCommand cmd11 = new SqlCommand(query11, sqlconn22);
                SqlDataReader reader11 = cmd11.ExecuteReader();

                if (reader11.Read())
                {
                    string customerID = reader11["customerID"].ToString();
                    reader11.Close();

                    string query = "Select TOP 1 cartID from OrderCart where customerID = '" + customerID + "' ";
                    SqlCommand cmd = new SqlCommand(query, sqlconn22);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string cartID = reader["cartID"].ToString();
                        reader.Close();

                        string insertQuery = "INSERT INTO payment (amount, method, transactionDate, cartID) " +
                      "VALUES ('" + totale + "', 'debit card', '" + DateTime.Now + "', '" + cartID + "')";

                        SqlCommand cmdq = new SqlCommand(insertQuery, sqlconn22);

                        try
                        {
                            int rowsAffected = cmdq.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Payment method: Debit Card");
                            }
                            else
                            {
                                MessageBox.Show("Error in inserting payment method");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
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

        private void button6_Click(object sender, EventArgs e)      //cash
        {
            var connectionString = "Data Source=LAPTOP-S1HUQ0ID\\SQLEXPRESS;Database = CampusBites; Integrated Security=True";
            SqlConnection sqlconn22 = new SqlConnection(connectionString);
            sqlconn22.Open();

            try
            {
                //get customerID 
                string query11 = "Select TOP 1 customerID from currentcustomer order by id DESC";
                SqlCommand cmd11 = new SqlCommand(query11, sqlconn22);
                SqlDataReader reader11 = cmd11.ExecuteReader();

                if (reader11.Read())
                {
                    string customerID = reader11["customerID"].ToString();
                    reader11.Close();

                    string query = "Select TOP 1 cartID from OrderCart where customerID = '" + customerID + "' ";
                    SqlCommand cmd = new SqlCommand(query, sqlconn22);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string cartID = reader["cartID"].ToString();
                        reader.Close();

                        string insertQuery = "INSERT INTO payment (amount, method, transactionDate, cartID) " +
                      "VALUES ('" + totale + "', 'credit card', '" + DateTime.Now + "', '" + cartID + "')";

                        SqlCommand cmdq = new SqlCommand(insertQuery, sqlconn22);

                        try
                        {
                            int rowsAffected = cmdq.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Payment method: Cash");

                                this.Hide();        //close login form and open cash form
                                var form3 = new Cash();
                                form3.Closed += (s, args) => this.Close();
                                form3.Show();
                            }
                            else
                            {
                                MessageBox.Show("Error in inserting payment method");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
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

        private void button7_Click(object sender, EventArgs e)  //place order button
        {
            var connectionString = "Data Source=LAPTOP-S1HUQ0ID\\SQLEXPRESS;Database = CampusBites; Integrated Security=True";
            SqlConnection sqlconn22 = new SqlConnection(connectionString);
            sqlconn22.Open();

            try
            {
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

                          //update cart for customer when logs in again  
                            String q2 = "Update OrderCart set TotalPrice =  0  where cartID = '" + cartID + "' ";
                        SqlCommand cmd32233qw = new SqlCommand(q2, sqlconn22);
                        var ifError113qw = cmd32233qw.ExecuteNonQuery();
                        if (ifError113qw == 0)
                        {
                            MessageBox.Show("Error in updating total price");
                        }
                        else
                        {
                            String q22 = "Update CartItem set quantity =  '" + 0 + "' where cartID = '" + cartID + "' ";
                            SqlCommand cmdw = new SqlCommand(q22, sqlconn22);
                            var ifErrorw = cmdw.ExecuteNonQuery();
                            if (ifErrorw == 0)
                            {
                                MessageBox.Show("Error in updating quantity");
                            }
                            else
                            {
                                MessageBox.Show("Thanks man for shopping with us ;)");

                                this.Hide();        //close login form and open home form
                                var form3 = new Home();
                                form3.Closed += (s, args) => this.Close();
                                form3.Show();
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

        void populateData()
        {
            string Quantity = "";

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

                    string squery = "Select i.itemName, ci.Quantity from CartItem ci JOIN item i ON ci.ItemID = i.itemID where ci.CartID = '" + cartID + "' and ci.Quantity <> 0";
                    SqlCommand scmd = new SqlCommand(squery, sqlconn22);
                    SqlDataReader sreader = scmd.ExecuteReader();

                    if (sreader.HasRows)
                    {
                        dataGridView1.Columns.Add("itemName", "Item name");
                        dataGridView1.Columns.Add("Quantity", "Quantity");

                        while (sreader.Read())
                        {

                            string itemName = sreader["itemName"].ToString();
                            Quantity = sreader["Quantity"].ToString();

                           // if(Int32.Parse(Quantity) > 0)
                            {
                                dataGridView1.Rows.Add(itemName, Quantity);
                                dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
                            }

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
    }
}
