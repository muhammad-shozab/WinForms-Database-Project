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
    public partial class CashierMainForm : Form
    {
        public CashierMainForm()
        {
            InitializeComponent();
            
        }

        

        private void noaccount_label_Click(object sender, EventArgs e)
        {

        }

        private void cross_button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Conformation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form1 loginForm = new Form1();
                loginForm.Show();
                this.Hide();
            }
        }


        private void loggout_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?",
                "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form1 loginform = new Form1();
                loginform.Show();

                this.Hide();
            }
        }

      
        private void cashierOrder1_Load(object sender, EventArgs e)
        {

        }
        private void close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Exit?",
              "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = true;
            adminAddProducts1.Visible = false;
            cashiercustomer1.Visible = false;
            cashierOrder1.Visible = false;

            AdminDashboard adForm = adminDashboard1 as AdminDashboard;

            if (adForm != null)
            {
                adForm.refreshData();
            }

        }

        private void addproduct_btn_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = false;
            adminAddProducts1.Visible = true;
            cashiercustomer1.Visible = false;
            cashierOrder1.Visible = false;

            AdminAddProducts aapForm = adminAddProducts1 as AdminAddProducts;

            if (aapForm != null)
            {
                aapForm.refreshData();
            }
        }

        private void customers_btn_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = false;
            adminAddProducts1.Visible = false;
            cashiercustomer1.Visible = true;
            cashierOrder1.Visible = false;

            cashiercustomer ccfForm = cashiercustomer1 as cashiercustomer;

            if (ccfForm != null)
            {
                ccfForm.refreshData();
            }
        }

        private void order_btn_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = false;
            adminAddProducts1.Visible = false;
            cashiercustomer1.Visible = false;
            cashierOrder1.Visible = true;

            CashierOrder coForm = cashierOrder1 as CashierOrder;

            if (coForm != null)
            {
                coForm.refreshData();
            }
        }

        private void adminDashboard1_Load(object sender, EventArgs e)
        {
             
        }

        private void user_username_Click(object sender, EventArgs e)
        {

        }
    }
}

