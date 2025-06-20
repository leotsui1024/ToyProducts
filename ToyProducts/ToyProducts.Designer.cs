namespace ToyProducts
{
    partial class ToyProducts
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
            butsecurity = new Button();
            butsystem = new Button();
            butinventory = new Button();
            butproject = new Button();
            butsales = new Button();
            butproduct = new Button();
            dataGridView1 = new DataGridView();
            name = new DataGridView();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataproject = new DataGridView();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)name).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataproject).BeginInit();
            SuspendLayout();
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
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(237, 516);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // butsecurity
            // 
            butsecurity.BackColor = Color.FromArgb(110, 172, 218);
            butsecurity.Location = new Point(7, 473);
            butsecurity.Margin = new Padding(2);
            butsecurity.Name = "butsecurity";
            butsecurity.Size = new Size(209, 27);
            butsecurity.TabIndex = 9;
            butsecurity.Text = "Security Control";
            butsecurity.UseVisualStyleBackColor = false;
            // 
            // butsystem
            // 
            butsystem.BackColor = Color.FromArgb(110, 172, 218);
            butsystem.Location = new Point(7, 442);
            butsystem.Margin = new Padding(2);
            butsystem.Name = "butsystem";
            butsystem.Size = new Size(209, 27);
            butsystem.TabIndex = 8;
            butsystem.Text = "System Maintenance";
            butsystem.UseVisualStyleBackColor = false;
            // 
            // butinventory
            // 
            butinventory.BackColor = Color.FromArgb(110, 172, 218);
            butinventory.Location = new Point(7, 260);
            butinventory.Margin = new Padding(2);
            butinventory.Name = "butinventory";
            butinventory.Size = new Size(209, 44);
            butinventory.TabIndex = 7;
            butinventory.Text = "Inventory Control";
            butinventory.UseVisualStyleBackColor = false;
            // 
            // butproject
            // 
            butproject.BackColor = Color.FromArgb(110, 172, 218);
            butproject.Location = new Point(7, 213);
            butproject.Margin = new Padding(2);
            butproject.Name = "butproject";
            butproject.Size = new Size(209, 44);
            butproject.TabIndex = 6;
            butproject.Text = "Project Management";
            butproject.UseVisualStyleBackColor = false;
            // 
            // butsales
            // 
            butsales.BackColor = Color.FromArgb(110, 172, 218);
            butsales.Location = new Point(7, 167);
            butsales.Margin = new Padding(2);
            butsales.Name = "butsales";
            butsales.Size = new Size(209, 44);
            butsales.TabIndex = 5;
            butsales.Text = "Sales Order Management";
            butsales.UseVisualStyleBackColor = false;
            // 
            // butproduct
            // 
            butproduct.BackColor = Color.FromArgb(110, 172, 218);
            butproduct.Location = new Point(7, 120);
            butproduct.Margin = new Padding(2);
            butproduct.Name = "butproduct";
            butproduct.Size = new Size(209, 44);
            butproduct.TabIndex = 1;
            butproduct.Text = "Product Specification Management";
            butproduct.UseVisualStyleBackColor = false;
            butproduct.Click += butproduct_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(110, 172, 218);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(72, 60);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(140, 27);
            dataGridView1.TabIndex = 4;
            // 
            // name
            // 
            name.BackgroundColor = Color.FromArgb(110, 172, 218);
            name.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            name.Location = new Point(72, 33);
            name.Margin = new Padding(2);
            name.Name = "name";
            name.RowHeadersWidth = 62;
            name.Size = new Size(140, 27);
            name.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(33, 60);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(34, 19);
            label3.TabIndex = 3;
            label3.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(7, 33);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(62, 19);
            label2.TabIndex = 2;
            label2.Text = "Name:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(7, 7);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(88, 19);
            label1.TabIndex = 1;
            label1.Text = "Welcome!";
            // 
            // dataproject
            // 
            dataproject.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataproject.Location = new Point(243, 120);
            dataproject.Margin = new Padding(2);
            dataproject.Name = "dataproject";
            dataproject.RowHeadersWidth = 62;
            dataproject.Size = new Size(786, 396);
            dataproject.TabIndex = 1;
            dataproject.CellContentClick += dataproject_CellContentClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(243, 7);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(179, 19);
            label4.TabIndex = 10;
            label4.Text = "Project Management";
            // 
            // ToyProducts
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1041, 524);
            Controls.Add(label4);
            Controls.Add(dataproject);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "ToyProducts";
            Text = "ToyProducts";
            Load += ToyProducts_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)name).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataproject).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private DataGridView name;
        private Label label3;
        private DataGridView dataGridView1;
        private Button butproduct;
        private Button butsales;
        private Button butinventory;
        private Button butproject;
        private Button butsecurity;
        private Button butsystem;
        private DataGridView dataproject;
        private Label label4;
    }
}