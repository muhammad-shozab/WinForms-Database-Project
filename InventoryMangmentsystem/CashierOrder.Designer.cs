namespace InventoryMangmentsystem
{
    partial class CashierOrder
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierOrder));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.cashierOrder_addBtn = new System.Windows.Forms.Button();
            this.cashierOrder_removeBtn = new System.Windows.Forms.Button();
            this.cashierOrder_clearBtn = new System.Windows.Forms.Button();
            this.CashierOrder_qty = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.CashierOrder_price = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CashierOrder_prodName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CashierOrder_prodID = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CashierOrder_category = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cashierOrder_amount = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cashierOrder_payOrder = new System.Windows.Forms.Button();
            this.cashierOrder_receipt = new System.Windows.Forms.Button();
            this.cashierOrder_change = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cashierOrder_totalPrice = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CashierOrder_qty)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(15, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(504, 286);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(113)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(113)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1.Location = new System.Drawing.Point(13, 53);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(478, 219);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Available Products ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.cashierOrder_addBtn);
            this.panel2.Controls.Add(this.cashierOrder_removeBtn);
            this.panel2.Controls.Add(this.cashierOrder_clearBtn);
            this.panel2.Controls.Add(this.CashierOrder_qty);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.CashierOrder_price);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.CashierOrder_prodName);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.CashierOrder_prodID);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.CashierOrder_category);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(15, 304);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(504, 294);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Select Your Orders";
            // 
            // cashierOrder_addBtn
            // 
            this.cashierOrder_addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(113)))), ((int)(((byte)(73)))));
            this.cashierOrder_addBtn.FlatAppearance.BorderSize = 0;
            this.cashierOrder_addBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.cashierOrder_addBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.cashierOrder_addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cashierOrder_addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrder_addBtn.ForeColor = System.Drawing.Color.White;
            this.cashierOrder_addBtn.Location = new System.Drawing.Point(22, 247);
            this.cashierOrder_addBtn.Margin = new System.Windows.Forms.Padding(2);
            this.cashierOrder_addBtn.Name = "cashierOrder_addBtn";
            this.cashierOrder_addBtn.Size = new System.Drawing.Size(118, 27);
            this.cashierOrder_addBtn.TabIndex = 20;
            this.cashierOrder_addBtn.Text = "Add";
            this.cashierOrder_addBtn.UseVisualStyleBackColor = false;
            this.cashierOrder_addBtn.Click += new System.EventHandler(this.cashierOrder_addBtn_Click);
            // 
            // cashierOrder_removeBtn
            // 
            this.cashierOrder_removeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(113)))), ((int)(((byte)(73)))));
            this.cashierOrder_removeBtn.FlatAppearance.BorderSize = 0;
            this.cashierOrder_removeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.cashierOrder_removeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.cashierOrder_removeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cashierOrder_removeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrder_removeBtn.ForeColor = System.Drawing.Color.White;
            this.cashierOrder_removeBtn.Location = new System.Drawing.Point(166, 247);
            this.cashierOrder_removeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.cashierOrder_removeBtn.Name = "cashierOrder_removeBtn";
            this.cashierOrder_removeBtn.Size = new System.Drawing.Size(118, 27);
            this.cashierOrder_removeBtn.TabIndex = 19;
            this.cashierOrder_removeBtn.Text = "Remove";
            this.cashierOrder_removeBtn.UseVisualStyleBackColor = false;
            this.cashierOrder_removeBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // cashierOrder_clearBtn
            // 
            this.cashierOrder_clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(113)))), ((int)(((byte)(73)))));
            this.cashierOrder_clearBtn.FlatAppearance.BorderSize = 0;
            this.cashierOrder_clearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.cashierOrder_clearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.cashierOrder_clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cashierOrder_clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrder_clearBtn.ForeColor = System.Drawing.Color.White;
            this.cashierOrder_clearBtn.Location = new System.Drawing.Point(362, 247);
            this.cashierOrder_clearBtn.Margin = new System.Windows.Forms.Padding(2);
            this.cashierOrder_clearBtn.Name = "cashierOrder_clearBtn";
            this.cashierOrder_clearBtn.Size = new System.Drawing.Size(118, 27);
            this.cashierOrder_clearBtn.TabIndex = 18;
            this.cashierOrder_clearBtn.Text = "Clear";
            this.cashierOrder_clearBtn.UseVisualStyleBackColor = false;
            this.cashierOrder_clearBtn.Click += new System.EventHandler(this.cashierOrder_clearBtn_Click);
            // 
            // CashierOrder_qty
            // 
            this.CashierOrder_qty.Location = new System.Drawing.Point(354, 145);
            this.CashierOrder_qty.Name = "CashierOrder_qty";
            this.CashierOrder_qty.Size = new System.Drawing.Size(128, 20);
            this.CashierOrder_qty.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(267, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Quantity:";
            // 
            // CashierOrder_price
            // 
            this.CashierOrder_price.AutoSize = true;
            this.CashierOrder_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashierOrder_price.Location = new System.Drawing.Point(146, 190);
            this.CashierOrder_price.Name = "CashierOrder_price";
            this.CashierOrder_price.Size = new System.Drawing.Size(77, 20);
            this.CashierOrder_price.TabIndex = 7;
            this.CashierOrder_price.Text = "Category:";
            this.CashierOrder_price.Click += new System.EventHandler(this.CashierOrder_price_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(62, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Price($):";
            // 
            // CashierOrder_prodName
            // 
            this.CashierOrder_prodName.AutoSize = true;
            this.CashierOrder_prodName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashierOrder_prodName.Location = new System.Drawing.Point(145, 143);
            this.CashierOrder_prodName.Name = "CashierOrder_prodName";
            this.CashierOrder_prodName.Size = new System.Drawing.Size(77, 20);
            this.CashierOrder_prodName.TabIndex = 5;
            this.CashierOrder_prodName.Text = "Category:";
            this.CashierOrder_prodName.Click += new System.EventHandler(this.CashierOrder_prodName_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Product Name:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // CashierOrder_prodID
            // 
            this.CashierOrder_prodID.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashierOrder_prodID.FormattingEnabled = true;
            this.CashierOrder_prodID.Location = new System.Drawing.Point(354, 68);
            this.CashierOrder_prodID.Name = "CashierOrder_prodID";
            this.CashierOrder_prodID.Size = new System.Drawing.Size(128, 28);
            this.CashierOrder_prodID.TabIndex = 3;
            this.CashierOrder_prodID.SelectedIndexChanged += new System.EventHandler(this.CashierOrder_prodID_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(261, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Product ID";
            // 
            // CashierOrder_category
            // 
            this.CashierOrder_category.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashierOrder_category.FormattingEnabled = true;
            this.CashierOrder_category.Location = new System.Drawing.Point(105, 68);
            this.CashierOrder_category.Name = "CashierOrder_category";
            this.CashierOrder_category.Size = new System.Drawing.Size(128, 28);
            this.CashierOrder_category.TabIndex = 1;
            this.CashierOrder_category.SelectedIndexChanged += new System.EventHandler(this.CashierOrder_category_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Category:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Controls.Add(this.cashierOrder_amount);
            this.panel3.Controls.Add(this.dataGridView2);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.cashierOrder_payOrder);
            this.panel3.Controls.Add(this.cashierOrder_receipt);
            this.panel3.Controls.Add(this.cashierOrder_change);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.cashierOrder_totalPrice);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Location = new System.Drawing.Point(525, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(293, 586);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // cashierOrder_amount
            // 
            this.cashierOrder_amount.Location = new System.Drawing.Point(148, 369);
            this.cashierOrder_amount.Name = "cashierOrder_amount";
            this.cashierOrder_amount.Size = new System.Drawing.Size(100, 20);
            this.cashierOrder_amount.TabIndex = 22;
            this.cashierOrder_amount.TextChanged += new System.EventHandler(this.cashierOrder_clearBtn_Click);
            this.cashierOrder_amount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cashierOrder_amount_KeyDown);
            // 
            // dataGridView2
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(113)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(113)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView2.Location = new System.Drawing.Point(16, 53);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(264, 233);
            this.dataGridView2.TabIndex = 24;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "All Orders";
            // 
            // cashierOrder_payOrder
            // 
            this.cashierOrder_payOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(113)))), ((int)(((byte)(73)))));
            this.cashierOrder_payOrder.FlatAppearance.BorderSize = 0;
            this.cashierOrder_payOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.cashierOrder_payOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.cashierOrder_payOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cashierOrder_payOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrder_payOrder.ForeColor = System.Drawing.Color.White;
            this.cashierOrder_payOrder.Location = new System.Drawing.Point(16, 467);
            this.cashierOrder_payOrder.Margin = new System.Windows.Forms.Padding(2);
            this.cashierOrder_payOrder.Name = "cashierOrder_payOrder";
            this.cashierOrder_payOrder.Size = new System.Drawing.Size(247, 33);
            this.cashierOrder_payOrder.TabIndex = 22;
            this.cashierOrder_payOrder.Text = "Pay Order";
            this.cashierOrder_payOrder.UseVisualStyleBackColor = false;
            this.cashierOrder_payOrder.Click += new System.EventHandler(this.cashierOrder_payOrder_Click);
            // 
            // cashierOrder_receipt
            // 
            this.cashierOrder_receipt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(113)))), ((int)(((byte)(73)))));
            this.cashierOrder_receipt.FlatAppearance.BorderSize = 0;
            this.cashierOrder_receipt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.cashierOrder_receipt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.cashierOrder_receipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cashierOrder_receipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrder_receipt.ForeColor = System.Drawing.Color.White;
            this.cashierOrder_receipt.Location = new System.Drawing.Point(16, 517);
            this.cashierOrder_receipt.Margin = new System.Windows.Forms.Padding(2);
            this.cashierOrder_receipt.Name = "cashierOrder_receipt";
            this.cashierOrder_receipt.Size = new System.Drawing.Size(247, 32);
            this.cashierOrder_receipt.TabIndex = 21;
            this.cashierOrder_receipt.Text = "Receipt";
            this.cashierOrder_receipt.UseVisualStyleBackColor = false;
            this.cashierOrder_receipt.Click += new System.EventHandler(this.cashierOrder_receipt_Click);
            // 
            // cashierOrder_change
            // 
            this.cashierOrder_change.AutoSize = true;
            this.cashierOrder_change.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrder_change.Location = new System.Drawing.Point(165, 413);
            this.cashierOrder_change.Name = "cashierOrder_change";
            this.cashierOrder_change.Size = new System.Drawing.Size(40, 20);
            this.cashierOrder_change.TabIndex = 12;
            this.cashierOrder_change.Text = "0.00";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(80, 413);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 20);
            this.label14.TabIndex = 11;
            this.label14.Text = "Change:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(80, 367);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "Amount: ";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // cashierOrder_totalPrice
            // 
            this.cashierOrder_totalPrice.AutoSize = true;
            this.cashierOrder_totalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrder_totalPrice.Location = new System.Drawing.Point(165, 325);
            this.cashierOrder_totalPrice.Name = "cashierOrder_totalPrice";
            this.cashierOrder_totalPrice.Size = new System.Drawing.Size(40, 20);
            this.cashierOrder_totalPrice.TabIndex = 8;
            this.cashierOrder_totalPrice.Text = "0.00";
            this.cashierOrder_totalPrice.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(38, 325);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 20);
            this.label12.TabIndex = 7;
            this.label12.Text = "Total Price($):";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(148, 369);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 22;
            this.textBox4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cashierOrder_amount_KeyDown);
            // 
            // CashierOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CashierOrder";
            this.Size = new System.Drawing.Size(830, 614);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CashierOrder_qty)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CashierOrder_prodID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CashierOrder_category;
        private System.Windows.Forms.Label CashierOrder_prodName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label CashierOrder_price;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown CashierOrder_qty;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button cashierOrder_addBtn;
        private System.Windows.Forms.Button cashierOrder_removeBtn;
        private System.Windows.Forms.Button cashierOrder_clearBtn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label cashierOrder_totalPrice;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button cashierOrder_payOrder;
        private System.Windows.Forms.Button cashierOrder_receipt;
        private System.Windows.Forms.Label cashierOrder_change;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.TextBox cashierOrder_amount;
        private System.Windows.Forms.TextBox textBox4;
    }
}
