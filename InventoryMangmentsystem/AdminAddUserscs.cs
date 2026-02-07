using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace InventoryMangmentsystem
{
    public partial class AdminAddUserscs : UserControl
    {
        public AdminAddUserscs()
        {
            InitializeComponent();
            displayAllUsersData();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }

            displayAllUsersData();
        }

        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\inventory.mdf;Integrated Security=True;Connect Timeout=30");

        public void displayAllUsersData()
        {
            UsersData uData = new UsersData();
            List<UsersData> listData = uData.AllUsersData();
            dataGridView1.DataSource = listData;
        }

        private void addUsers_addBtn_Click(object sender, EventArgs e)
        {
            if (addUsers_username.Text == "" || addUsers_password.Text == ""
               || addUsers_role.SelectedIndex == -1 || addUsers_status.SelectedIndex == -1)
            {
                MessageBox.Show("Empty fields", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                            cmd.Parameters.AddWithValue("@name", addUsers_username.Text.Trim());
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable tabel = new DataTable();
                            adapter.Fill(tabel);
                            if (tabel.Rows.Count > 0)
                            {
                                MessageBox.Show("Username already exists", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO users(username,password,role,status,date) VALUES(@name,@password,@role,@status,@date)";
                                using (SqlCommand insertD = new SqlCommand(insertData, connect))
                                {
                                    insertD.Parameters.AddWithValue("@name", addUsers_username.Text.Trim());
                                    insertD.Parameters.AddWithValue("@role", addUsers_role.SelectedItem.ToString());
                                    insertD.Parameters.AddWithValue("@password", addUsers_password.Text.Trim());
                                    insertD.Parameters.AddWithValue("@status", addUsers_status.SelectedItem.ToString());
                                    DateTime today = DateTime.Today;
                                    insertD.Parameters.AddWithValue("@date", today);

                                    insertD.ExecuteNonQuery();
                                    clearFields();
                                    displayAllUsersData();
                                    MessageBox.Show("User added successfully!", "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Connection failed" + ex, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            return connect.State == ConnectionState.Closed;
        }

        public void clearFields()
        {
            addUsers_username.Text = "";
            addUsers_password.Text = "";
            addUsers_role.SelectedIndex = -1;
            addUsers_status.SelectedIndex = -1;
            getID = 0; // Reset the ID when clearing fields
        }

        private void addUsers_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void addUsers_updateBtn_Click(object sender, EventArgs e)
        {
            if (addUsers_username.Text == "" || addUsers_password.Text == ""
              || addUsers_role.SelectedIndex == -1 || addUsers_status.SelectedIndex == -1 || getID == 0)
            {
                MessageBox.Show("Please select a user to update or fill all fields", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to Update ID:" + getID + " ? ", "Confirmation Message ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (checkConnection())
                    {
                        try
                        {
                            connect.Open();

                            string updateData = "UPDATE users SET username = @name, password = @password, role = @role, status = @status, date = @date WHERE id = @id";

                            using (SqlCommand updateD = new SqlCommand(updateData, connect))
                            {
                                updateD.Parameters.AddWithValue("@name", addUsers_username.Text.Trim());
                                updateD.Parameters.AddWithValue("@role", addUsers_role.SelectedItem.ToString());
                                updateD.Parameters.AddWithValue("@password", addUsers_password.Text.Trim());
                                updateD.Parameters.AddWithValue("@status", addUsers_status.SelectedItem.ToString());
                                DateTime today = DateTime.Today;
                                updateD.Parameters.AddWithValue("@date", today);
                                updateD.Parameters.AddWithValue("@id", getID);

                                int rowsAffected = updateD.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    // Make sure to call the method that properly refreshes the data
                                    displayAllUsersData();
                                    clearFields();
                                    MessageBox.Show("User updated successfully!", "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("No rows were updated. Please check the user ID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Update failed: " + ex.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                }
            }
        }

        private int getID = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                getID = (int)row.Cells["ID"].Value; // Make sure to set the ID here

                string username = row.Cells[1].Value.ToString();
                string password = row.Cells[2].Value.ToString();
                string role = row.Cells[3].Value.ToString();
                string status = row.Cells[4].Value.ToString();

                addUsers_username.Text = username;
                addUsers_password.Text = password;
                addUsers_role.Text = role;
                addUsers_status.Text = status;
            }
        }

        private void addUsers_removeBtn_Click(object sender, EventArgs e)
        {
            // Check if a user is selected
            if (getID == 0)
            {
                MessageBox.Show("Please select a user to remove", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to remove User ID:" + getID + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (checkConnection())
                    {
                        try
                        {
                            connect.Open();
                            string deleteData = "DELETE FROM users WHERE id = @id";

                            using (SqlCommand deleteCmd = new SqlCommand(deleteData, connect))
                            {
                                deleteCmd.Parameters.AddWithValue("@id", getID);

                                int rowsAffected = deleteCmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    // Refresh the data grid
                                    displayAllUsersData();
                                    clearFields();
                                    MessageBox.Show("User removed successfully!", "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("No user was removed. Please check the user ID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Remove operation failed: " + ex.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                }
            }
        }

        private void AdminAddUserscs_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                
        }
    }
}