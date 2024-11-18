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
    public partial class Cart : Form
    {
        double totale;
        string name;
        string cartIDe;
        int quan;

        public Cart()
        {
            quan = 0;
            totale = 0;
            name = " ";
            cartIDe = " ";

            InitializeComponent();
            panelLeft.Height = button2.Height;
            panelLeft.Top = button2.Top;
        }

        private void Cart_Load(object sender, EventArgs e)
        {
            var connectionString = "Data Source=LAPTOP-S1HUQ0ID\\SQLEXPRESS;Database = CampusBites; Integrated Security=True";
            SqlConnection sqlconn = new SqlConnection(connectionString);
            sqlconn.Open();

            string qq11 = "Select TOP 1 itemid from currentitem order by id desc";
            SqlCommand ccmmdd = new SqlCommand(qq11, sqlconn);
            SqlDataReader rc = ccmmdd.ExecuteReader();

            if (rc.Read())
            {
                string iitemID = rc["itemid"].ToString();
                rc.Close();

                string query11 = "Select TOP 1 customerID from currentcustomer order by id DESC";
                SqlCommand cmd11 = new SqlCommand(query11, sqlconn);
                SqlDataReader reader11 = cmd11.ExecuteReader();

                if (reader11.Read())
                {
                    string customerID = reader11["customerID"].ToString();
                    reader11.Close();

                    string query = "Select TOP 1 cartID from OrderCart where customerID = '" + customerID + "' order by cartID desc";
                    SqlCommand cmd = new SqlCommand(query, sqlconn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string cartID = reader["cartID"].ToString();
                        reader.Close();
                        //check if item exists in cart
                        string query1 = "Select TOP 1 itemID from CartItem where cartID = '" + cartID + "' and itemID = '" + iitemID + "'order by CartItemID DESC";
                        SqlCommand cmd1 = new SqlCommand(query1, sqlconn);
                        SqlDataReader reader1 = cmd1.ExecuteReader();

                        if (reader1.Read())
                        {
                            string itemID = reader1["itemID"].ToString();
                            reader1.Close();

                            string query112 = "Select itemName from item where itemID = '" + itemID + "'";
                            SqlCommand cmd112 = new SqlCommand(query112, sqlconn);
                            SqlDataReader reader112 = cmd112.ExecuteReader();

                            if (reader112.Read())
                            {
                                string itemName = reader112["itemName"].ToString();
                                reader112.Close();

                                name = itemName;

                                textBox1.Text = itemName;
                                textBox5.Text = " ";
                            }
                        }
                        else
                        {
                            MessageBox.Show("errorr");
                        }
                    }
                }
            }

            String total = totale.ToString();
            textBox4.Text = total;
        }

        private void button5_Click(object sender, EventArgs e)  //add to cart
        {
            var quantity = textBox2.Text;

            if (Int32.Parse(quantity) < 0)
            {
                MessageBox.Show("Error! Negative Quantity cannot exist, enter again");
            }
            else
            {

                var connectionString = "Data Source=LAPTOP-S1HUQ0ID\\SQLEXPRESS;Database = CampusBites; Integrated Security=True";
                SqlConnection sqlconn = new SqlConnection(connectionString);
                sqlconn.Open();

                try
                {
                    //update quantity in cart
                    //get customerID 
                    string query11 = "Select TOP 1 customerID from currentcustomer order by id DESC";
                    SqlCommand cmd11 = new SqlCommand(query11, sqlconn);
                    SqlDataReader reader11 = cmd11.ExecuteReader();

                    if (reader11.Read())
                    {
                        string customerID = reader11["customerID"].ToString();
                        reader11.Close();

                        string query = "Select TOP 1 cartID from OrderCart where customerID = '" + customerID + "' order by cartID desc";
                        SqlCommand cmd = new SqlCommand(query, sqlconn);
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            string cartID = reader["cartID"].ToString();
                            cartIDe = cartID;
                            reader.Close();

                            string qw = "Select TOP 1 itemid from currentitem order by id desc";
                            SqlCommand cmdd3 = new SqlCommand(qw, sqlconn);
                            SqlDataReader readerd333 = cmdd3.ExecuteReader();

                            if (readerd333.Read())
                            {
                                string curr_itemid = readerd333["itemid"].ToString();
                                readerd333.Close();


                                string query2 = "Select TOP 1 ItemPrice from CartItem where cartID = '" + cartID + "' and itemID = '" + curr_itemid + "' order by CartItemID DESC";
                                SqlCommand cmd3 = new SqlCommand(query2, sqlconn);
                                SqlDataReader reader333 = cmd3.ExecuteReader();

                                if (reader333.Read())
                                {
                                    string ItemPrice = reader333["ItemPrice"].ToString();
                                    reader333.Close();

                                    //get previous totalprice from ordercart to update total amount to be paid by customer
                                    string query22 = "Select TOP 1 TotalPrice from OrderCart where customerID = '" + customerID + "' order by CartID DESC";
                                    SqlCommand cmd32 = new SqlCommand(query22, sqlconn);
                                    SqlDataReader reader32 = cmd32.ExecuteReader();

                                    if (reader32.Read())
                                    {
                                        string TotalPricee = reader32["TotalPrice"].ToString();
                                        reader32.Close();

                                        double prev_price = (double)Decimal.Parse(TotalPricee);    //converting string to int

                                        //convert quantity and item price to int so the total amount to be paid can be calculated
                                        double d_quantity = Int32.Parse(quantity);  //converting string to int
                                        double d_ItemPrice = (double)Decimal.Parse(ItemPrice);
                                        double x = d_quantity * d_ItemPrice;
                                        double total = x + prev_price;      //add new price to prev to calculate total
                                                                            // MessageBox.Show("New total is : " + total.ToString());
                                        totale = total;


                                        string query3 = "Update OrderCart set TotalPrice = '" + total + "' where customerID = '" + customerID + "' and cartID = '" + cartID + "' ";
                                        SqlCommand cmd322 = new SqlCommand(query3, sqlconn);
                                        cmd322.ExecuteNonQuery();

                                        String totalww = totale.ToString();
                                        textBox4.Text = totalww;

                                        textBox6.Text = totalww;

                                        if (totale >= 10000 && totale < 100000)
                                        {
                                            textBox5.Text = "Silver MemberShip";
                                        }
                                        else if (totale >= 100000)
                                        {
                                            textBox5.Text = "Gold MemberShip";
                                        }
                                        else
                                        {
                                            textBox5.Text = " ";
                                        }

                                        //update quantity in cartitem table
                                        string cq = "Select quantity from CartItem where cartID = '" + cartID + "' and itemID  = '" + curr_itemid + "' ";
                                        SqlCommand ccmd32 = new SqlCommand(cq, sqlconn);
                                        SqlDataReader creader32 = ccmd32.ExecuteReader();

                                        if (creader32.Read())
                                        {
                                            string curr_quantity = creader32["quantity"].ToString();
                                            creader32.Close();

                                            int currq = (int)Int32.Parse(curr_quantity);
                                            int q = (int)Int32.Parse(quantity);
                                            quan = q + currq;
                                        }
                                        else
                                        {
                                            MessageBox.Show("error quantity");
                                        }

                                        //insert into orderhistory to maintain prev order
                                        SqlCommand sqlcomm = new SqlCommand("insert into OrderHistory " +
                                                "values('" + cartID + "', '" + customerID + "', '" + curr_itemid + "','" + quan.ToString() + "' ," +
                                                " '" + x.ToString() + "', '" + DateTime.Now + "' )", sqlconn);

                                        var ifError = sqlcomm.ExecuteNonQuery();
                                        if (ifError == 0)
                                        {
                                            MessageBox.Show("Error in inserting order history");
                                        }

                                        //update quantity in cartItem
                                        string cquery33 = "Update CartItem set quantity = '" + quan + "' where cartID = '" + cartID + "' and itemID  = '" + curr_itemid + "'";
                                        SqlCommand ccmd3223 = new SqlCommand(cquery33, sqlconn);
                                        var cifError11 = ccmd3223.ExecuteNonQuery();
                                        if (cifError11 == 0)
                                        {
                                            MessageBox.Show("Error");
                                        }
                                        else
                                        {
                                            MessageBox.Show("Quantity : " + quan);
                                        }

                                        //update points in database
                                        string query33 = "Update customerPoints set totalpoints = '" + total + "' where customerID = '" + customerID + "'";
                                        SqlCommand cmd3223 = new SqlCommand(query33, sqlconn);
                                        var ifError11 = cmd3223.ExecuteNonQuery();
                                        if (ifError11 == 0)
                                        {
                                            MessageBox.Show("Error");
                                        }
                                        else
                                        {
                                            MessageBox.Show("Current points: " + total);
                                        }

                                        //update pointsEARNEDprogram 
                                        if (totale >= 10000 && totale < 100000)
                                        {
                                            //"Silver MemberShip" -> programID = 1
                                            string q = "Select pointsID from customerPoints where customerID = '" + customerID + "' ";
                                            SqlCommand cmd1 = new SqlCommand(q, sqlconn);
                                            SqlDataReader readerr = cmd1.ExecuteReader();

                                            if (readerr.Read())
                                            {
                                                string pointsID = readerr["pointsID"].ToString();
                                                readerr.Close();

                                                string q1 = "Update pointsEARNEDprogram set pointsID = '" + pointsID + "', programID = '" + 1 + "' ";
                                                SqlCommand cmd32233 = new SqlCommand(q1, sqlconn);
                                                var ifError113 = cmd32233.ExecuteNonQuery();
                                                if (ifError113 == 0)
                                                {
                                                    MessageBox.Show("Error in updating pointsEARNEDprogram");
                                                }
                                            }

                                        }
                                        else if (totale >= 100000)
                                        {
                                            //"Gold MemberShip"-> programID = 2
                                            string qq = "Select pointsID from customerPoints where customerID = '" + customerID + "' ";
                                            SqlCommand cmd1q = new SqlCommand(qq, sqlconn);
                                            SqlDataReader readerrq = cmd1q.ExecuteReader();

                                            if (readerrq.Read())
                                            {
                                                string pointsID = readerrq["pointsID"].ToString();
                                                readerrq.Close();

                                                string q1q = "Update pointsEARNEDprogram set pointsID = '" + pointsID + "' , programID = '" + 2 + "' ";
                                                SqlCommand cmd32233q = new SqlCommand(q1q, sqlconn);
                                                var ifError113q = cmd32233q.ExecuteNonQuery();
                                                if (ifError113q == 0)
                                                {
                                                    MessageBox.Show("Error in updating pointsEARNEDprogram");
                                                }
                                            }
                                        }
                                        else
                                        {
                                            string qqw = "Select pointsID from customerPoints where customerID = '" + customerID + "' ";
                                            SqlCommand cmd1qw = new SqlCommand(qqw, sqlconn);
                                            SqlDataReader readerrqw = cmd1qw.ExecuteReader();

                                            if (readerrqw.Read())
                                            {
                                                string pointsID = readerrqw["pointsID"].ToString();
                                                readerrqw.Close();

                                                string q1qw = "Update pointsEARNEDprogram set pointsID = '" + pointsID + "' , programID = '" + 0 + "' ";
                                                SqlCommand cmd32233qw = new SqlCommand(q1qw, sqlconn);
                                                var ifError113qw = cmd32233qw.ExecuteNonQuery();
                                                if (ifError113qw == 0)
                                                {
                                                    MessageBox.Show("Error in updating pointsEARNEDprogram");
                                                }
                                            }
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("error 4");
                                    }

                                }
                                else
                                {
                                    MessageBox.Show("error 3");
                                }
                            }
                            else
                            {
                                MessageBox.Show("unable to find current item");
                            }
                        }
                        else
                        {
                            MessageBox.Show("error 2");
                        }

                    }
                    else
                    {
                        MessageBox.Show("error 1");
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

        private void button6_Click(object sender, EventArgs e)  //checkout button
        {
            this.Hide();        //go to cart form
            var form3 = new Checkout();
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

        private void button1_Click(object sender, EventArgs e)
        {
            panelLeft.Height = button1.Height;
            panelLeft.Top = button1.Top;

            this.Hide();        //go to home form
            var form3 = new Home();
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelLeft.Height = button3.Height;
            panelLeft.Top = button3.Top;

            this.Hide();        //go to support form
            var form3 = new Support();
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panelLeft.Height = button4.Height;
            panelLeft.Top = button4.Top;

            this.Hide();       
            var form9 = new Profile();
            form9.Closed += (s, args) => this.Close();
            form9.Show();
        }
    }
}
