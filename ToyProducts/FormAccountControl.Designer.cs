namespace ToyProducts
{
    partial class FormAccountControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAccountControl));
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
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
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
            buttonLogin.Location = new Point(250, 323);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(85, 27);
            buttonLogin.TabIndex = 43;
            buttonLogin.Text = "CHANGE";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(250, 259);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(229, 23);
            txtConfirmPassword.TabIndex = 42;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label9.Location = new Point(250, 234);
            label9.Name = "label9";
            label9.Size = new Size(141, 20);
            label9.TabIndex = 41;
            label9.Text = "Confirm Password:";
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(250, 206);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(229, 23);
            txtNewPassword.TabIndex = 40;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label8.Location = new Point(250, 181);
            label8.Name = "label8";
            label8.Size = new Size(117, 20);
            label8.TabIndex = 39;
            label8.Text = "New Password:";
            // 
            // txtUserID
            // 
            txtUserID.Location = new Point(250, 143);
            txtUserID.Name = "txtUserID";
            txtUserID.Size = new Size(229, 23);
            txtUserID.TabIndex = 38;
            txtUserID.Visible = false;
            txtUserID.TextChanged += txtUserID_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label7.Location = new Point(250, 120);
            label7.Name = "label7";
            label7.Size = new Size(87, 20);
            label7.TabIndex = 37;
            label7.Text = "Username:";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.ErrorImage = null;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(16, 120);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(214, 232);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 36;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(11, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 35;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Tahoma", 16F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(98, 11);
            label3.Name = "label3";
            label3.Size = new Size(191, 27);
            label3.TabIndex = 34;
            label3.Text = "Account Control";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(499, 391);
            panel1.TabIndex = 44;
            // 
            // FormAccountControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(499, 391);
            Controls.Add(buttonLogin);
            Controls.Add(txtConfirmPassword);
            Controls.Add(label9);
            Controls.Add(txtNewPassword);
            Controls.Add(label8);
            Controls.Add(txtUserID);
            Controls.Add(label7);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Name = "FormAccountControl";
            Text = "AccountControl";
            Load += AccountControl_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
    }
}