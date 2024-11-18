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
    public partial class report_next : Form
    {
        public report_next()
        {
            InitializeComponent();
        }

        private void back_button2_Click(object sender, EventArgs e)
        {
            this.Hide();        //close form and open cafe manager form
            var form4 = new report();
            form4.Closed += (s, args) => this.Close();
            form4.Show();
        }

        private void report_next_Load(object sender, EventArgs e)
        {
            var connectionString = "Data Source=LAPTOP-S1HUQ0ID\\SQLEXPRESS;Database = CampusBites; Integrated Security=True";
            SqlConnection sqlconn = new SqlConnection(connectionString);
            sqlconn.Open();

            try
            {
                // Check if the view exists
                string checkViewQuery = "IF OBJECT_ID('vw_FeedbackSummary ', 'V') IS NOT NULL SELECT 1 ELSE SELECT 0";
                SqlCommand checkViewCmd = new SqlCommand(checkViewQuery, sqlconn);
                bool viewExists = (int)checkViewCmd.ExecuteScalar() == 1;

                // If the view doesn't exist, create it
                if (!viewExists)
                {
                    string viewQuery = @"
                    CREATE VIEW vw_FeedbackSummary AS
                    SELECT
                        f.id AS FeedbackID,
                        f.feedback AS Feedback,
                        u.userID AS CustomerID,
                        u.first_name AS FirstName,
                        u.last_name AS LastName,
                        u.email AS Email,
                        u.phonenumber AS PhoneNumber
                    FROM
                        Feedback f
                    JOIN
                        customer c ON f.customerID = c.customerID
                    JOIN
                        users u ON c.userID = u.userID;
                    ";

                    SqlCommand createViewCmd = new SqlCommand(viewQuery, sqlconn);
                    createViewCmd.ExecuteNonQuery();
                }

                // Retrieve data from the view
                string selectViewDataQuery = "SELECT * FROM vw_FeedbackSummary";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(selectViewDataQuery, sqlconn);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                // Bind the data to your DataGridView
                dataGridView1.DataSource = dataTable;
                dataGridView1.DefaultCellStyle.ForeColor = Color.Black;

                // Check if the view exists
                string checkViewQuery1 = "IF OBJECT_ID('vw_ItemsWithAvgPriceLessThan150', 'V') IS NOT NULL SELECT 1 ELSE SELECT 0";
                SqlCommand checkViewCmd1 = new SqlCommand(checkViewQuery1, sqlconn);
                bool viewExists1 = (int)checkViewCmd1.ExecuteScalar() == 1;

                // If the view doesn't exist, create it
                if (!viewExists1)
                {
                    string viewQuery1 = @"
                        CREATE VIEW vw_ItemsWithAvgPriceLessThan150 AS
                        SELECT i.itemID, i.itemName, 
                               AVG(i.price) as AvgItemPrice
                        FROM item i
                        JOIN menuHASitem mi ON i.itemID = mi.itemID
                        JOIN CartItem ci ON i.itemID = ci.ItemID
                        GROUP BY i.itemID, i.itemName
                        HAVING AVG(i.price) < 150;
                    ";

                    SqlCommand createViewCmd1 = new SqlCommand(viewQuery1, sqlconn);
                    createViewCmd1.ExecuteNonQuery();
                }

                // Retrieve data from the view
                string selectViewDataQuery1 = "SELECT * FROM vw_ItemsWithAvgPriceLessThan150";
                SqlDataAdapter dataAdapter1 = new SqlDataAdapter(selectViewDataQuery1, sqlconn);
                DataTable dataTable1 = new DataTable();
                dataAdapter1.Fill(dataTable1);

                // Bind the data to your DataGridView
                dataGridView2.DataSource = dataTable1; // Corrected to use dataTable1
                dataGridView2.DefaultCellStyle.ForeColor = Color.Black;

                // Check if the view exists
                string checkViewQuery12 = "IF OBJECT_ID('vw_CategoriesWithTotalAvailableItems', 'V') IS NOT NULL SELECT 1 ELSE SELECT 0";
                SqlCommand checkViewCmd12 = new SqlCommand(checkViewQuery12, sqlconn);
                bool viewExists12 = (int)checkViewCmd12.ExecuteScalar() == 1;

                // If the view doesn't exist, create it
                if (!viewExists12)
                {
                    string viewQuery12 = @"
                        CREATE VIEW vw_CategoriesWithTotalAvailableItems AS
                        SELECT DISTINCT c.categoryID, c.cname, mi.menuID, COUNT(DISTINCT ci.itemID) AS TotalAvailableItems
                        FROM category c
                        JOIN categoryHASitem ci ON ci.categoryID = c.categoryID
                        JOIN item i ON i.itemID = ci.itemID
                        JOIN menuHASitem mi ON mi.itemID = i.itemID 
                        GROUP BY c.categoryID, c.cname, mi.menuID
                        HAVING COUNT(i.itemID) < 5;
                    ";

                    SqlCommand createViewCmd12 = new SqlCommand(viewQuery12, sqlconn);
                    createViewCmd12.ExecuteNonQuery();
                }

                // Retrieve data from the view
                string selectViewDataQuery12 = "SELECT * FROM vw_CategoriesWithTotalAvailableItems";
                SqlDataAdapter dataAdapter12 = new SqlDataAdapter(selectViewDataQuery12, sqlconn);
                DataTable dataTable12 = new DataTable();
                dataAdapter12.Fill(dataTable12);

                // Bind the data to your DataGridView
                dataGridView3.DataSource = dataTable12;
                dataGridView3.DefaultCellStyle.ForeColor = Color.Black;

                // Check if the view exists
                string checkViewQuer = "IF OBJECT_ID('vw_ItemsWithMultipleCategories', 'V') IS NOT NULL SELECT 1 ELSE SELECT 0";
                SqlCommand checkViewCmda = new SqlCommand(checkViewQuer, sqlconn);
                bool viewExistsa = (int)checkViewCmda.ExecuteScalar() == 1;

                // If the view doesn't exist, create it
                if (!viewExistsa)
                {
                    string createViewQuerya = @"
                        CREATE VIEW vw_ItemsWithMultipleCategories AS
                        SELECT i.itemID, i.itemName, COUNT(DISTINCT ci.categoryID) as CategoryCount
                        FROM category c
                        JOIN categoryHASitem ci ON ci.categoryID = c.categoryID
                        JOIN item i on i.itemID = ci.ItemID
                        GROUP BY i.itemID, i.itemName
                        HAVING COUNT(DISTINCT ci.categoryID) > 1;
                    ";

                    SqlCommand createViewCmda = new SqlCommand(createViewQuerya, sqlconn);
                    createViewCmda.ExecuteNonQuery();
                }

                // Retrieve data from the view
                string selectViewDataQuerya = "SELECT * FROM vw_ItemsWithMultipleCategories";
                SqlDataAdapter dataAdaptera = new SqlDataAdapter(selectViewDataQuerya, sqlconn);
                DataTable dataTablea = new DataTable();
                dataAdaptera.Fill(dataTablea);

                // Bind the data to your DataGridView
                dataGridView4.DataSource = dataTablea;
                dataGridView4.DefaultCellStyle.ForeColor = Color.Black;

                // Check if the view exists
                string checkViewQueryb = "IF OBJECT_ID('vw_CategoryItemCount', 'V') IS NOT NULL SELECT 1 ELSE SELECT 0";
                SqlCommand checkViewCmdb = new SqlCommand(checkViewQueryb, sqlconn);
                bool viewExistsb = (int)checkViewCmdb.ExecuteScalar() == 1;

                // If the view doesn't exist, create it
                if (!viewExistsb)
                {
                    string createViewQueryb = @"
                    CREATE VIEW vw_CategoryItemCount AS
                    SELECT ci.categoryID, COUNT(ci.itemID) as ItemCount
                    FROM categoryHASitem ci
                    WHERE ci.categoryID IN (
                        SELECT c.categoryID
                        FROM categoryHASitem c
                        GROUP BY c.categoryID
                        HAVING COUNT(c.itemID) > 3
                    )
                    GROUP BY ci.categoryID;
                ";

                    SqlCommand createViewCmd = new SqlCommand(createViewQueryb, sqlconn);
                    createViewCmd.ExecuteNonQuery();
                }

                // Retrieve data from the view
                string selectViewDataQueryb = "SELECT * FROM vw_CategoryItemCount";
                SqlDataAdapter dataAdapterb = new SqlDataAdapter(selectViewDataQueryb, sqlconn);
                DataTable dataTableb = new DataTable();
                dataAdapterb.Fill(dataTableb);

                // Bind the data to your DataGridView
                dataGridView5.DataSource = dataTableb;
                dataGridView5.DefaultCellStyle.ForeColor = Color.Black;

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
    }
}
