//WELCOME SCREEN
using System.Data.SqlClient;
namespace WinFormsApp1
{
    public partial class Login : Form
    {
        Beverage main;

        public string customerID;

        public Login()
        {
            customerID = string.Empty;
            InitializeComponent();
        }
        public void setcustomerID(string customerID)
        {
            this.customerID = customerID;
        }

        public string getcustomerID()
        {
            return customerID;
        }
        private void button1_Click(object sender, EventArgs e)  //login button
        {

            var email = emailtextBox.Text;
            var password = PasswordtextBox.Text;

            //admin
            //var email = "ted@hotmail.com";
            //var password = "ted123";

            //customer
            //var email = "hamna@gmail.com";
            //var password = "hamna123";

            //cook
            //var email = "mehmet@gmail.com";
            //var password = "mehmet123";

            //cashier
            //var email = "sophia@outlook.com";
            //var password = "sophia123";

            //employee
            //var email = "emily@outlook.com";
            //var password = "emily123";

            // cafe manager
            //var email = "sara@gmail.com";
            //var password = "sara123";

            var connectionString = "Data Source=LAPTOP-S1HUQ0ID\\SQLEXPRESS;Database = CampusBites; Integrated Security=True";
            SqlConnection sqlconn = new SqlConnection(connectionString);
            sqlconn.Open();

            try
            {
                string query = "Select email, password  from users where email = '" + email + "' and password = '" + password + "'";
                SqlCommand cmd = new SqlCommand(query, sqlconn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    MessageBox.Show("Welcome to CampusBites!");
                    reader.Close();

                    //get usertype
                    string query1 = "Select usertype from users where email = '" + email + "' ";
                    SqlCommand cmd1 = new SqlCommand(query1, sqlconn);
                    SqlDataReader reader1 = cmd1.ExecuteReader();

                    if (reader1.Read())
                    {
                        string usertype = reader1["usertype"].ToString();
                        reader1.Close();

                        if (usertype == "customer" || usertype == "Customer")
                        {
                            string query11 = "Select userID from users where email = '" + email + "'";
                            SqlCommand cmd11 = new SqlCommand(query11, sqlconn);
                            SqlDataReader reader11 = cmd11.ExecuteReader();

                            if (reader11.Read())
                            {
                                string userID = reader11["userID"].ToString();
                                reader11.Close();

                                // saveCustomerID();

                                //current customer
                                SqlCommand sqlcomm2 = new SqlCommand("insert into currentcustomer " +
                                   "values('" + userID + "')", sqlconn);

                                var ifError12 = sqlcomm2.ExecuteNonQuery();

                                if (ifError12 == 0)
                                {
                                    MessageBox.Show("Error");
                                }
                                else
                                {
                                    this.Hide();        //close login form and open home form
                                    var form3 = new Home();
                                    form3.Closed += (s, args) => this.Close();
                                    form3.Show();
                                    
                                }

                            }    

                        }
                        else if (usertype == "administrator" || usertype == "Administrator")
                        {
                            this.Hide();        //close login form and open admin page 
                            var form4 = new Admin();
                            form4.Closed += (s, args) => this.Close();
                            form4.Show();
                        }
                        else    //usertype == "Staff"
                        {
                            string query11e = "Select userID from users where email = '" + email + "'";
                            SqlCommand cmd11e = new SqlCommand(query11e, sqlconn);
                            SqlDataReader reader11e = cmd11e.ExecuteReader();

                            if (reader11e.Read())
                            {
                                string curr_userID = reader11e["userID"].ToString();
                                reader11e.Close();

                                //insert current staff member 
                                SqlCommand sqlcomm11 = new SqlCommand("insert into currentstaff " +
                                           "values('" + curr_userID + "' )", sqlconn);

                                var ifError11 = sqlcomm11.ExecuteNonQuery();
                                if (ifError11 == 0)
                                {
                                    MessageBox.Show("Error");
                                }

                                //find role of current staff member
                                string q1 = "Select s.srole from staff s join users u on u.userID = s.userID where u.email = '" + email + "' and u.password = '" + password + "'";
                                SqlCommand cmd11 = new SqlCommand(q1, sqlconn);
                                SqlDataReader reader11 = cmd11.ExecuteReader();

                                if (reader11.Read())
                                {
                                    string srole = reader11["srole"].ToString();
                                    reader11.Close();

                                    if (srole == "cook" || srole == "Cook")
                                    {
                                        this.Hide();        //close login form and open cook form
                                        var form4 = new Cook();
                                        form4.Closed += (s, args) => this.Close();
                                        form4.Show();

                                    }
                                    else if (srole == "cashier" || srole == "Cashier")
                                    {
                                        this.Hide();        //close login form and open Cashier form
                                        var form4 = new Cashier();
                                        form4.Closed += (s, args) => this.Close();
                                        form4.Show();

                                    }
                                    else if (srole == "cafe manager" || srole == "Cafe manager")
                                    {
                                        this.Hide();        //close login form and open Cafe_Manager form
                                        var form4 = new Cafe_Manager();
                                        form4.Closed += (s, args) => this.Close();
                                        form4.Show();
                                    }
                                    else
                                    {
                                        this.Hide();        //close login form and open Employee form
                                        var form44 = new Employee();
                                        form44.Closed += (s, args) => this.Close();
                                        form44.Show();
                                    }
                                    
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("errorrrrr");

                    }
                    reader1.Close();

                }
                else
                {
                    MessageBox.Show("incorrect email or password");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error!" + ex.Message);
            }
            finally
            {
                sqlconn.Close();
            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();        //close login form and open register form
            var form2 = new Signup();
            form2.Closed += (s, args) => this.Close();
            form2.Show();

        }

        //public void saveCustomerID()
        //{
        //    var email = emailtextBox.Text;

        //    var connectionString = "Data Source=LAPTOP-S1HUQ0ID\\SQLEXPRESS;Database = CampusBites; Integrated Security=True";
        //    SqlConnection sqlconn = new SqlConnection(connectionString);
        //    sqlconn.Open();

        //    try
        //    {
        //        string query = "Select userID from users where email = '" + email + "'";
        //        SqlCommand cmd = new SqlCommand(query, sqlconn);
        //        SqlDataReader reader = cmd.ExecuteReader();

        //        if (reader.Read())
        //        {
        //            string userID = reader["userID"].ToString();
        //            reader.Close();

        //            //get usertype
        //            string query1 = "Select usertype from users where email = '" + email + "' ";
        //            SqlCommand cmd1 = new SqlCommand(query1, sqlconn);
        //            SqlDataReader reader1 = cmd1.ExecuteReader();

        //            if (reader1.Read())
        //            {
        //                string usertype = reader1["usertype"].ToString();

        //                if (usertype == "customer" || usertype == "Customer")
        //                {
        //                    setcustomerID(userID);

        //                    main = new Beverage();
        //                    main.customerID = userID;

        //                    MessageBox.Show(main.customerID);
        //                    // return userID;


        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        MessageBox.Show("Error!" + ex.Message);
        //    }
        //    finally
        //    {
        //        sqlconn.Close();
        //    }

        //    // return null;
        //}
    }
}






