

namespace ToyProducts
{
    partial class NewPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewPassword));
            buttonLogin = new Button();
            txtConfirmPassword = new TextBox();
            label9 = new Label();
            txtNewPassword = new TextBox();
            label8 = new Label();
            txtUserID = new TextBox();
            label7 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            panel1 = new Panel();
            butsecurity = new Button();
            butsystem = new Button();
            butinventory = new Button();
            butproject = new Button();
            butsales = new Button();
            butproduct = new Button();
            dataGridView1 = new DataGridView();
            name = new DataGridView();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)name).BeginInit();
            SuspendLayout();
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.FromArgb(2, 21, 38);
            buttonLogin.FlatAppearance.BorderColor = SystemColors.Window;
            buttonLogin.FlatAppearance.BorderSize = 0;
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogin.ForeColor = SystemColors.Window;
            buttonLogin.Location = new Point(754, 496);
            buttonLogin.Margin = new Padding(5);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(133, 42);
            buttonLogin.TabIndex = 33;
            buttonLogin.Text = "CHANGE";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click_1;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(754, 397);
            txtConfirmPassword.Margin = new Padding(5);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(357, 30);
            txtConfirmPassword.TabIndex = 32;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label9.Location = new Point(754, 359);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(216, 29);
            label9.TabIndex = 31;
            label9.Text = "Confirm Password:";
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(754, 316);
            txtNewPassword.Margin = new Padding(5);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(357, 30);
            txtNewPassword.TabIndex = 30;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label8.Location = new Point(754, 278);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(182, 29);
            label8.TabIndex = 29;
            label8.Text = "New Password:";
            // 
            // txtUserID
            // 
            txtUserID.Location = new Point(754, 220);
            txtUserID.Margin = new Padding(5);
            txtUserID.Name = "txtUserID";
            txtUserID.Size = new Size(357, 30);
            txtUserID.TabIndex = 28;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label7.Location = new Point(754, 184);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(130, 29);
            label7.TabIndex = 27;
            label7.Text = "Username:";
            // 
            // pictureBox2
            // 
            pictureBox2.ErrorImage = null;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(380, 184);
            pictureBox2.Margin = new Padding(5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(337, 355);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 26;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(363, 0);
            pictureBox1.Margin = new Padding(5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(126, 122);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 16F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(499, 0);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(348, 39);
            label3.TabIndex = 23;
            label3.Text = "System Maintenance";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(3, 52, 110);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(butsecurity);
            panel1.Controls.Add(butsystem);
            panel1.Controls.Add(butinventory);
            panel1.Controls.Add(butproject);
            panel1.Controls.Add(butsales);
            panel1.Controls.Add(butproduct);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(name);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(354, 690);
            panel1.TabIndex = 34;
            // 
            // butsecurity
            // 
            butsecurity.BackColor = Color.FromArgb(110, 172, 218);
            butsecurity.Location = new Point(10, 574);
            butsecurity.Name = "butsecurity";
            butsecurity.Size = new Size(314, 40);
            butsecurity.TabIndex = 9;
            butsecurity.Text = "Security Control";
            butsecurity.UseVisualStyleBackColor = false;
            // 
            // butsystem
            // 
            butsystem.BackColor = Color.FromArgb(110, 172, 218);
            butsystem.Location = new Point(10, 530);
            butsystem.Name = "butsystem";
            butsystem.Size = new Size(314, 40);
            butsystem.TabIndex = 8;
            butsystem.Text = "System Maintenance";
            butsystem.UseVisualStyleBackColor = false;
            // 
            // butinventory
            // 
            butinventory.BackColor = Color.FromArgb(110, 172, 218);
            butinventory.Location = new Point(10, 390);
            butinventory.Name = "butinventory";
            butinventory.Size = new Size(314, 66);
            butinventory.TabIndex = 7;
            butinventory.Text = "Inventory Control";
            butinventory.UseVisualStyleBackColor = false;
            // 
            // butproject
            // 
            butproject.BackColor = Color.FromArgb(110, 172, 218);
            butproject.Location = new Point(10, 320);
            butproject.Name = "butproject";
            butproject.Size = new Size(314, 66);
            butproject.TabIndex = 6;
            butproject.Text = "Project Management";
            butproject.UseVisualStyleBackColor = false;
            // 
            // butsales
            // 
            butsales.BackColor = Color.FromArgb(110, 172, 218);
            butsales.Location = new Point(10, 250);
            butsales.Name = "butsales";
            butsales.Size = new Size(314, 66);
            butsales.TabIndex = 5;
            butsales.Text = "Sales Order Management";
            butsales.UseVisualStyleBackColor = false;
            // 
            // butproduct
            // 
            butproduct.BackColor = Color.FromArgb(110, 172, 218);
            butproduct.Location = new Point(10, 180);
            butproduct.Name = "butproduct";
            butproduct.Size = new Size(314, 66);
            butproduct.TabIndex = 1;
            butproduct.Text = "Product Specification Management";
            butproduct.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(110, 172, 218);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(108, 90);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(210, 40);
            dataGridView1.TabIndex = 4;
            // 
            // name
            // 
            name.BackgroundColor = Color.FromArgb(110, 172, 218);
            name.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            name.Location = new Point(108, 50);
            name.Name = "name";
            name.RowHeadersWidth = 62;
            name.Size = new Size(210, 40);
            name.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(50, 90);
            label2.Name = "label2";
            label2.Size = new Size(52, 29);
            label2.TabIndex = 3;
            label2.Text = "ID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(10, 50);
            label4.Name = "label4";
            label4.Size = new Size(92, 29);
            label4.TabIndex = 2;
            label4.Text = "Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(10, 10);
            label5.Name = "label5";
            label5.Size = new Size(132, 29);
            label5.TabIndex = 1;
            label5.Text = "Welcome!";
            // 
            // NewPassword
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1234, 634);
            Controls.Add(panel1);
            Controls.Add(buttonLogin);
            Controls.Add(txtConfirmPassword);
            Controls.Add(label9);
            Controls.Add(txtNewPassword);
            Controls.Add(label8);
            Controls.Add(txtUserID);
            Controls.Add(label7);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            MaximizeBox = false;
            Name = "NewPassword";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)name).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonLogin;
        private TextBox txtConfirmPassword;
        private Label label9;
        private TextBox txtNewPassword;
        private Label label8;
        private TextBox txtUserID;
        private Label label7;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label3;
        private Panel panel1;
        private Button butsecurity;
        private Button butsystem;
        private Button butinventory;
        private Button butproject;
        private Button butsales;
        private Button butproduct;
        private DataGridView dataGridView1;
        private DataGridView name;
        private Label label2;
        private Label label4;
        private Label label5;
    }
}