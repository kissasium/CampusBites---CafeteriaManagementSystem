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
    public partial class report : Form
    {
        public report()
        {
            InitializeComponent();
        }

        private void back_button2_Click(object sender, EventArgs e)
        {
            this.Hide();        //close form and open cafe manager form
            var form4 = new Cafe_Manager();
            form4.Closed += (s, args) => this.Close();
            form4.Show();
        }


        private void report_Load_1(object sender, EventArgs e)
        {
            var connectionString = "Data Source=LAPTOP-S1HUQ0ID\\SQLEXPRESS;Database = CampusBites; Integrated Security=True";
            SqlConnection sqlconn = new SqlConnection(connectionString);
            sqlconn.Open();

            try
            {
                // Check if the view exists
                string checkViewQuery = "IF OBJECT_ID('vw_MostSoldItems', 'V') IS NOT NULL SELECT 1 ELSE SELECT 0";
                SqlCommand checkViewCmd = new SqlCommand(checkViewQuery, sqlconn);
                bool viewExists = (int)checkViewCmd.ExecuteScalar() == 1;

                // If the view doesn't exist, create it
                if (!viewExists)
                {
                    string viewQuery = @"
                    CREATE VIEW vw_MostSoldItems AS
                    SELECT
                        oi.CartID,
                        i.itemID,
                        i.itemName,
                        SUM(oi.Quantity) AS TotalSold
                    FROM
                        OrderHistory oi
                    JOIN
                        item i ON oi.itemID = i.itemID
                    GROUP BY
                        oi.CartID, i.itemID, i.itemName;
                    ";

                    SqlCommand createViewCmd = new SqlCommand(viewQuery, sqlconn);
                    createViewCmd.ExecuteNonQuery();
                }

                // Check if the view exists
                string checkViewQuery11 = "IF OBJECT_ID('vw_CustomerPurchaseSummary', 'V') IS NOT NULL SELECT 1 ELSE SELECT 0";
                SqlCommand checkViewCmd11 = new SqlCommand(checkViewQuery11, sqlconn);
                bool viewExists1 = (int)checkViewCmd11.ExecuteScalar() == 1;

                // If the view doesn't exist, create it
                if (!viewExists1)
                {
                    string viewQuery1 = @"
                        CREATE VIEW vw_CustomerPurchaseSummary AS
                        SELECT
                            oi.CustomerID AS CustomerID,
                            u.first_name AS FirstName,
                            u.last_name AS LastName,
                            u.email AS Email,
                            u.phonenumber AS PhoneNumber,
                            SUM(oi.Quantity) AS TotalPurchased
                        FROM
                            OrderHistory oi
                        JOIN
                            item i ON oi.itemID = i.itemID
                        JOIN
                            users u ON u.userID = oi.CustomerID
                        GROUP BY
                          oi.CustomerID, u.first_name, u.last_name, u.email, u.phonenumber;

                        ";


                    SqlCommand createViewCmd11 = new SqlCommand(viewQuery1, sqlconn);
                    createViewCmd11.ExecuteNonQuery();
                }

                // Select customer who bought the most sold item from the view
                string mostBoughtQuery = @"
                    SELECT TOP 1
                        CustomerID,
                        FirstName,
                        LastName,
                        Email,
                        PhoneNumber,
                        TotalPurchased
                    FROM
                        vw_CustomerPurchaseSummary
                    ORDER BY
                        TotalPurchased DESC;
                ";
                SqlDataAdapter mostBoughtDataAdapter = new SqlDataAdapter(mostBoughtQuery, sqlconn);
                DataTable mostBoughtDataTable = new DataTable();
                mostBoughtDataAdapter.Fill(mostBoughtDataTable);

                // Select customer who bought the least sold item from the view
                string leastBoughtQuery = @"
                    SELECT TOP 1
                        CustomerID,
                        FirstName,
                        LastName,
                        Email,
                        PhoneNumber,
                        TotalPurchased
                    FROM
                        vw_CustomerPurchaseSummary
                    ORDER BY
                        TotalPurchased;
                 ";
                SqlDataAdapter leastBoughtDataAdapter = new SqlDataAdapter(leastBoughtQuery, sqlconn);
                DataTable leastBoughtDataTable = new DataTable();
                leastBoughtDataAdapter.Fill(leastBoughtDataTable);

                // Check if the view exists
                string checkViewQuery111 = "IF OBJECT_ID('vw_CustomerPurchaseSummary', 'V') IS NOT NULL SELECT 1 ELSE SELECT 0";
                SqlCommand checkViewCmd111 = new SqlCommand(checkViewQuery111, sqlconn);
                bool viewExists11 = (int)checkViewCmd111.ExecuteScalar() == 1;

                // If the view doesn't exist, create it
                if (!viewExists11)
                {
                    string viewQuery11 = @"
                       CREATE VIEW vw_TopRevenueCustomers AS
                        SELECT 
	                        MAX(p.amount) AS Revenue,
	                        oc.CustomerID AS CustomerID,
	                        u.first_name AS FirstName,
                            u.last_name AS LastName,
                            u.email AS Email,
                            u.phonenumber AS PhoneNumber
                           FROM 
		                        payment p
	                        JOIN
		                        OrderCart oc ON oc.CartID = p.CartID
	                        JOIN 
		                        users u ON u.userID = oc.CustomerID	
                        GROUP BY 
	                        oc.CustomerID, u.first_name, u.last_name, u.email, u.phonenumber;	
                        ";


                    SqlCommand createViewCmd111 = new SqlCommand(viewQuery11, sqlconn);
                    createViewCmd111.ExecuteNonQuery();
                }

                // Select customer with highest revenue 
                string highestRevenuequery = @"
                       SELECT TOP 1
                        CustomerID,
                        FirstName,
                        LastName,
                        Email,
                        PhoneNumber,
                        Revenue
                    FROM
                        vw_TopRevenueCustomers
                    ORDER BY
                        Revenue DESC
                ";

                SqlDataAdapter RevenueAdapter = new SqlDataAdapter(highestRevenuequery, sqlconn);
                DataTable highestRevenueDataTable = new DataTable();
                RevenueAdapter.Fill(highestRevenueDataTable);

                // Set text color in grids to black
                dataGridView3.DefaultCellStyle.ForeColor = Color.Black;
                dataGridView4.DefaultCellStyle.ForeColor = Color.Black;
                dataGridView5.DefaultCellStyle.ForeColor = Color.Black;

                // Display the data in DataGridViews
                dataGridView3.DataSource = mostBoughtDataTable;
                dataGridView4.DataSource = leastBoughtDataTable;
                dataGridView5.DataSource = highestRevenueDataTable;

                // Select most sold item from the view
                string selectQuery = "SELECT TOP 1 * FROM vw_MostSoldItems ORDER BY TotalSold DESC";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(selectQuery, sqlconn);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                // Select least sold item from the view
                string selectQuery1 = "SELECT TOP 1 * FROM vw_MostSoldItems ORDER BY TotalSold";
                SqlDataAdapter dataAdapter1 = new SqlDataAdapter(selectQuery1, sqlconn);
                DataTable dataTable1 = new DataTable();
                dataAdapter1.Fill(dataTable1);

                //text color in grid set to black
                dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
                dataGridView2.DefaultCellStyle.ForeColor = Color.Black;
                // Display the data in a DataGridView
                dataGridView1.DataSource = dataTable;
                dataGridView2.DataSource = dataTable1;
            }
            catch (Exception ex)
            {
                // Log the error for debugging
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                sqlconn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();        //close form and open cafe manager form
            var form4 = new report_next();
            form4.Closed += (s, args) => this.Close();
            form4.Show();
        }
    }
}
