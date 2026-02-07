using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace InventoryMangmentsystem
{
    public partial class Form1 : Form
    {
        public static string username;  

        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\inventory.mdf;Integrated Security=True;Connect Timeout=30");
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Registerform2 regForm = new Registerform2();
            regForm.Show();

            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
   
        }

        private void cross_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_showPass_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = login_showPass.Checked ? '\0' : '*';
  
        }
        public bool checkConnection()
        {
            if (connect.State == ConnectionState.Closed)
            {

                return true;
            }
            else
            {

                return false;
            }
        }
            
        private void login_button_Click(object sender, EventArgs e)
        {
            if (checkConnection())
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT COUNT(*) FROM users WHERE username = @usern AND password = @pass AND status = @status";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@usern", login_username.Text.Trim());
                        cmd.Parameters.AddWithValue("@pass", login_password.Text.Trim());
                        cmd.Parameters.AddWithValue("@status", "Active");

                        int rowCount = (int)cmd.ExecuteScalar();

                        if (rowCount > 0)
                        {
                            string selectRole = "SELECT role FROM users WHERE username = @usern AND password = @pass";

                            using (SqlCommand getRole = new SqlCommand(selectRole, connect))
                            {
                                getRole.Parameters.AddWithValue("@usern", login_username.Text.Trim());
                                getRole.Parameters.AddWithValue("@pass", login_password.Text.Trim());

                                string userRole = getRole.ExecuteScalar() as string;

                                MessageBox.Show("Login successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                if (userRole == "Admin")
                                {

                                    MainForm mForm = new MainForm();
                                    mForm.Show();

                                    this.Hide();
                                }

                                else if (userRole == "Cashier")
                                {
                                    CashierMainForm cmForm = new CashierMainForm();
                                    cmForm.Show();
                                    this.Hide();
                                }
                            }
                        }
                            
                        else
                        {
                            MessageBox.Show("Incorrect username/password or there's no Admin's approval"
                                , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Connection failed!" + ex, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
            if (login_username.Text == "" || login_password.Text == "" )
            {
                MessageBox.Show("Please fill all the fields", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                
        }
    }
}
