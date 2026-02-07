namespace InventoryMangmentsystem
{
    partial class CashierMainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierMainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.noaccount_label = new System.Windows.Forms.Label();
            this.cross_button = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.order_btn = new System.Windows.Forms.Button();
            this.customers_btn = new System.Windows.Forms.Button();
            this.loggout_btn = new System.Windows.Forms.Button();
            this.addproduct_btn = new System.Windows.Forms.Button();
            this.dashboard_btn = new System.Windows.Forms.Button();
            this.user_username = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.adminDashboard1 = new InventoryMangmentsystem.AdminDashboard();
            this.adminAddProducts1 = new InventoryMangmentsystem.AdminAddProducts();
            this.cashiercustomer1 = new InventoryMangmentsystem.cashiercustomer();
            this.cashierOrder1 = new InventoryMangmentsystem.CashierOrder();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.noaccount_label);
            this.panel1.Controls.Add(this.cross_button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(978, 45);
            this.panel1.TabIndex = 1;
            // 
            // noaccount_label
            // 
            this.noaccount_label.AutoSize = true;
            this.noaccount_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noaccount_label.Location = new System.Drawing.Point(9, 13);
            this.noaccount_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.noaccount_label.Name = "noaccount_label";
            this.noaccount_label.Size = new System.Drawing.Size(471, 20);
            this.noaccount_label.TabIndex = 5;
            this.noaccount_label.Text = "SuperMart Inventory Managment System | Cashier\'s Potal";
            this.noaccount_label.Click += new System.EventHandler(this.noaccount_label_Click);
            // 
            // cross_button
            // 
            this.cross_button.BackColor = System.Drawing.Color.Firebrick;
            this.cross_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cross_button.FlatAppearance.BorderSize = 2;
            this.cross_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cross_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cross_button.ForeColor = System.Drawing.Color.White;
            this.cross_button.Location = new System.Drawing.Point(934, 9);
            this.cross_button.Margin = new System.Windows.Forms.Padding(2);
            this.cross_button.Name = "cross_button";
            this.cross_button.Size = new System.Drawing.Size(33, 24);
            this.cross_button.TabIndex = 1;
            this.cross_button.Text = "❌";
            this.cross_button.UseVisualStyleBackColor = false;
            this.cross_button.Click += new System.EventHandler(this.cross_button_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(113)))), ((int)(((byte)(73)))));
            this.panel2.Controls.Add(this.order_btn);
            this.panel2.Controls.Add(this.customers_btn);
            this.panel2.Controls.Add(this.loggout_btn);
            this.panel2.Controls.Add(this.addproduct_btn);
            this.panel2.Controls.Add(this.dashboard_btn);
            this.panel2.Controls.Add(this.user_username);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(148, 602);
            this.panel2.TabIndex = 2;
            // 
            // order_btn
            // 
            this.order_btn.FlatAppearance.BorderSize = 0;
            this.order_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(109)))));
            this.order_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(109)))));
            this.order_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.order_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order_btn.ForeColor = System.Drawing.Color.White;
            this.order_btn.Location = new System.Drawing.Point(26, 325);
            this.order_btn.Margin = new System.Windows.Forms.Padding(2);
            this.order_btn.Name = "order_btn";
            this.order_btn.Size = new System.Drawing.Size(96, 28);
            this.order_btn.TabIndex = 18;
            this.order_btn.Text = "Order";
            this.order_btn.UseVisualStyleBackColor = true;
            this.order_btn.Click += new System.EventHandler(this.order_btn_Click);
            // 
            // customers_btn
            // 
            this.customers_btn.FlatAppearance.BorderSize = 0;
            this.customers_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(109)))));
            this.customers_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(109)))));
            this.customers_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customers_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customers_btn.ForeColor = System.Drawing.Color.White;
            this.customers_btn.Location = new System.Drawing.Point(26, 268);
            this.customers_btn.Margin = new System.Windows.Forms.Padding(2);
            this.customers_btn.Name = "customers_btn";
            this.customers_btn.Size = new System.Drawing.Size(96, 28);
            this.customers_btn.TabIndex = 17;
            this.customers_btn.Text = "Customers";
            this.customers_btn.UseVisualStyleBackColor = true;
            this.customers_btn.Click += new System.EventHandler(this.customers_btn_Click);
            // 
            // loggout_btn
            // 
            this.loggout_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(109)))));
            this.loggout_btn.FlatAppearance.BorderSize = 0;
            this.loggout_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(113)))), ((int)(((byte)(73)))));
            this.loggout_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(113)))), ((int)(((byte)(73)))));
            this.loggout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loggout_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loggout_btn.ForeColor = System.Drawing.Color.White;
            this.loggout_btn.Location = new System.Drawing.Point(13, 488);
            this.loggout_btn.Margin = new System.Windows.Forms.Padding(2);
            this.loggout_btn.Name = "loggout_btn";
            this.loggout_btn.Size = new System.Drawing.Size(127, 28);
            this.loggout_btn.TabIndex = 16;
            this.loggout_btn.Text = "Logout";
            this.loggout_btn.UseVisualStyleBackColor = false;
            this.loggout_btn.Click += new System.EventHandler(this.loggout_btn_Click);
            // 
            // addproduct_btn
            // 
            this.addproduct_btn.FlatAppearance.BorderSize = 0;
            this.addproduct_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(109)))));
            this.addproduct_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(109)))));
            this.addproduct_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addproduct_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addproduct_btn.ForeColor = System.Drawing.Color.White;
            this.addproduct_btn.Location = new System.Drawing.Point(24, 207);
            this.addproduct_btn.Margin = new System.Windows.Forms.Padding(2);
            this.addproduct_btn.Name = "addproduct_btn";
            this.addproduct_btn.Size = new System.Drawing.Size(110, 39);
            this.addproduct_btn.TabIndex = 15;
            this.addproduct_btn.Text = "Add Product";
            this.addproduct_btn.UseVisualStyleBackColor = true;
            this.addproduct_btn.Click += new System.EventHandler(this.addproduct_btn_Click);
            // 
            // dashboard_btn
            // 
            this.dashboard_btn.FlatAppearance.BorderSize = 0;
            this.dashboard_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(109)))));
            this.dashboard_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(109)))));
            this.dashboard_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboard_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_btn.ForeColor = System.Drawing.Color.White;
            this.dashboard_btn.Location = new System.Drawing.Point(26, 152);
            this.dashboard_btn.Margin = new System.Windows.Forms.Padding(2);
            this.dashboard_btn.Name = "dashboard_btn";
            this.dashboard_btn.Size = new System.Drawing.Size(96, 28);
            this.dashboard_btn.TabIndex = 12;
            this.dashboard_btn.Text = "Dashboard";
            this.dashboard_btn.UseVisualStyleBackColor = true;
            this.dashboard_btn.Click += new System.EventHandler(this.dashboard_btn_Click);
            // 
            // user_username
            // 
            this.user_username.AutoSize = true;
            this.user_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_username.ForeColor = System.Drawing.Color.White;
            this.user_username.Location = new System.Drawing.Point(80, 88);
            this.user_username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.user_username.Name = "user_username";
            this.user_username.Size = new System.Drawing.Size(66, 18);
            this.user_username.TabIndex = 11;
            this.user_username.Text = "Cashier";
            this.user_username.Click += new System.EventHandler(this.user_username_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Welcom,";
            // 
            // pictureBox3
            // 
            this.pictureBox3.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.ErrorImage")));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.InitialImage")));
            this.pictureBox3.Location = new System.Drawing.Point(53, 18);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 54);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.adminDashboard1);
            this.panel3.Controls.Add(this.adminAddProducts1);
            this.panel3.Controls.Add(this.cashiercustomer1);
            this.panel3.Controls.Add(this.cashierOrder1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(148, 45);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(830, 602);
            this.panel3.TabIndex = 3;
            // 
            // adminDashboard1
            // 
            this.adminDashboard1.Location = new System.Drawing.Point(-2, 0);
            this.adminDashboard1.Margin = new System.Windows.Forms.Padding(2);
            this.adminDashboard1.Name = "adminDashboard1";
            this.adminDashboard1.Size = new System.Drawing.Size(830, 614);
            this.adminDashboard1.TabIndex = 3;
            this.adminDashboard1.Load += new System.EventHandler(this.adminDashboard1_Load);
            // 
            // adminAddProducts1
            // 
            this.adminAddProducts1.Location = new System.Drawing.Point(0, 0);
            this.adminAddProducts1.Margin = new System.Windows.Forms.Padding(2);
            this.adminAddProducts1.Name = "adminAddProducts1";
            this.adminAddProducts1.Size = new System.Drawing.Size(830, 614);
            this.adminAddProducts1.TabIndex = 2;
            // 
            // cashiercustomer1
            // 
            this.cashiercustomer1.Location = new System.Drawing.Point(0, 3);
            this.cashiercustomer1.Name = "cashiercustomer1";
            this.cashiercustomer1.Size = new System.Drawing.Size(818, 398);
            this.cashiercustomer1.TabIndex = 1;
            // 
            // cashierOrder1
            // 
            this.cashierOrder1.Location = new System.Drawing.Point(0, 0);
            this.cashierOrder1.Name = "cashierOrder1";
            this.cashierOrder1.Size = new System.Drawing.Size(830, 614);
            this.cashierOrder1.TabIndex = 0;
            // 
            // CashierMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 647);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CashierMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CashierMainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label noaccount_label;
        private System.Windows.Forms.Button cross_button;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button order_btn;
        private System.Windows.Forms.Button customers_btn;
        private System.Windows.Forms.Button loggout_btn;
        private System.Windows.Forms.Button addproduct_btn;
        private System.Windows.Forms.Button dashboard_btn;
        private System.Windows.Forms.Label user_username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel3;
        private AdminDashboard adminDashboard1;
        private AdminAddProducts adminAddProducts1;
        private cashiercustomer cashiercustomer1;
        private CashierOrder cashierOrder1;
    }
}