namespace InventoryMangmentsystem
{
    partial class Registerform2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registerform2));
            this.cross_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.register_showPass = new System.Windows.Forms.CheckBox();
            this.register_cPassword = new System.Windows.Forms.TextBox();
            this.signin_label = new System.Windows.Forms.Label();
            this.haveaccount_label = new System.Windows.Forms.Label();
            this.signup_button = new System.Windows.Forms.Button();
            this.register_password = new System.Windows.Forms.TextBox();
            this.register_name = new System.Windows.Forms.TextBox();
            this.resig_accountlabel1 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cross_button
            // 
            this.cross_button.BackColor = System.Drawing.Color.Firebrick;
            this.cross_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cross_button.FlatAppearance.BorderSize = 2;
            this.cross_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cross_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cross_button.ForeColor = System.Drawing.Color.White;
            this.cross_button.Location = new System.Drawing.Point(411, 9);
            this.cross_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cross_button.Name = "cross_button";
            this.cross_button.Size = new System.Drawing.Size(44, 24);
            this.cross_button.TabIndex = 1;
            this.cross_button.Text = "❌";
            this.cross_button.UseVisualStyleBackColor = false;
            this.cross_button.Click += new System.EventHandler(this.cross_button_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.register_showPass);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.register_cPassword);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.signin_label);
            this.panel1.Controls.Add(this.haveaccount_label);
            this.panel1.Controls.Add(this.signup_button);
            this.panel1.Controls.Add(this.register_password);
            this.panel1.Controls.Add(this.register_name);
            this.panel1.Controls.Add(this.resig_accountlabel1);
            this.panel1.Location = new System.Drawing.Point(68, 37);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 370);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // register_showPass
            // 
            this.register_showPass.AutoSize = true;
            this.register_showPass.CausesValidation = false;
            this.register_showPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_showPass.Location = new System.Drawing.Point(164, 247);
            this.register_showPass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.register_showPass.Name = "register_showPass";
            this.register_showPass.Size = new System.Drawing.Size(130, 21);
            this.register_showPass.TabIndex = 11;
            this.register_showPass.Text = "Show Password ";
            this.register_showPass.UseVisualStyleBackColor = true;
            this.register_showPass.CheckedChanged += new System.EventHandler(this.register_showPass_CheckedChanged);
            // 
            // register_cPassword
            // 
            this.register_cPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_cPassword.Location = new System.Drawing.Point(93, 210);
            this.register_cPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.register_cPassword.Name = "register_cPassword";
            this.register_cPassword.PasswordChar = '*';
            this.register_cPassword.Size = new System.Drawing.Size(191, 26);
            this.register_cPassword.TabIndex = 9;
            // 
            // signin_label
            // 
            this.signin_label.AutoSize = true;
            this.signin_label.BackColor = System.Drawing.Color.White;
            this.signin_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signin_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signin_label.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.signin_label.Location = new System.Drawing.Point(218, 350);
            this.signin_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.signin_label.Name = "signin_label";
            this.signin_label.Size = new System.Drawing.Size(72, 15);
            this.signin_label.TabIndex = 5;
            this.signin_label.Text = "Signin Here";
            this.signin_label.Click += new System.EventHandler(this.signin_label_Click);
            // 
            // haveaccount_label
            // 
            this.haveaccount_label.AutoSize = true;
            this.haveaccount_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.haveaccount_label.Location = new System.Drawing.Point(57, 350);
            this.haveaccount_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.haveaccount_label.Name = "haveaccount_label";
            this.haveaccount_label.Size = new System.Drawing.Size(175, 17);
            this.haveaccount_label.TabIndex = 4;
            this.haveaccount_label.Text = "Already Have an Account !";
            // 
            // signup_button
            // 
            this.signup_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(113)))), ((int)(((byte)(73)))));
            this.signup_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.signup_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_button.ForeColor = System.Drawing.Color.White;
            this.signup_button.Location = new System.Drawing.Point(122, 299);
            this.signup_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.signup_button.Name = "signup_button";
            this.signup_button.Size = new System.Drawing.Size(107, 32);
            this.signup_button.TabIndex = 3;
            this.signup_button.Text = "Signup";
            this.signup_button.UseVisualStyleBackColor = false;
            this.signup_button.Click += new System.EventHandler(this.signup_button_Click);
            // 
            // register_password
            // 
            this.register_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_password.Location = new System.Drawing.Point(93, 165);
            this.register_password.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.register_password.Name = "register_password";
            this.register_password.PasswordChar = '*';
            this.register_password.Size = new System.Drawing.Size(191, 26);
            this.register_password.TabIndex = 2;
            // 
            // register_name
            // 
            this.register_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_name.Location = new System.Drawing.Point(93, 120);
            this.register_name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.register_name.Name = "register_name";
            this.register_name.Size = new System.Drawing.Size(191, 26);
            this.register_name.TabIndex = 1;
            // 
            // resig_accountlabel1
            // 
            this.resig_accountlabel1.AutoSize = true;
            this.resig_accountlabel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resig_accountlabel1.Location = new System.Drawing.Point(119, 88);
            this.resig_accountlabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.resig_accountlabel1.Name = "resig_accountlabel1";
            this.resig_accountlabel1.Size = new System.Drawing.Size(148, 18);
            this.resig_accountlabel1.TabIndex = 0;
            this.resig_accountlabel1.Text = "Register Account";
            // 
            // pictureBox4
            // 
            this.pictureBox4.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.ErrorImage")));
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.InitialImage")));
            this.pictureBox4.Location = new System.Drawing.Point(56, 210);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(24, 24);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.ErrorImage")));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.InitialImage")));
            this.pictureBox3.Location = new System.Drawing.Point(143, 14);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(70, 63);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.ErrorImage")));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(56, 165);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(56, 120);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Registerform2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(113)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(458, 435);
            this.ControlBox = false;
            this.Controls.Add(this.cross_button);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Registerform2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Registerform2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cross_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label signin_label;
        private System.Windows.Forms.Label haveaccount_label;
        private System.Windows.Forms.Button signup_button;
        private System.Windows.Forms.TextBox register_password;
        private System.Windows.Forms.TextBox register_name;
        private System.Windows.Forms.Label resig_accountlabel1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox register_cPassword;
        private System.Windows.Forms.CheckBox register_showPass;
    }
}