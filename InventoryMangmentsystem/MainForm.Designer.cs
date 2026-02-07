namespace InventoryMangmentsystem
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.noaccount_label = new System.Windows.Forms.Label();
            this.cross_button = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.customers_btn = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.addProducts_btn = new System.Windows.Forms.Button();
            this.addUsers_btn = new System.Windows.Forms.Button();
            this.addCategories_btn = new System.Windows.Forms.Button();
            this.dashboard_btn = new System.Windows.Forms.Button();
            this.user_username = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.cashiercustomer1 = new InventoryMangmentsystem.cashiercustomer();
            this.adminAddProducts1 = new InventoryMangmentsystem.AdminAddProducts();
            this.adminAddCategories2 = new InventoryMangmentsystem.AdminAddCategories();
            this.adminAddUserscs2 = new InventoryMangmentsystem.AdminAddUserscs();
            this.adminDashboard1 = new InventoryMangmentsystem.AdminDashboard();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(976, 45);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // noaccount_label
            // 
            this.noaccount_label.AutoSize = true;
            this.noaccount_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noaccount_label.Location = new System.Drawing.Point(9, 13);
            this.noaccount_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.noaccount_label.Name = "noaccount_label";
            this.noaccount_label.Size = new System.Drawing.Size(460, 20);
            this.noaccount_label.TabIndex = 5;
            this.noaccount_label.Text = "SuperMart Inventory Managment System | Admin\'s Potal";
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
            this.panel2.Controls.Add(this.customers_btn);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.addProducts_btn);
            this.panel2.Controls.Add(this.addUsers_btn);
            this.panel2.Controls.Add(this.addCategories_btn);
            this.panel2.Controls.Add(this.dashboard_btn);
            this.panel2.Controls.Add(this.user_username);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(148, 568);
            this.panel2.TabIndex = 1;
            // 
            // customers_btn
            // 
            this.customers_btn.FlatAppearance.BorderSize = 0;
            this.customers_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(109)))));
            this.customers_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(109)))));
            this.customers_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customers_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customers_btn.ForeColor = System.Drawing.Color.White;
            this.customers_btn.Location = new System.Drawing.Point(26, 375);
            this.customers_btn.Margin = new System.Windows.Forms.Padding(2);
            this.customers_btn.Name = "customers_btn";
            this.customers_btn.Size = new System.Drawing.Size(96, 28);
            this.customers_btn.TabIndex = 17;
            this.customers_btn.Text = "Customers";
            this.customers_btn.UseVisualStyleBackColor = true;
            this.customers_btn.Click += new System.EventHandler(this.customers_btn_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(109)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(113)))), ((int)(((byte)(73)))));
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(113)))), ((int)(((byte)(73)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(13, 488);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(127, 28);
            this.button5.TabIndex = 16;
            this.button5.Text = "Logout";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // addProducts_btn
            // 
            this.addProducts_btn.FlatAppearance.BorderSize = 0;
            this.addProducts_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(109)))));
            this.addProducts_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(109)))));
            this.addProducts_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProducts_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProducts_btn.ForeColor = System.Drawing.Color.White;
            this.addProducts_btn.Location = new System.Drawing.Point(19, 312);
            this.addProducts_btn.Margin = new System.Windows.Forms.Padding(2);
            this.addProducts_btn.Name = "addProducts_btn";
            this.addProducts_btn.Size = new System.Drawing.Size(110, 39);
            this.addProducts_btn.TabIndex = 15;
            this.addProducts_btn.Text = "Add Product";
            this.addProducts_btn.UseVisualStyleBackColor = true;
            this.addProducts_btn.Click += new System.EventHandler(this.button4_Click);
            // 
            // addUsers_btn
            // 
            this.addUsers_btn.FlatAppearance.BorderSize = 0;
            this.addUsers_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(109)))));
            this.addUsers_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(109)))));
            this.addUsers_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addUsers_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUsers_btn.ForeColor = System.Drawing.Color.White;
            this.addUsers_btn.Location = new System.Drawing.Point(26, 201);
            this.addUsers_btn.Margin = new System.Windows.Forms.Padding(2);
            this.addUsers_btn.Name = "addUsers_btn";
            this.addUsers_btn.Size = new System.Drawing.Size(96, 28);
            this.addUsers_btn.TabIndex = 14;
            this.addUsers_btn.Text = "Add Users";
            this.addUsers_btn.UseVisualStyleBackColor = true;
            this.addUsers_btn.Click += new System.EventHandler(this.addUsers_btn_Click);
            // 
            // addCategories_btn
            // 
            this.addCategories_btn.FlatAppearance.BorderSize = 0;
            this.addCategories_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(109)))));
            this.addCategories_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(109)))));
            this.addCategories_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCategories_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCategories_btn.ForeColor = System.Drawing.Color.White;
            this.addCategories_btn.Location = new System.Drawing.Point(9, 245);
            this.addCategories_btn.Margin = new System.Windows.Forms.Padding(2);
            this.addCategories_btn.Name = "addCategories_btn";
            this.addCategories_btn.Size = new System.Drawing.Size(127, 52);
            this.addCategories_btn.TabIndex = 13;
            this.addCategories_btn.Text = "Add Categories";
            this.addCategories_btn.UseVisualStyleBackColor = true;
            this.addCategories_btn.Click += new System.EventHandler(this.addCategories_btn_Click);
            // 
            // dashboard_btn
            // 
            this.dashboard_btn.FlatAppearance.BorderSize = 0;
            this.dashboard_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(109)))));
            this.dashboard_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(109)))));
            this.dashboard_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboard_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_btn.ForeColor = System.Drawing.Color.White;
            this.dashboard_btn.Location = new System.Drawing.Point(26, 150);
            this.dashboard_btn.Margin = new System.Windows.Forms.Padding(2);
            this.dashboard_btn.Name = "dashboard_btn";
            this.dashboard_btn.Size = new System.Drawing.Size(96, 28);
            this.dashboard_btn.TabIndex = 12;
            this.dashboard_btn.Text = "Dashboard";
            this.dashboard_btn.UseVisualStyleBackColor = true;
            this.dashboard_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // user_username
            // 
            this.user_username.AutoSize = true;
            this.user_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_username.ForeColor = System.Drawing.Color.White;
            this.user_username.Location = new System.Drawing.Point(80, 88);
            this.user_username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.user_username.Name = "user_username";
            this.user_username.Size = new System.Drawing.Size(54, 18);
            this.user_username.TabIndex = 11;
            this.user_username.Text = "Admin";
            this.user_username.Click += new System.EventHandler(this.label2_Click);
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
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            // cashiercustomer1
            // 
            this.cashiercustomer1.Location = new System.Drawing.Point(147, 45);
            this.cashiercustomer1.Name = "cashiercustomer1";
            this.cashiercustomer1.Size = new System.Drawing.Size(826, 565);
            this.cashiercustomer1.TabIndex = 2;
            // 
            // adminAddProducts1
            // 
            this.adminAddProducts1.Location = new System.Drawing.Point(147, 45);
            this.adminAddProducts1.Margin = new System.Windows.Forms.Padding(2);
            this.adminAddProducts1.Name = "adminAddProducts1";
            this.adminAddProducts1.Size = new System.Drawing.Size(830, 602);
            this.adminAddProducts1.TabIndex = 3;
            // 
            // adminAddCategories2
            // 
            this.adminAddCategories2.Location = new System.Drawing.Point(146, 45);
            this.adminAddCategories2.Margin = new System.Windows.Forms.Padding(2);
            this.adminAddCategories2.Name = "adminAddCategories2";
            this.adminAddCategories2.Size = new System.Drawing.Size(830, 614);
            this.adminAddCategories2.TabIndex = 4;
            // 
            // adminAddUserscs2
            // 
            this.adminAddUserscs2.Location = new System.Drawing.Point(146, 45);
            this.adminAddUserscs2.Margin = new System.Windows.Forms.Padding(2);
            this.adminAddUserscs2.Name = "adminAddUserscs2";
            this.adminAddUserscs2.Size = new System.Drawing.Size(830, 614);
            this.adminAddUserscs2.TabIndex = 5;
            // 
            // adminDashboard1
            // 
            this.adminDashboard1.Location = new System.Drawing.Point(146, 45);
            this.adminDashboard1.Margin = new System.Windows.Forms.Padding(2);
            this.adminDashboard1.Name = "adminDashboard1";
            this.adminDashboard1.Size = new System.Drawing.Size(830, 614);
            this.adminDashboard1.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 613);
            this.Controls.Add(this.adminDashboard1);
            this.Controls.Add(this.adminAddUserscs2);
            this.Controls.Add(this.adminAddCategories2);
            this.Controls.Add(this.adminAddProducts1);
            this.Controls.Add(this.cashiercustomer1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cross_button;
        private System.Windows.Forms.Label noaccount_label;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dashboard_btn;
        private System.Windows.Forms.Label user_username;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button addProducts_btn;
        private System.Windows.Forms.Button addUsers_btn;
        private System.Windows.Forms.Button addCategories_btn;
        private System.Windows.Forms.Button customers_btn;
        private AdminAddUserscs adminAddUserscs1;
        private AdminAddCategories adminAddCategories1;
        private cashiercustomer cashiercustomer1;
        private AdminAddProducts adminAddProducts1;
        private AdminAddCategories adminAddCategories2;
        private AdminAddUserscs adminAddUserscs2;
        private AdminDashboard adminDashboard1;
    }
}