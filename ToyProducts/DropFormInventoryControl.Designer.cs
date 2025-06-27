namespace ToyProducts
{
    partial class DropFormInventoryControl
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
            panel2 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            name = new DataGridView();
            ID = new DataGridView();
            btnproduct = new Button();
            btnsales = new Button();
            btnproject = new Button();
            btninventory = new Button();
            btnAccountControl = new Button();
            button2 = new Button();
            panel1 = new Panel();
            buttonAccountControl = new Button();
            ((System.ComponentModel.ISupportInitialize)name).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ID).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.White;
            panel2.Location = new Point(222, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(937, 531);
            panel2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(7, 6);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(88, 19);
            label1.TabIndex = 1;
            label1.Text = "Welcome!";
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
            // ID
            // 
            ID.BackgroundColor = Color.FromArgb(110, 172, 218);
            ID.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ID.Location = new Point(72, 60);
            ID.Margin = new Padding(2);
            ID.Name = "ID";
            ID.RowHeadersWidth = 62;
            ID.Size = new Size(140, 27);
            ID.TabIndex = 4;
            // 
            // btnproduct
            // 
            btnproduct.BackColor = Color.FromArgb(110, 172, 218);
            btnproduct.Font = new Font("Arial Unicode MS", 9F);
            btnproduct.Location = new Point(7, 165);
            btnproduct.Margin = new Padding(2);
            btnproduct.Name = "btnproduct";
            btnproduct.Size = new Size(209, 44);
            btnproduct.TabIndex = 1;
            btnproduct.Text = "Product Specification Management";
            btnproduct.UseVisualStyleBackColor = false;
            // 
            // btnsales
            // 
            btnsales.BackColor = Color.FromArgb(110, 172, 218);
            btnsales.Font = new Font("Arial Unicode MS", 9F);
            btnsales.Location = new Point(7, 212);
            btnsales.Margin = new Padding(2);
            btnsales.Name = "btnsales";
            btnsales.Size = new Size(209, 44);
            btnsales.TabIndex = 5;
            btnsales.Text = "Sales Order Management";
            btnsales.UseVisualStyleBackColor = false;
            btnsales.Click += btnsales_Click;
            // 
            // btnproject
            // 
            btnproject.BackColor = Color.FromArgb(110, 172, 218);
            btnproject.Font = new Font("Arial Unicode MS", 9F);
            btnproject.Location = new Point(7, 117);
            btnproject.Margin = new Padding(2);
            btnproject.Name = "btnproject";
            btnproject.Size = new Size(209, 44);
            btnproject.TabIndex = 6;
            btnproject.Text = "Project Management";
            btnproject.UseVisualStyleBackColor = false;
            btnproject.Click += btnproject_Click;
            // 
            // btninventory
            // 
            btninventory.BackColor = Color.White;
            btninventory.Font = new Font("Arial Unicode MS", 9F);
            btninventory.Location = new Point(7, 260);
            btninventory.Margin = new Padding(2);
            btninventory.Name = "btninventory";
            btninventory.Size = new Size(209, 44);
            btninventory.TabIndex = 7;
            btninventory.Text = "Inventory Control";
            btninventory.UseVisualStyleBackColor = false;
            btninventory.Click += btninventory_Click;
            // 
            // btnAccountControl
            // 
            btnAccountControl.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAccountControl.AutoSize = true;
            btnAccountControl.BackColor = Color.FromArgb(110, 172, 218);
            btnAccountControl.Font = new Font("Arial Unicode MS", 9F);
            btnAccountControl.Location = new Point(7, 917);
            btnAccountControl.Margin = new Padding(2);
            btnAccountControl.Name = "btnAccountControl";
            btnAccountControl.Size = new Size(209, 27);
            btnAccountControl.TabIndex = 9;
            btnAccountControl.Text = "Account Control";
            btnAccountControl.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button2.AutoSize = true;
            button2.BackColor = Color.FromArgb(110, 172, 218);
            button2.Font = new Font("Arial Unicode MS", 9F);
            button2.Location = new Point(7, 461);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(209, 27);
            button2.TabIndex = 10;
            button2.Text = "System Maintenance";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(3, 52, 110);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(buttonAccountControl);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btnAccountControl);
            panel1.Controls.Add(btninventory);
            panel1.Controls.Add(btnproject);
            panel1.Controls.Add(btnsales);
            panel1.Controls.Add(btnproduct);
            panel1.Controls.Add(ID);
            panel1.Controls.Add(name);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(229, 531);
            panel1.TabIndex = 1;
            // 
            // buttonAccountControl
            // 
            buttonAccountControl.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonAccountControl.AutoSize = true;
            buttonAccountControl.BackColor = Color.FromArgb(110, 172, 218);
            buttonAccountControl.Font = new Font("Arial Unicode MS", 9F);
            buttonAccountControl.Location = new Point(7, 492);
            buttonAccountControl.Margin = new Padding(2);
            buttonAccountControl.Name = "buttonAccountControl";
            buttonAccountControl.Size = new Size(209, 27);
            buttonAccountControl.TabIndex = 10;
            buttonAccountControl.Text = "Account Control";
            buttonAccountControl.UseVisualStyleBackColor = false;
            buttonAccountControl.Click += button2_Click;
            // 
            // FormInventoryControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1159, 531);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormInventoryControl";
            Text = "InventoryControl";
            ((System.ComponentModel.ISupportInitialize)name).EndInit();
            ((System.ComponentModel.ISupportInitialize)ID).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnsystemManitenance;
        private Button buttonAccountControl;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView name;
        private DataGridView ID;
        private Button btnproduct;
        private Button btnsales;
        private Button btnproject;
        private Button btninventory;
        private Button btnAccountControl;
        private Button button2;
        private Panel panel1;
    }
}