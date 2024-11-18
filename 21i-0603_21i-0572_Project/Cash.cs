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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Cash : Form
    {
        double totale;
        double after_totale;
        public Cash()
        {
            totale = 0;
            after_totale = 0;
            InitializeComponent();
        }

        private void Cash_Load(object sender, EventArgs e)
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
                        textBox2.Text = TotalPricee;

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
                                after_totale = 0.95 * totale;
                                textBox1.Text = (after_totale).ToString();
                            }
                            else if (name == "Gold Membership")
                            {
                                after_totale = 0.90 * totale;
                                textBox1.Text = (after_totale).ToString();
                            }
                            else
                            {
                                after_totale = totale;
                                textBox1.Text = totale.ToString();
                            }
                        }
                        else
                        {
                            MessageBox.Show("discount not diplayed");
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

        private void button1_Click(object sender, EventArgs e)  //enter amount 
        {
            var amt = textBox3.Text;
            double _amt = (double)Decimal.Parse(amt);

            if ((_amt - after_totale) == 0)
            {
                MessageBox.Show("Payment accepted, thanks for shopping with us :)");
            }
            else if ((_amt - after_totale) > 0)
            {
                double rreturn = _amt - after_totale;
                MessageBox.Show("Amount returned: " + rreturn.ToString());
                MessageBox.Show("Payment accepted, thanks for shopping with us :)");
            }
            else
            {
                MessageBox.Show("Invalid amount entered");

                this.Hide();
                var form3 = new Cash();
                form3.Closed += (s, args) => this.Close();
                form3.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)  //place order button
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
    }
}
