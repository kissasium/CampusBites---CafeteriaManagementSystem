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
    public partial class Meal : Form
    {
        public Meal()
        {
            InitializeComponent();
            panelLeft.Height = button2.Height;
            panelLeft.Top = button2.Top;
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

        private void button1_Click(object sender, EventArgs e)
        {
            panelLeft.Height = button1.Height;
            panelLeft.Top = button1.Top;

            this.Hide();        //go to home form
            var form3 = new Home();
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
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

            this.Hide();        //close form and go to checkout 
            var form9 = new Profile();
            form9.Closed += (s, args) => this.Close();
            form9.Show();
        }

        private void button5_Click(object sender, EventArgs e)  //BBQ WRAP
        {
            var connectionString = "Data Source=LAPTOP-S1HUQ0ID\\SQLEXPRESS;Database = CampusBites; Integrated Security=True";
            SqlConnection sqlconn = new SqlConnection(connectionString);
            sqlconn.Open();

            //insert current item 
            SqlCommand sqlcomm11 = new SqlCommand("insert into currentitem " +
                           "values('" + 10 + "' )", sqlconn);

            var ifError11 = sqlcomm11.ExecuteNonQuery();
            if (ifError11 == 0)
            {
                MessageBox.Show("Error");
            }

            //customer clicks on item -> a cart will be created for customer and item will be added to cart
            // if a cart already exisits -> total price will be updated -> total will not be lost 

            //get customerID
            string query11 = "Select TOP 1 customerID from currentcustomer order by id DESC";
            SqlCommand cmd11 = new SqlCommand(query11, sqlconn);
            SqlDataReader reader11 = cmd11.ExecuteReader();

            if (reader11.Read())
            {
                string customerID = reader11["customerID"].ToString();
                reader11.Close();

                //find if customer already has a cart 
                string query111 = "Select TOP 1 cartID from OrderCart where customerID = '" + customerID + "' order by CartID DESC";
                SqlCommand cmd111 = new SqlCommand(query111, sqlconn);
                SqlDataReader reader111 = cmd111.ExecuteReader();

                if (reader111.Read())
                {
                    //MessageBox.Show("Cart already exists");
                    string existing_cartID = reader111["cartID"].ToString();
                    reader111.Close();

                    //if item already exists then go to cart form
                    string q2 = "Select itemID from Cartitem where cartID = '" + existing_cartID + "' and itemID = 10";
                    SqlCommand q2cmd = new SqlCommand(q2, sqlconn);
                    SqlDataReader q2reader = q2cmd.ExecuteReader();

                    if (q2reader.Read())
                    {
                        string iitemID = q2reader["itemID"].ToString();
                        q2reader.Close();
                        //item exists in cart 
                        //so go directly to cart form

                        this.Hide();        //go to  cart form directly then -> do not reset price in ordercart table
                        var form8 = new Cart();
                        form8.Closed += (s, args) => this.Close();
                        form8.Show();
                    }
                    else    //item does not exist in cart so insert in cartitem
                    {
                        q2reader.Close();

                        //now add coke to cart
                        SqlCommand sqlcomm22 = new SqlCommand("insert into CartItem " +
                                "values('" + existing_cartID + "', '" + 10 + "','" + 0 + "', '" + 180 + "')", sqlconn);

                        var ifError1e2 = sqlcomm22.ExecuteNonQuery();
                        if (ifError1e2 == 0)
                        {
                            MessageBox.Show("Error");
                        }
                        else
                        {
                            this.Hide();        //go to  cart form
                            var form = new Cart();
                            form.Closed += (s, args) => this.Close();
                            form.Show();
                        }

                    }
                }
                else     //cart does not exist 
                {
                    reader111.Close();

                    //create cart for customer 
                    SqlCommand sqlcomm1 = new SqlCommand("insert into OrderCart " +
                                "values('" + customerID + "', '" + DateTime.Now + "', '" + 0 + "')", sqlconn);
                    var ifError1 = sqlcomm1.ExecuteNonQuery();
                    if (ifError1 == 0)
                    {
                        MessageBox.Show("Error in creating Cart");
                    }
                    else
                    {
                        //find cartID
                        string query1 = "Select CartID from OrderCart where customerID = '" + customerID + "'";
                        SqlCommand cmd1 = new SqlCommand(query1, sqlconn);
                        SqlDataReader reader1 = cmd1.ExecuteReader();

                        if (reader1.Read())
                        {
                            string cartID = reader1["CartID"].ToString();
                            reader1.Close();


                            //find ItemID
                            string query2 = "Select itemID from item where itemName = 'BBQ Wrap' ";
                            SqlCommand cmd2 = new SqlCommand(query2, sqlconn);
                            SqlDataReader reader2 = cmd2.ExecuteReader();

                            if (reader2.Read())
                            {
                                string itemID = reader2["itemID"].ToString();
                                reader2.Close();

                                //now add milo to cart
                                SqlCommand sqlcomm2 = new SqlCommand("insert into CartItem " +
                                        "values('" + cartID + "', '" + itemID + "','" + 0 + "', '" + 180 + "')", sqlconn);

                                var ifError12 = sqlcomm2.ExecuteNonQuery();
                                if (ifError12 == 0)
                                {
                                    MessageBox.Show("Error");
                                }
                                else
                                {

                                    this.Hide();        //go to  cart form
                                    var form8 = new Cart();
                                    form8.Closed += (s, args) => this.Close();
                                    form8.Show();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Error 1");
                            }

                        }
                        else
                        {
                            MessageBox.Show("Error 2");
                        }
                    }

                }
            }

        }

        private void pulao_button6_Click(object sender, EventArgs e)
        {
            var connectionString = "Data Source=LAPTOP-S1HUQ0ID\\SQLEXPRESS;Database = CampusBites; Integrated Security=True";
            SqlConnection sqlconn = new SqlConnection(connectionString);
            sqlconn.Open();

            //insert current item 
            SqlCommand sqlcomm11 = new SqlCommand("insert into currentitem " +
                           "values('" + 11 + "' )", sqlconn);

            var ifError11 = sqlcomm11.ExecuteNonQuery();
            if (ifError11 == 0)
            {
                MessageBox.Show("Error");
            }

            //customer clicks on item -> a cart will be created for customer and item will be added to cart
            // if a cart already exisits -> total price will be updated -> total will not be lost 

            //get customerID
            string query11 = "Select TOP 1 customerID from currentcustomer order by id DESC";
            SqlCommand cmd11 = new SqlCommand(query11, sqlconn);
            SqlDataReader reader11 = cmd11.ExecuteReader();

            if (reader11.Read())
            {
                string customerID = reader11["customerID"].ToString();
                reader11.Close();

                //find if customer already has a cart 
                string query111 = "Select TOP 1 cartID from OrderCart where customerID = '" + customerID + "' order by CartID DESC";
                SqlCommand cmd111 = new SqlCommand(query111, sqlconn);
                SqlDataReader reader111 = cmd111.ExecuteReader();

                if (reader111.Read())
                {
                    //MessageBox.Show("Cart already exists");
                    string existing_cartID = reader111["cartID"].ToString();
                    reader111.Close();

                    //if item already exists then go to cart form
                    string q2 = "Select itemID from Cartitem where cartID = '" + existing_cartID + "' and itemID = 11";
                    SqlCommand q2cmd = new SqlCommand(q2, sqlconn);
                    SqlDataReader q2reader = q2cmd.ExecuteReader();

                    if (q2reader.Read())
                    {
                        string iitemID = q2reader["itemID"].ToString();
                        q2reader.Close();
                        //item exists in cart 
                        //so go directly to cart form

                        this.Hide();        //go to  cart form directly then -> do not reset price in ordercart table
                        var form8 = new Cart();
                        form8.Closed += (s, args) => this.Close();
                        form8.Show();
                    }
                    else    //item does not exist in cart so insert in cartitem
                    {
                        q2reader.Close();

                        //now add coke to cart
                        SqlCommand sqlcomm22 = new SqlCommand("insert into CartItem " +
                                "values('" + existing_cartID + "', '" + 11 + "','" + 0 + "', '" + 220 + "')", sqlconn);

                        var ifError1e2 = sqlcomm22.ExecuteNonQuery();
                        if (ifError1e2 == 0)
                        {
                            MessageBox.Show("Error");
                        }
                        else
                        {

                            this.Hide();        //go to  cart form
                            var form = new Cart();
                            form.Closed += (s, args) => this.Close();
                            form.Show();
                        }

                    }
                }
                else     //cart does not exist 
                {
                    reader111.Close();

                    //create cart for customer 
                    SqlCommand sqlcomm1 = new SqlCommand("insert into OrderCart " +
                                "values('" + customerID + "', '" + DateTime.Now + "', '" + 0 + "')", sqlconn);
                    var ifError1 = sqlcomm1.ExecuteNonQuery();
                    if (ifError1 == 0)
                    {
                        MessageBox.Show("Error in creating Cart");
                    }
                    else
                    {
                        //find cartID
                        string query1 = "Select CartID from OrderCart where customerID = '" + customerID + "'";
                        SqlCommand cmd1 = new SqlCommand(query1, sqlconn);
                        SqlDataReader reader1 = cmd1.ExecuteReader();

                        if (reader1.Read())
                        {
                            string cartID = reader1["CartID"].ToString();
                            reader1.Close();


                            //find ItemID
                            string query2 = "Select itemID from item where itemName = 'Chicken Pulao' ";
                            SqlCommand cmd2 = new SqlCommand(query2, sqlconn);
                            SqlDataReader reader2 = cmd2.ExecuteReader();

                            if (reader2.Read())
                            {
                                string itemID = reader2["itemID"].ToString();
                                reader2.Close();

                                //now add milo to cart
                                SqlCommand sqlcomm2 = new SqlCommand("insert into CartItem " +
                                        "values('" + cartID + "', '" + itemID + "','" + 0 + "', '" + 220 + "')", sqlconn);

                                var ifError12 = sqlcomm2.ExecuteNonQuery();
                                if (ifError12 == 0)
                                {
                                    MessageBox.Show("Error");
                                }
                                else
                                {

                                    this.Hide();        //go to  cart form
                                    var form8 = new Cart();
                                    form8.Closed += (s, args) => this.Close();
                                    form8.Show();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Error 1");
                            }

                        }
                        else
                        {
                            MessageBox.Show("Error 2");
                        }
                    }

                }
            }
        }

        private void krispy_button10_Click(object sender, EventArgs e)
        {
            var connectionString = "Data Source=LAPTOP-S1HUQ0ID\\SQLEXPRESS;Database = CampusBites; Integrated Security=True";
            SqlConnection sqlconn = new SqlConnection(connectionString);
            sqlconn.Open();

            //insert current item 
            SqlCommand sqlcomm11 = new SqlCommand("insert into currentitem " +
                           "values('" + 12 + "' )", sqlconn);

            var ifError11 = sqlcomm11.ExecuteNonQuery();
            if (ifError11 == 0)
            {
                MessageBox.Show("Error");
            }

            //customer clicks on item -> a cart will be created for customer and item will be added to cart
            // if a cart already exisits -> total price will be updated -> total will not be lost 

            //get customerID
            string query11 = "Select TOP 1 customerID from currentcustomer order by id DESC";
            SqlCommand cmd11 = new SqlCommand(query11, sqlconn);
            SqlDataReader reader11 = cmd11.ExecuteReader();

            if (reader11.Read())
            {
                string customerID = reader11["customerID"].ToString();
                reader11.Close();

                //find if customer already has a cart 
                string query111 = "Select TOP 1 cartID from OrderCart where customerID = '" + customerID + "' order by CartID DESC";
                SqlCommand cmd111 = new SqlCommand(query111, sqlconn);
                SqlDataReader reader111 = cmd111.ExecuteReader();

                if (reader111.Read())
                {
                    //MessageBox.Show("Cart already exists");
                    string existing_cartID = reader111["cartID"].ToString();
                    reader111.Close();

                    //if item already exists then go to cart form
                    string q2 = "Select itemID from Cartitem where cartID = '" + existing_cartID + "' and itemID = 12";
                    SqlCommand q2cmd = new SqlCommand(q2, sqlconn);
                    SqlDataReader q2reader = q2cmd.ExecuteReader();

                    if (q2reader.Read())
                    {
                        string iitemID = q2reader["itemID"].ToString();
                        q2reader.Close();
                        //item exists in cart 
                        //so go directly to cart form

                        this.Hide();        //go to  cart form directly then -> do not reset price in ordercart table
                        var form8 = new Cart();
                        form8.Closed += (s, args) => this.Close();
                        form8.Show();
                    }
                    else    //item does not exist in cart so insert in cartitem
                    {
                        q2reader.Close();

                        //now add coke to cart
                        SqlCommand sqlcomm22 = new SqlCommand("insert into CartItem " +
                                "values('" + existing_cartID + "', '" + 12 + "','" + 0 + "', '" + 220 + "')", sqlconn);

                        var ifError1e2 = sqlcomm22.ExecuteNonQuery();
                        if (ifError1e2 == 0)
                        {
                            MessageBox.Show("Error");
                        }
                        else
                        {

                            this.Hide();        //go to  cart form
                            var form = new Cart();
                            form.Closed += (s, args) => this.Close();
                            form.Show();
                        }

                    }
                }
                else     //cart does not exist 
                {
                    reader111.Close();

                    //create cart for customer 
                    SqlCommand sqlcomm1 = new SqlCommand("insert into OrderCart " +
                                "values('" + customerID + "', '" + DateTime.Now + "', '" + 0 + "')", sqlconn);
                    var ifError1 = sqlcomm1.ExecuteNonQuery();
                    if (ifError1 == 0)
                    {
                        MessageBox.Show("Error in creating Cart");
                    }
                    else
                    {
                        //find cartID
                        string query1 = "Select CartID from OrderCart where customerID = '" + customerID + "'";
                        SqlCommand cmd1 = new SqlCommand(query1, sqlconn);
                        SqlDataReader reader1 = cmd1.ExecuteReader();

                        if (reader1.Read())
                        {
                            string cartID = reader1["CartID"].ToString();
                            reader1.Close();

                            //find ItemID
                            string query2 = "Select itemID from item where itemName = 'Krispy Deal' ";
                            SqlCommand cmd2 = new SqlCommand(query2, sqlconn);
                            SqlDataReader reader2 = cmd2.ExecuteReader();

                            if (reader2.Read())
                            {
                                string itemID = reader2["itemID"].ToString();
                                reader2.Close();

                                //now add milo to cart
                                SqlCommand sqlcomm2 = new SqlCommand("insert into CartItem " +
                                        "values('" + cartID + "', '" + itemID + "','" + 0 + "', '" + 220 + "')", sqlconn);

                                var ifError12 = sqlcomm2.ExecuteNonQuery();
                                if (ifError12 == 0)
                                {
                                    MessageBox.Show("Error");
                                }
                                else
                                {

                                    this.Hide();        //go to  cart form
                                    var form8 = new Cart();
                                    form8.Closed += (s, args) => this.Close();
                                    form8.Show();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Error 1");
                            }

                        }
                        else
                        {
                            MessageBox.Show("Error 2");
                        }
                    }

                }
            }
        }

        private void fajita_button11_Click(object sender, EventArgs e)
        {
            var connectionString = "Data Source=LAPTOP-S1HUQ0ID\\SQLEXPRESS;Database = CampusBites; Integrated Security=True";
            SqlConnection sqlconn = new SqlConnection(connectionString);
            sqlconn.Open();

            //insert current item 
            SqlCommand sqlcomm11 = new SqlCommand("insert into currentitem " +
                           "values('" + 13 + "' )", sqlconn);

            var ifError11 = sqlcomm11.ExecuteNonQuery();
            if (ifError11 == 0)
            {
                MessageBox.Show("Error");
            }

            //customer clicks on item -> a cart will be created for customer and item will be added to cart
            // if a cart already exisits -> total price will be updated -> total will not be lost 

            //get customerID
            string query11 = "Select TOP 1 customerID from currentcustomer order by id DESC";
            SqlCommand cmd11 = new SqlCommand(query11, sqlconn);
            SqlDataReader reader11 = cmd11.ExecuteReader();

            if (reader11.Read())
            {
                string customerID = reader11["customerID"].ToString();
                reader11.Close();

                //find if customer already has a cart 
                string query111 = "Select TOP 1 cartID from OrderCart where customerID = '" + customerID + "' order by CartID DESC";
                SqlCommand cmd111 = new SqlCommand(query111, sqlconn);
                SqlDataReader reader111 = cmd111.ExecuteReader();

                if (reader111.Read())
                {
                   // MessageBox.Show("Cart already exists");
                    string existing_cartID = reader111["cartID"].ToString();
                    reader111.Close();

                    //if item already exists then go to cart form
                    string q2 = "Select itemID from Cartitem where cartID = '" + existing_cartID + "' and itemID = 13";
                    SqlCommand q2cmd = new SqlCommand(q2, sqlconn);
                    SqlDataReader q2reader = q2cmd.ExecuteReader();

                    if (q2reader.Read())
                    {
                        string iitemID = q2reader["itemID"].ToString();
                        q2reader.Close();
                        //item exists in cart 
                        //so go directly to cart form

                        this.Hide();        //go to  cart form directly then -> do not reset price in ordercart table
                        var form8 = new Cart();
                        form8.Closed += (s, args) => this.Close();
                        form8.Show();
                    }
                    else    //item does not exist in cart so insert in cartitem
                    {
                        q2reader.Close();

                        //now add coke to cart
                        SqlCommand sqlcomm22 = new SqlCommand("insert into CartItem " +
                                "values('" + existing_cartID + "', '" + 13 + "','" + 0 + "', '" + 180 + "')", sqlconn);

                        var ifError1e2 = sqlcomm22.ExecuteNonQuery();
                        if (ifError1e2 == 0)
                        {
                            MessageBox.Show("Error");
                        }
                        else
                        {

                            this.Hide();        //go to  cart form
                            var form = new Cart();
                            form.Closed += (s, args) => this.Close();
                            form.Show();
                        }

                    }
                }
                else     //cart does not exist 
                {
                    reader111.Close();

                    //create cart for customer 
                    SqlCommand sqlcomm1 = new SqlCommand("insert into OrderCart " +
                                "values('" + customerID + "', '" + DateTime.Now + "', '" + 0 + "')", sqlconn);
                    var ifError1 = sqlcomm1.ExecuteNonQuery();
                    if (ifError1 == 0)
                    {
                        MessageBox.Show("Error in creating Cart");
                    }
                    else
                    {
                        //find cartID
                        string query1 = "Select CartID from OrderCart where customerID = '" + customerID + "'";
                        SqlCommand cmd1 = new SqlCommand(query1, sqlconn);
                        SqlDataReader reader1 = cmd1.ExecuteReader();

                        if (reader1.Read())
                        {
                            string cartID = reader1["CartID"].ToString();
                            reader1.Close();

                            //find ItemID
                            string query2 = "Select itemID from item where itemName = 'Chicken Fajita' ";
                            SqlCommand cmd2 = new SqlCommand(query2, sqlconn);
                            SqlDataReader reader2 = cmd2.ExecuteReader();

                            if (reader2.Read())
                            {
                                string itemID = reader2["itemID"].ToString();
                                reader2.Close();

                                //now add milo to cart
                                SqlCommand sqlcomm2 = new SqlCommand("insert into CartItem " +
                                        "values('" + cartID + "', '" + itemID + "','" + 0 + "', '" + 180 + "')", sqlconn);

                                var ifError12 = sqlcomm2.ExecuteNonQuery();
                                if (ifError12 == 0)
                                {
                                    MessageBox.Show("Error");
                                }
                                else
                                {

                                    this.Hide();        //go to  cart form
                                    var form8 = new Cart();
                                    form8.Closed += (s, args) => this.Close();
                                    form8.Show();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Error 1");
                            }

                        }
                        else
                        {
                            MessageBox.Show("Error 2");
                        }
                    }

                }
            }
        }

        private void biryani_button7_Click(object sender, EventArgs e)
        {
            var connectionString = "Data Source=LAPTOP-S1HUQ0ID\\SQLEXPRESS;Database = CampusBites; Integrated Security=True";
            SqlConnection sqlconn = new SqlConnection(connectionString);
            sqlconn.Open();

            //insert current item 
            SqlCommand sqlcomm11 = new SqlCommand("insert into currentitem " +
                           "values('" + 14 + "' )", sqlconn);

            var ifError11 = sqlcomm11.ExecuteNonQuery();
            if (ifError11 == 0)
            {
                MessageBox.Show("Error");
            }

            //customer clicks on item -> a cart will be created for customer and item will be added to cart
            // if a cart already exisits -> total price will be updated -> total will not be lost 

            //get customerID
            string query11 = "Select TOP 1 customerID from currentcustomer order by id DESC";
            SqlCommand cmd11 = new SqlCommand(query11, sqlconn);
            SqlDataReader reader11 = cmd11.ExecuteReader();

            if (reader11.Read())
            {
                string customerID = reader11["customerID"].ToString();
                reader11.Close();

                //find if customer already has a cart 
                string query111 = "Select TOP 1 cartID from OrderCart where customerID = '" + customerID + "' order by CartID DESC";
                SqlCommand cmd111 = new SqlCommand(query111, sqlconn);
                SqlDataReader reader111 = cmd111.ExecuteReader();

                if (reader111.Read())
                {
                   // MessageBox.Show("Cart already exists");
                    string existing_cartID = reader111["cartID"].ToString();
                    reader111.Close();

                    //if item already exists then go to cart form
                    string q2 = "Select itemID from Cartitem where cartID = '" + existing_cartID + "' and itemID = 14";
                    SqlCommand q2cmd = new SqlCommand(q2, sqlconn);
                    SqlDataReader q2reader = q2cmd.ExecuteReader();

                    if (q2reader.Read())
                    {
                        string iitemID = q2reader["itemID"].ToString();
                        q2reader.Close();
                        //item exists in cart 
                        //so go directly to cart form

                        this.Hide();        //go to  cart form directly then -> do not reset price in ordercart table
                        var form8 = new Cart();
                        form8.Closed += (s, args) => this.Close();
                        form8.Show();
                    }
                    else    //item does not exist in cart so insert in cartitem
                    {
                        q2reader.Close();

                        //now add coke to cart
                        SqlCommand sqlcomm22 = new SqlCommand("insert into CartItem " +
                                "values('" + existing_cartID + "', '" + 14 + "','" + 0 + "', '" + 220 + "')", sqlconn);

                        var ifError1e2 = sqlcomm22.ExecuteNonQuery();
                        if (ifError1e2 == 0)
                        {
                            MessageBox.Show("Error");
                        }
                        else
                        {

                            this.Hide();        //go to  cart form
                            var form = new Cart();
                            form.Closed += (s, args) => this.Close();
                            form.Show();
                        }

                    }
                }
                else     //cart does not exist 
                {
                    reader111.Close();

                    //create cart for customer 
                    SqlCommand sqlcomm1 = new SqlCommand("insert into OrderCart " +
                                "values('" + customerID + "', '" + DateTime.Now + "', '" + 0 + "')", sqlconn);
                    var ifError1 = sqlcomm1.ExecuteNonQuery();
                    if (ifError1 == 0)
                    {
                        MessageBox.Show("Error in creating Cart");
                    }
                    else
                    {
                        //find cartID
                        string query1 = "Select CartID from OrderCart where customerID = '" + customerID + "'";
                        SqlCommand cmd1 = new SqlCommand(query1, sqlconn);
                        SqlDataReader reader1 = cmd1.ExecuteReader();

                        if (reader1.Read())
                        {
                            string cartID = reader1["CartID"].ToString();
                            reader1.Close();


                            //find ItemID
                            string query2 = "Select itemID from item where itemName = 'Chicken Biryani' ";
                            SqlCommand cmd2 = new SqlCommand(query2, sqlconn);
                            SqlDataReader reader2 = cmd2.ExecuteReader();

                            if (reader2.Read())
                            {
                                string itemID = reader2["itemID"].ToString();
                                reader2.Close();

                                //now add milo to cart
                                SqlCommand sqlcomm2 = new SqlCommand("insert into CartItem " +
                                        "values('" + cartID + "', '" + itemID + "','" + 0 + "', '" + 220 + "')", sqlconn);

                                var ifError12 = sqlcomm2.ExecuteNonQuery();
                                if (ifError12 == 0)
                                {
                                    MessageBox.Show("Error");
                                }
                                else
                                {

                                    this.Hide();        //go to  cart form
                                    var form8 = new Cart();
                                    form8.Closed += (s, args) => this.Close();
                                    form8.Show();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Error 1");
                            }

                        }
                        else
                        {
                            MessageBox.Show("Error 2");
                        }
                    }

                }
            }
        }

        private void friends_button8_Click(object sender, EventArgs e)
        {
            var connectionString = "Data Source=LAPTOP-S1HUQ0ID\\SQLEXPRESS;Database = CampusBites; Integrated Security=True";
            SqlConnection sqlconn = new SqlConnection(connectionString);
            sqlconn.Open();

            //insert current item -> Milo
            SqlCommand sqlcomm11 = new SqlCommand("insert into currentitem " +
                           "values('" + 15 + "' )", sqlconn);

            var ifError11 = sqlcomm11.ExecuteNonQuery();
            if (ifError11 == 0)
            {
                MessageBox.Show("Error");
            }

            //customer clicks on item -> a cart will be created for customer and item will be added to cart
            // if a cart already exisits -> total price will be updated -> total will not be lost 

            //get customerID
            string query11 = "Select TOP 1 customerID from currentcustomer order by id DESC";
            SqlCommand cmd11 = new SqlCommand(query11, sqlconn);
            SqlDataReader reader11 = cmd11.ExecuteReader();

            if (reader11.Read())
            {
                string customerID = reader11["customerID"].ToString();
                reader11.Close();

                //find if customer already has a cart 
                string query111 = "Select TOP 1 cartID from OrderCart where customerID = '" + customerID + "' order by CartID DESC";
                SqlCommand cmd111 = new SqlCommand(query111, sqlconn);
                SqlDataReader reader111 = cmd111.ExecuteReader();

                if (reader111.Read())
                {
                    //MessageBox.Show("Cart already exists");
                    string existing_cartID = reader111["cartID"].ToString();
                    reader111.Close();

                    //if item already exists then go to cart form
                    string q2 = "Select itemID from Cartitem where cartID = '" + existing_cartID + "' and itemID = 15";
                    SqlCommand q2cmd = new SqlCommand(q2, sqlconn);
                    SqlDataReader q2reader = q2cmd.ExecuteReader();

                    if (q2reader.Read())
                    {
                        string iitemID = q2reader["itemID"].ToString();
                        q2reader.Close();
                        //item exists in cart 
                        //so go directly to cart form

                        this.Hide();        //go to  cart form directly then -> do not reset price in ordercart table
                        var form8 = new Cart();
                        form8.Closed += (s, args) => this.Close();
                        form8.Show();
                    }
                    else    //item does not exist in cart so insert in cartitem
                    {
                        q2reader.Close();

                        //now add coke to cart
                        SqlCommand sqlcomm22 = new SqlCommand("insert into CartItem " +
                                "values('" + existing_cartID + "', '" + 15 + "','" + 0 + "', '" + 440 + "')", sqlconn);

                        var ifError1e2 = sqlcomm22.ExecuteNonQuery();
                        if (ifError1e2 == 0)
                        {
                            MessageBox.Show("Error");
                        }
                        else
                        {

                            this.Hide();        //go to  cart form
                            var form = new Cart();
                            form.Closed += (s, args) => this.Close();
                            form.Show();
                        }

                    }
                }
                else     //cart does not exist 
                {
                    reader111.Close();

                    //create cart for customer 
                    SqlCommand sqlcomm1 = new SqlCommand("insert into OrderCart " +
                                "values('" + customerID + "', '" + DateTime.Now + "', '" + 0 + "')", sqlconn);
                    var ifError1 = sqlcomm1.ExecuteNonQuery();
                    if (ifError1 == 0)
                    {
                        MessageBox.Show("Error in creating Cart");
                    }
                    else
                    {
                        //find cartID
                        string query1 = "Select CartID from OrderCart where customerID = '" + customerID + "'";
                        SqlCommand cmd1 = new SqlCommand(query1, sqlconn);
                        SqlDataReader reader1 = cmd1.ExecuteReader();

                        if (reader1.Read())
                        {
                            string cartID = reader1["CartID"].ToString();
                            reader1.Close();


                            //find ItemID
                            string query2 = "Select itemID from item where itemName = 'Friends Deal' ";
                            SqlCommand cmd2 = new SqlCommand(query2, sqlconn);
                            SqlDataReader reader2 = cmd2.ExecuteReader();

                            if (reader2.Read())
                            {
                                string itemID = reader2["itemID"].ToString();
                                reader2.Close();

                                //now add milo to cart
                                SqlCommand sqlcomm2 = new SqlCommand("insert into CartItem " +
                                        "values('" + cartID + "', '" + itemID + "','" + 0 + "', '" + 440 + "')", sqlconn);

                                var ifError12 = sqlcomm2.ExecuteNonQuery();
                                if (ifError12 == 0)
                                {
                                    MessageBox.Show("Error");
                                }
                                else
                                {

                                    this.Hide();        //go to  cart form
                                    var form8 = new Cart();
                                    form8.Closed += (s, args) => this.Close();
                                    form8.Show();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Error 1");
                            }

                        }
                        else
                        {
                            MessageBox.Show("Error 2");
                        }
                    }

                }
            }
        }
    }
}