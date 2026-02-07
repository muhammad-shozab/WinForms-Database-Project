using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InventoryMangmentsystem
{
    public partial class AdminDashboard : UserControl
    {

        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\inventory.mdf;Integrated Security=True;Connect Timeout=30");
        public AdminDashboard()
        {
            InitializeComponent();
            displayTodayCustomers();
            displayAllUsers();
            displayAllCustomers();
            displayTodaysIncome();
            displayTotalIncome();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }

            displayAllUsers();
            displayAllCustomers();
            displayTodaysIncome();
            displayTotalIncome();
        }


        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        public void displayTodayCustomers()
        {
            customerData cData = new customerData();
            List<customerData> listdata = cData.allTodaycustomers();

            dataGridView1.DataSource = listdata;
        }

        public bool checkConnection()
        {
            if( connect.State == ConnectionState.Closed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void displayAllUsers()
        {
            if (checkConnection())
            {
                try
                {
                    connect.Open();

                    string SelectData = "Select COUNT(id) FROM users Where status = @status";

                    using (SqlCommand cmd = new SqlCommand (SelectData, connect))
                    {

                        cmd.Parameters.AddWithValue("@status", "Active");

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            int count = Convert.ToInt32(reader[0]);
                            dashboard_AU.Text = count.ToString();
                        }
                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection failed : " + ex, "Error Message ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }




        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void displayAllCustomers()
        {
            if (checkConnection())
            {
                try
                {
                    connect.Open();

                    string SelectData = "Select COUNT(id) FROM customers";

                    using (SqlCommand cmd = new SqlCommand(SelectData, connect))
                    {

                        cmd.Parameters.AddWithValue("@status", "Active");

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            int count = Convert.ToInt32(reader[0]);
                            dashboard_AC.Text = count.ToString();
                        }
                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection failed : " + ex, "Error Message ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }
         public void displayTodaysIncome()
        {
            if (checkConnection())
            {
                try
                {
                    connect.Open();

                    string SelectData = "Select SUM(total_price) FROM customers WHERE order_date=@date";

                    using (SqlCommand cmd = new SqlCommand(SelectData, connect))
                    {

                        DateTime today = DateTime.Today;
                        string getToday = today.ToString("yyyy-MM-dd");



                        cmd.Parameters.AddWithValue("@date", getToday);
                        cmd.Parameters.AddWithValue("@status", "Active");

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {

                            object value = reader[0];
                            if(value != DBNull.Value)
                            {
                                int count = Convert.ToInt32(reader[0]);
                                dashboard_TI.Text = "$" + count.ToString("0.00");
                            }
                            reader.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection failed : " + ex, "Error Message ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }
        public void displayTotalIncome()
        {
            if (checkConnection())
            {
                try
                {
                    connect.Open();

                    string SelectData = "Select SUM(total_price) FROM customers";

                    using (SqlCommand cmd = new SqlCommand(SelectData, connect))
                    {


                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            object value = reader[0];
                            if (value != DBNull.Value)
                            {
                                int count = Convert.ToInt32(reader[0]);
                                dashboard_totalincome.Text = "$" + count.ToString("0.00");
                            }
                            reader.Close();
                            

                        }
                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection failed : " + ex, "Error Message ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
