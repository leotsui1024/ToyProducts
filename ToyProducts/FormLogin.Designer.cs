namespace ToyProducts
{
    partial class FormLogin
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textUserName = new TextBox();
            textUserPassword = new TextBox();
            btnLogin = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(3, 52, 110);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(281, 448);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.user;
            pictureBox1.Location = new Point(83, 63);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(12, 412);
            label2.Name = "label2";
            label2.Size = new Size(236, 29);
            label2.TabIndex = 2;
            label2.Text = "Management System";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(12, 207);
            label1.Name = "label1";
            label1.Size = new Size(246, 66);
            label1.TabIndex = 1;
            label1.Text = "Smile and \r\nSunshine Toy Co.\r\n";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Window;
            label3.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            label3.Location = new Point(287, 63);
            label3.Name = "label3";
            label3.Size = new Size(122, 37);
            label3.TabIndex = 1;
            label3.Text = "LOGIN";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F);
            label4.Location = new Point(343, 134);
            label4.Name = "label4";
            label4.Size = new Size(130, 29);
            label4.TabIndex = 2;
            label4.Text = "Username:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F);
            label5.Location = new Point(347, 244);
            label5.Name = "label5";
            label5.Size = new Size(126, 29);
            label5.TabIndex = 3;
            label5.Text = "Password:";
            // 
            // textUserName
            // 
            textUserName.Location = new Point(347, 166);
            textUserName.Name = "textUserName";
            textUserName.Size = new Size(382, 30);
            textUserName.TabIndex = 4;
            // 
            // textUserPassword
            // 
            textUserPassword.Location = new Point(347, 276);
            textUserPassword.Name = "textUserPassword";
            textUserPassword.Size = new Size(382, 30);
            textUserPassword.TabIndex = 5;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(2, 21, 38);
            btnLogin.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnLogin.ForeColor = SystemColors.Window;
            btnLogin.Location = new Point(343, 361);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(130, 54);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogin);
            Controls.Add(textUserPassword);
            Controls.Add(textUserName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormLogin";
            Text = "FormLogin";
            Load += FormLogin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textUserName;
        private TextBox textUserPassword;
        private Button btnLogin;
    }
}