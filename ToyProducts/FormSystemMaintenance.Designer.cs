namespace ToyProducts
{
    partial class FormSystemMaintenance
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
            labelSystemMaintenance = new Label();
            pictureBox1 = new PictureBox();
            buttonDatabaseBackup = new Button();
            buttonDatabsaseExtract = new Button();
            buttonDatabaseImport = new Button();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(buttonDatabaseImport);
            panel1.Controls.Add(buttonDatabsaseExtract);
            panel1.Controls.Add(buttonDatabaseBackup);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(labelSystemMaintenance);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(334, 231);
            panel1.TabIndex = 0;
            // 
            // labelSystemMaintenance
            // 
            labelSystemMaintenance.AutoSize = true;
            labelSystemMaintenance.BackColor = Color.White;
            labelSystemMaintenance.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSystemMaintenance.ForeColor = SystemColors.ControlText;
            labelSystemMaintenance.Location = new Point(82, 9);
            labelSystemMaintenance.Name = "labelSystemMaintenance";
            labelSystemMaintenance.Size = new Size(207, 23);
            labelSystemMaintenance.TabIndex = 35;
            labelSystemMaintenance.Text = "System Maintenance";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.icons8_maintenance_64;
            pictureBox1.Location = new Point(12, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.TabIndex = 36;
            pictureBox1.TabStop = false;
            // 
            // buttonDatabaseBackup
            // 
            buttonDatabaseBackup.Font = new Font("Arial Unicode MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 136);
            buttonDatabaseBackup.Location = new Point(146, 170);
            buttonDatabaseBackup.Name = "buttonDatabaseBackup";
            buttonDatabaseBackup.Size = new Size(121, 23);
            buttonDatabaseBackup.TabIndex = 37;
            buttonDatabaseBackup.Text = "Database Backup";
            buttonDatabaseBackup.UseVisualStyleBackColor = true;
            // 
            // buttonDatabsaseExtract
            // 
            buttonDatabsaseExtract.Font = new Font("Arial Unicode MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 136);
            buttonDatabsaseExtract.Location = new Point(146, 132);
            buttonDatabsaseExtract.Name = "buttonDatabsaseExtract";
            buttonDatabsaseExtract.Size = new Size(121, 23);
            buttonDatabsaseExtract.TabIndex = 37;
            buttonDatabsaseExtract.Text = "Database Extract";
            buttonDatabsaseExtract.UseVisualStyleBackColor = true;
            // 
            // buttonDatabaseImport
            // 
            buttonDatabaseImport.Font = new Font("Arial Unicode MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 136);
            buttonDatabaseImport.Location = new Point(146, 93);
            buttonDatabaseImport.Name = "buttonDatabaseImport";
            buttonDatabaseImport.Size = new Size(121, 23);
            buttonDatabaseImport.TabIndex = 37;
            buttonDatabaseImport.Text = "Database Import";
            buttonDatabaseImport.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.icons8_backup_100;
            pictureBox2.Location = new Point(12, 93);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 100);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // FormSystemMaintenance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 231);
            Controls.Add(panel1);
            Name = "FormSystemMaintenance";
            Text = "FormSystemMaintenance";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label labelSystemMaintenance;
        private PictureBox pictureBox1;
        private Button button3;
        private Button button2;
        private Button buttonDatabaseBackup;
        private Button buttonDatabaseImport;
        private Button buttonDatabsaseExtract;
        private PictureBox pictureBox2;
    }
}