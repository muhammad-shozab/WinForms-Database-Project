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
using System.Windows.Forms.VisualStyles;
using System.Diagnostics.Eventing.Reader;
using System.Drawing.Printing;
using System.Globalization;



namespace InventoryMangmentsystem
{
    public partial class CashierOrder : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\inventory.mdf;Integrated Security=True;Connect Timeout=30");

        public CashierOrder()
        {
            InitializeComponent();

            displayAllAvailableProducts();
            displayAllCategories();

            displayOrder();
            displayTotalPrice();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }

            displayAllAvailableProducts();
            displayAllCategories();

            displayOrder();
            displayTotalPrice();
        }



        public void displayAllAvailableProducts()
        {
            AddProductsData apData = new AddProductsData();
            List<AddProductsData> listData = apData.AllAvailableProducts();

            dataGridView1.DataSource = listData;
        }

        public void displayOrder()
        {
            OrdersData oData = new OrdersData();
            List<OrdersData> ListData = oData.allOrdersData();

            dataGridView2.DataSource = ListData;
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



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (prodID == 0)
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to Remove ID: " + prodID + "?", "Confirmation Message",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (checkConnection())
                    {
                        try
                        {
                            connect.Open();

                            string deleteData = "DELETE FROM orders WHERE id =@id";

                            using (SqlCommand cmd = new SqlCommand(deleteData, connect))
                            {
                                cmd.Parameters.AddWithValue("@id", prodID);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Removed successfully!", "Information Message Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Failed connection: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                }
            }
            displayOrder();
            displayTotalPrice();
        }




        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
        private float totalprice = 0;
        public void displayTotalPrice()
        {
            IDGenerator();

            if (checkConnection())
            {
                try
                {
                    connect.Open();
                    string selectData = "SELECT SUM(total_price) FROM orders WHERE customer_id = @cID";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@cID", idGen);
                        object result = cmd.ExecuteScalar();

                        if (result != DBNull.Value)
                        {
                            totalprice = Convert.ToSingle(result);
                            cashierOrder_totalPrice.Text = totalprice.ToString("0.00");
                        }
                        else
                        {
                            cashierOrder_totalPrice.Text = "0.00";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error calculating total: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private void cashierOrder_addBtn_Click(object sender, EventArgs e)
        {
            IDGenerator();

            if (CashierOrder_category.SelectedIndex == -1 || CashierOrder_prodID.SelectedIndex == -1
   || CashierOrder_prodName.Text == "" || CashierOrder_price.Text == "" || CashierOrder_qty.Value == 0)
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (checkConnection())
                {
                    try
                    {
                        connect.Open();

                        float getPrice = 0;
                        string selectOrder = "SELECT * FROM products WHERE prod_id = @prodID";

                        using (SqlCommand getOrder = new SqlCommand(selectOrder, connect))
                        {
                            getOrder.Parameters.AddWithValue("@prodID", CashierOrder_prodID.SelectedItem);

                            using (SqlDataReader reader = getOrder.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    object rawValue = reader["price"];

                                    if (rawValue != DBNull.Value)
                                    {
                                        getPrice = Convert.ToSingle(rawValue);
                                    }
                                }
                            }
                        }

                        string insertData = @"INSERT INTO orders (customer_id, prod_name, category, qty, orig_price, total_price, order_date) 
                      VALUES(@cID, @prodName, @cat, @qty, @origPrice, @totalprice, @date)";


                        using (SqlCommand cmd = new SqlCommand(insertData, connect))
                        {
                            cmd.Parameters.AddWithValue("@cID", idGen);
                            cmd.Parameters.AddWithValue("@prodName", CashierOrder_prodName.Text.Trim());
                            cmd.Parameters.AddWithValue("@cat", CashierOrder_category.SelectedItem);
                            cmd.Parameters.AddWithValue("@qty", CashierOrder_qty.Value);
                            cmd.Parameters.AddWithValue("@origPrice", getPrice);

                            float totalP = (getPrice * (int)CashierOrder_qty.Value);

                            cmd.Parameters.AddWithValue("@totalprice", totalP);

                            DateTime today = DateTime.Today;
                            cmd.Parameters.AddWithValue("@date", today);

                            cmd.ExecuteNonQuery();
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed connection: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
            displayOrder();
            displayTotalPrice();
        }

        private int idGen;

        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\inventory.mdf;Integrated Security=True;Connect Timeout=30";
        public void IDGenerator()
        {
            using (SqlConnection connect
                = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\inventory.mdf;Integrated Security=True;Connect Timeout=30"))

            {
                connect.Open();

                string selectData = "SELECT MAX(customer_id) FROM customers";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        int temp = Convert.ToInt32(result);

                        if (temp == 0)
                        {
                            idGen = 1;
                        }
                        else
                        {
                            idGen = temp + 1;
                        }
                    }
                    else
                    {
                        idGen = 1;
                    }
                }
            }
        }


        public void displayAllCategories()
        {
            if (checkConnection())
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM catagories";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            CashierOrder_category.Items.Clear();

                            while (reader.Read())
                            {

                                string item = reader.GetString(1);
                                CashierOrder_category.Items.Add(item);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed connection: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CashierOrder_category_SelectedIndexChanged(object sender, EventArgs e)
        {

            CashierOrder_prodID.SelectedIndex = -1;
            CashierOrder_prodID.Items.Clear();
            CashierOrder_prodName.Text = "";
            CashierOrder_price.Text = "";


            string selectedValue = CashierOrder_category.SelectedItem as string;

            if (selectedValue != null)
            {
                if (checkConnection())
                {
                    try
                    {
                        connect.Open();

                        string selectData = $"SELECT * FROM products where Category = '{selectedValue}' AND status = @status";

                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@status", "Available");

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    string value = reader["prod_id"].ToString();
                                    CashierOrder_prodID.Items.Add(value);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed connection: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        private void CashierOrder_prodID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = CashierOrder_prodID.SelectedItem as string;

            if (selectedValue != null)
            {
                try
                {
                    connect.Open();

                    string selectData = $"SELECT * FROM products WHERE prod_id = '{selectedValue}' AND status = @status";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@status", "Available");

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string prodName = reader["prod_name"].ToString();
                                float prodPrice = Convert.ToSingle(reader["price"]);

                                CashierOrder_prodName.Text = prodName;
                                CashierOrder_price.Text = prodPrice.ToString("0.00");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed connection: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }

        }

        private int prodID = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
            prodID = (int)row.Cells[0].Value;

        }
        public void clearfields()
        {
            CashierOrder_category.SelectedIndex = -1;
            CashierOrder_prodID.SelectedIndex = -1;
            CashierOrder_prodName.Text = "";
            CashierOrder_price.Text = "";
            CashierOrder_qty.Value = 0;

        }

        private void cashierOrder_clearBtn_Click(object sender, EventArgs e)
        {
            clearfields();
        }

        private void cashierOrder_payOrder_Click(object sender, EventArgs e)
        {
            if (cashierOrder_amount.Text == "" || dataGridView2.Rows.Count < 0)
            {
                MessageBox.Show("Please enter payment amount and ensure there are items to pay for", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to pay for your orders?",
                    "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (checkConnection())
                    {
                        try
                        {
                            connect.Open();

                            string insertData = "INSERT INTO customers (customer_id, total_price, amount, change, order_date) " +
                                   "VALUES(@CID, @totalPrice, @amount, @change, @date);";

                            using (SqlCommand cmd = new SqlCommand(insertData, connect))
                            {
                                cmd.Parameters.AddWithValue("cID", idGen);
                                cmd.Parameters.AddWithValue("@totalPrice", cashierOrder_totalPrice.Text);
                                cmd.Parameters.AddWithValue("@amount", cashierOrder_amount.Text);
                                cmd.Parameters.AddWithValue("@change", cashierOrder_change.Text);

                                DateTime today = DateTime.Today;
                                cmd.Parameters.AddWithValue("@date", today);

                                cmd.ExecuteNonQuery();
                                clearfields();
                                MessageBox.Show("Payment processed successfully!",
                                              "Information Message",
                                              MessageBoxButtons.OK,
                                              MessageBoxIcon.Information);

                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Connection failed: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }

                    }
                }
            }
            displayTotalPrice();
            cashierOrder_amount.Text = "";
            cashierOrder_change.Text = "";

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }


        private void cashierOrder_amount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    float getAmount = Convert.ToSingle(cashierOrder_amount.Text);
                    float getChange = (getAmount - totalprice);

                    if (getChange <= -1)
                    {
                        cashierOrder_amount.Text = "";
                        cashierOrder_change.Text = "";
                    }
                    else
                    {
                        cashierOrder_change.Text = getChange.ToString("0.00");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something went wrong :3", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cashierOrder_amount.Text = "";
                    cashierOrder_change.Text = "";
                }
                finally
                {
                }
            }

        }







        private int rowIndex = 0;

        private void cashierOrder_receipt_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.Count == 0)
            {
                MessageBox.Show("No orders to print", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(cashierOrder_amount.Text))
            {
                MessageBox.Show("Please enter payment amount first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printDocument1.BeginPrint += new PrintEventHandler(printDocument1_BeginPrint);

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();

            cashierOrder_amount.Text = "";
            cashierOrder_change.Text = "";
        }

        private void printDocument1_BeginPrint(object sender, PrintEventArgs e)
        {
            rowIndex = 0;
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            displayTotalPrice();

            // Check if there's data to print
            if (dataGridView2.Rows.Count == 0)
            {
                MessageBox.Show("No order data to print", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Page setup
            Graphics graphics = e.Graphics;
            float pageWidth = e.MarginBounds.Width;
            float pageHeight = e.MarginBounds.Height;
            float leftMargin = e.MarginBounds.Left;
            float topMargin = e.MarginBounds.Top;
            float currentY = topMargin;

            // Fonts
            Font titleFont = new Font("Arial", 16, FontStyle.Bold);
            Font headerFont = new Font("Arial", 12, FontStyle.Bold);
            Font dataFont = new Font("Arial", 10);
            Font footerFont = new Font("Arial", 11, FontStyle.Bold);

            // String formats
            StringFormat centerFormat = new StringFormat() { Alignment = StringAlignment.Center };
            StringFormat leftFormat = new StringFormat() { Alignment = StringAlignment.Near };
            StringFormat rightFormat = new StringFormat() { Alignment = StringAlignment.Far };

            // Title
            string title = "Database Project Inventory Management System";
            RectangleF titleRect = new RectangleF(leftMargin, currentY, pageWidth, titleFont.GetHeight(graphics));
            graphics.DrawString(title, titleFont, Brushes.Black, titleRect, centerFormat);
            currentY += titleFont.GetHeight(graphics) + 20;

            // Store info and date
            DateTime now = DateTime.Now;
            string storeInfo = "Receipt #" + idGen.ToString("D6");
            string dateInfo = now.ToString("dd/MM/yyyy HH:mm:ss");

            graphics.DrawString(storeInfo, dataFont, Brushes.Black, leftMargin, currentY);
            float dateWidth = graphics.MeasureString(dateInfo, dataFont).Width;
            graphics.DrawString(dateInfo, dataFont, Brushes.Black, leftMargin + pageWidth - dateWidth, currentY);
            currentY += dataFont.GetHeight(graphics) + 15;

            // Separator line
            graphics.DrawLine(Pens.Black, leftMargin, currentY, leftMargin + pageWidth, currentY);
            currentY += 10;

            // Table headers
            float col1Width = 60;   // ID
            float col2Width = 140;  // Product Name
            float col3Width = 100;  // Category
            float col4Width = 80;   // Price
            float col5Width = 50;   // QTY
            float col6Width = 80;   // Total

            float col1X = leftMargin;
            float col2X = col1X + col1Width;
            float col3X = col2X + col2Width;
            float col4X = col3X + col3Width;
            float col5X = col4X + col4Width;
            float col6X = col5X + col5Width;

            // Draw headers
            graphics.DrawString("ID", headerFont, Brushes.Black, new RectangleF(col1X, currentY, col1Width, headerFont.GetHeight(graphics)), centerFormat);
            graphics.DrawString("Product", headerFont, Brushes.Black, new RectangleF(col2X, currentY, col2Width, headerFont.GetHeight(graphics)), leftFormat);
            graphics.DrawString("Category", headerFont, Brushes.Black, new RectangleF(col3X, currentY, col3Width, headerFont.GetHeight(graphics)), leftFormat);
            graphics.DrawString("Price", headerFont, Brushes.Black, new RectangleF(col4X, currentY, col4Width, headerFont.GetHeight(graphics)), rightFormat);
            graphics.DrawString("QTY", headerFont, Brushes.Black, new RectangleF(col5X, currentY, col5Width, headerFont.GetHeight(graphics)), centerFormat);
            graphics.DrawString("Total", headerFont, Brushes.Black, new RectangleF(col6X, currentY, col6Width, headerFont.GetHeight(graphics)), rightFormat);

            currentY += headerFont.GetHeight(graphics) + 5;

            // Header underline
            graphics.DrawLine(Pens.Black, leftMargin, currentY, leftMargin + col6X + col6Width, currentY);
            currentY += 8;

            // Data rows
            float rowHeight = dataFont.GetHeight(graphics) + 4;

            while (rowIndex < dataGridView2.Rows.Count)
            {
                DataGridViewRow row = dataGridView2.Rows[rowIndex];

                if (row.IsNewRow)
                {
                    rowIndex++;
                    continue;
                }

                // Check if we need a new page
                if (currentY + rowHeight + 100 > topMargin + pageHeight)
                {
                    e.HasMorePages = true;
                    return;
                }

                // Get data using column indices (0-based)
                string id = row.Cells[0]?.Value?.ToString() ?? "";
                string prodName = row.Cells[2]?.Value?.ToString() ?? "";
                string category = row.Cells[3]?.Value?.ToString() ?? "";
                string qty = row.Cells[4]?.Value?.ToString() ?? "";

                string price = "";
                string totalPriceStr = "";

                // Format original price (column 5)
                if (row.Cells[5]?.Value != null)
                {
                    if (float.TryParse(row.Cells[5].Value.ToString(), out float priceValue))
                        price = "$" + priceValue.ToString("F2");
                }

                // Format total price (column 6)
                if (row.Cells[6]?.Value != null)
                {
                    if (float.TryParse(row.Cells[6].Value.ToString(), out float totalValue))
                        totalPriceStr = "$" + totalValue.ToString("F2");
                }

                // Truncate long text to fit columns
                if (prodName.Length > 18) prodName = prodName.Substring(0, 15) + "...";
                if (category.Length > 12) category = category.Substring(0, 9) + "...";

                // Draw data in each column
                graphics.DrawString(id, dataFont, Brushes.Black, new RectangleF(col1X, currentY, col1Width, rowHeight), centerFormat);
                graphics.DrawString(prodName, dataFont, Brushes.Black, new RectangleF(col2X, currentY, col2Width, rowHeight), leftFormat);
                graphics.DrawString(category, dataFont, Brushes.Black, new RectangleF(col3X, currentY, col3Width, rowHeight), leftFormat);
                graphics.DrawString(price, dataFont, Brushes.Black, new RectangleF(col4X, currentY, col4Width, rowHeight), rightFormat);
                graphics.DrawString(qty, dataFont, Brushes.Black, new RectangleF(col5X, currentY, col5Width, rowHeight), centerFormat);
                graphics.DrawString(totalPriceStr, dataFont, Brushes.Black, new RectangleF(col6X, currentY, col6Width, rowHeight), rightFormat);

                currentY += rowHeight;
                rowIndex++;
            }

            // Footer section
            currentY += 15;
            graphics.DrawLine(Pens.Black, leftMargin, currentY, leftMargin + col6X + col6Width, currentY);
            currentY += 15;

            // Payment summary (right-aligned)
            float summaryStartX = col4X; // Start from price column
            float summaryWidth = col6X + col6Width - col4X;

            // Total Amount
            graphics.DrawString("TOTAL:", footerFont, Brushes.Black, summaryStartX, currentY);
            graphics.DrawString("$" + totalprice.ToString("F2"), footerFont, Brushes.Black,
                new RectangleF(summaryStartX, currentY, summaryWidth, footerFont.GetHeight(graphics)), rightFormat);
            currentY += footerFont.GetHeight(graphics) + 5;

            // Amount Paid
            if (!string.IsNullOrEmpty(cashierOrder_amount.Text))
            {
                graphics.DrawString("PAID:", dataFont, Brushes.Black, summaryStartX, currentY);
                graphics.DrawString("$" + cashierOrder_amount.Text.Trim(), dataFont, Brushes.Black,
                    new RectangleF(summaryStartX, currentY, summaryWidth, dataFont.GetHeight(graphics)), rightFormat);
                currentY += dataFont.GetHeight(graphics) + 3;

                // Change
                if (!string.IsNullOrEmpty(cashierOrder_change.Text))
                {
                    graphics.DrawString("CHANGE:", dataFont, Brushes.Black, summaryStartX, currentY);
                    graphics.DrawString("$" + cashierOrder_change.Text.Trim(), dataFont, Brushes.Black,
                        new RectangleF(summaryStartX, currentY, summaryWidth, dataFont.GetHeight(graphics)), rightFormat);
                    currentY += dataFont.GetHeight(graphics) + 10;
                }
            }

            // Final separator and thank you
            currentY += 10;
            graphics.DrawLine(Pens.Black, leftMargin, currentY, leftMargin + col6X + col6Width, currentY);
            currentY += 15;

            string thankYou = "Thank you for your business!";


            graphics.DrawString(thankYou, footerFont, Brushes.Black,
                new RectangleF(leftMargin, currentY, col6X + col6Width, footerFont.GetHeight(graphics)), centerFormat);

            // Dispose fonts
            titleFont.Dispose();
            headerFont.Dispose();
            dataFont.Dispose();
            footerFont.Dispose();

            // Dispose formats
            centerFormat.Dispose();
            leftFormat.Dispose();
            rightFormat.Dispose();

            e.HasMorePages = false;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CashierOrder_prodName_Click(object sender, EventArgs e)
        {

        }

        private void CashierOrder_price_Click(object sender, EventArgs e)
        {

        }
    }
}