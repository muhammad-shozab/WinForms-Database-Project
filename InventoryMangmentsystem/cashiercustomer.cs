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
    public partial class cashiercustomer : UserControl
    {
        public cashiercustomer()
        {
            InitializeComponent();

            displayCustomers();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }

            displayCustomers();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void displayCustomers()
        {
            dataGridView1.AutoGenerateColumns = true;

            customerData cData = new customerData();
            List<customerData> listData = cData.allTodaycustomers();
            dataGridView1.DataSource = listData;
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
