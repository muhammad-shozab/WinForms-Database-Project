using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryMangmentsystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cross_button_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to exit?", "Conformation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form1 loginForm = new Form1();
                loginForm.Show();
                this.Hide();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Logout", "Conformation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form1 loginForm = new Form1();
                loginForm.Show();
                this.Hide();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = true;
            adminAddUserscs2.Visible = false;
            adminAddCategories2.Visible = false;
            adminAddProducts1.Visible = false;
            cashiercustomer1.Visible = false;

            AdminDashboard adForm = adminDashboard1 as AdminDashboard;

            if (adForm != null)
            {
                adForm.refreshData();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = false;
            adminAddUserscs2.Visible = false;
            adminAddCategories2.Visible = false;
            adminAddProducts1.Visible = true;
            cashiercustomer1.Visible = false;

            AdminAddProducts aapForm = adminAddProducts1 as AdminAddProducts;

            if (aapForm != null)
            {
                aapForm.refreshData();
            }
        }

        private void addUsers_btn_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = false;
            adminAddUserscs2.Visible = true;
            adminAddCategories2.Visible = false;
            adminAddProducts1.Visible = false;
            cashiercustomer1.Visible = false;

            AdminAddUserscs aauForm = adminAddUserscs2 as AdminAddUserscs;

            if (aauForm != null)
            {
                aauForm.refreshData();
            }
        }

        private void addCategories_btn_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = false;
            adminAddUserscs2.Visible = false;
            adminAddCategories2.Visible = true;
            adminAddProducts1.Visible = false;
            cashiercustomer1.Visible = false;

            AdminAddCategories aacForm = adminAddCategories2 as AdminAddCategories;

            if (aacForm != null)
            {
                aacForm.refreshData();
            }
        }

        private void customers_btn_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = false;
            adminAddUserscs2.Visible = false;
            adminAddCategories2.Visible = false;
            adminAddProducts1.Visible = false;
            cashiercustomer1.Visible = true;

            cashiercustomer ccfForm = cashiercustomer1 as cashiercustomer;

            if (ccfForm != null)
            {
                ccfForm.refreshData();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
