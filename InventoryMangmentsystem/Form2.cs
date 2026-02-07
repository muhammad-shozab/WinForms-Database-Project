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
using System.Security.Cryptography.X509Certificates;
namespace InventoryMangmentsystem
{
    public partial class Registerform2 : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\inventory.mdf;Integrated Security=True;Connect Timeout=30");
        public Registerform2()
        {
            InitializeComponent();
        }

        private void cross_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signin_label_Click(object sender, EventArgs e)
        {
          Form1  loginForm = new Form1();
            loginForm.Show();
            this.Hide(); 
        }

        private void signup_button_Click(object sender, EventArgs e)
        {
            if (register_name.Text == "" || register_password.Text == "" || register_cPassword.Text == "")
            {
                MessageBox.Show("Please fill all the fields", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (checkConnection())
                {
                    try
                    {
                        connect.Open();
                        string checkUsername = "SELECT * FROM users WHERE username=@name";
                        using (SqlCommand cmd = new SqlCommand(checkUsername, connect))
                        {
                            cmd.Parameters.AddWithValue("@name", register_name.Text.Trim());
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable tabel = new DataTable();
                            adapter.Fill(tabel);
                            if (tabel.Rows.Count > 0)
                            {
                                MessageBox.Show(register_name.Text.Trim() + " is already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if (register_password.Text.Length < 8)
                            {
                                MessageBox.Show("Invalid Password,at least 8 characters are needed", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if (register_password.Text.Trim() != register_cPassword.Text.Trim())
                            {
                                MessageBox.Show("Incorrect Password!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO users (username, password, role, status, date)" + "   VALUES (@name, @password, @role, @status, @date)";


                                using (SqlCommand insertD = new SqlCommand(insertData, connect))
                                {
                                    insertD.Parameters.AddWithValue("@name", register_name.Text.Trim());
                                    insertD.Parameters.AddWithValue("@password", register_password.Text.Trim());
                                    insertD.Parameters.AddWithValue("@role", "Cashier");
                                    insertD.Parameters.AddWithValue("@status", "Approval");
                                    DateTime today = DateTime.Now;
                                    insertD.Parameters.AddWithValue("@date", today);
                                    insertD.ExecuteNonQuery();
                                    MessageBox.Show("Registered successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Form1 loginForm = new Form1();
                                    loginForm.ShowDialog();
                                    this.Hide();
                                }
                            }
                        }


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Connection failed" + ex
                            , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }

                
                }
            }
        }

            public bool checkConnection()
        {
            if(connect.State == ConnectionState.Closed)
            {
               
                return true;
            }
            else
            {
              
                return false;
            }
        }

        private void register_showPass_CheckedChanged(object sender, EventArgs e)
        {
            register_password.PasswordChar = register_showPass.Checked ? '\0' : '*';
            register_cPassword.PasswordChar = register_showPass.Checked ? '\0' : '*';

        }

        private void Registerform2_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
