using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Runtime.Remoting.Messaging;

namespace InventoryMangmentsystem
{
    internal class customerData
    {
        SqlConnection connect
           = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\inventory.mdf;Integrated Security=True;Connect Timeout=30");

        public string CustomerID { get; set; }
        public string TotalPrice { get; set; }
        public string Amount { get; set; }
        public string Change { get; set; }
        public string Date { get; set; }

        public List<customerData> allTodaycustomers()
        {
            List<customerData> listData = new List<customerData>();

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    DateTime today = DateTime.Today;

                    // Updated query to handle date comparison properly
                    string SelectData = "SELECT * FROM Customers WHERE CAST(Order_date AS DATE) = @date";

                    using (SqlCommand cmd = new SqlCommand(SelectData, connect))
                    {
                        // THIS WAS MISSING - Add the parameter value
                        cmd.Parameters.AddWithValue("@date", today);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                customerData cData = new customerData();
                                cData.CustomerID = reader["customer_id"].ToString();
                                cData.TotalPrice = reader["total_price"].ToString();
                                cData.Amount = reader["amount"].ToString();
                                cData.Change = reader["change"].ToString();
                                cData.Date = reader["order_date"].ToString();
                                listData.Add(cData);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Changed to MessageBox for better debugging in WinForms
                    System.Windows.Forms.MessageBox.Show("Connection Failed: " + ex.Message);
                }
                finally
                {
                    connect.Close();
                }
            }

            return listData;
        }

        // Alternative method to get all customers (for testing)
        public List<customerData> allCustomers()
        {
            List<customerData> listData = new List<customerData>();

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    string SelectData = "SELECT * FROM Customers";

                    using (SqlCommand cmd = new SqlCommand(SelectData, connect))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                customerData cData = new customerData();
                                cData.CustomerID = reader["customer_id"].ToString();
                                cData.TotalPrice = reader["total_price"].ToString();
                                cData.Amount = reader["amount"].ToString();
                                cData.Change = reader["change"].ToString();
                                cData.Date = reader["order_date"].ToString();
                                listData.Add(cData);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Connection Failed: " + ex.Message);
                }
                finally
                {
                    connect.Close();
                }
            }

            return listData;
        }
    }
}