namespace ToyProducts
{
    partial class FormInventoryControl
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
            panel1 = new Panel();
            txtStaffID = new TextBox();
            txtStaffName = new TextBox();
            buttonAccountControl = new Button();
            buttonSystemMaintenance = new Button();
            buttonInventoryControl = new Button();
            buttonProductSpecificationManagement = new Button();
            buttonProjectManagement = new Button();
            buttonSalesOrderManagement = new Button();
            labelId = new Label();
            labelName = new Label();
            labelWelcome = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.White;
            panel2.Location = new Point(349, 0);
            panel2.Margin = new Padding(5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1472, 814);
            panel2.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(3, 52, 110);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtStaffID);
            panel1.Controls.Add(txtStaffName);
            panel1.Controls.Add(buttonAccountControl);
            panel1.Controls.Add(buttonSystemMaintenance);
            panel1.Controls.Add(buttonInventoryControl);
            panel1.Controls.Add(buttonProductSpecificationManagement);
            panel1.Controls.Add(buttonProjectManagement);
            panel1.Controls.Add(buttonSalesOrderManagement);
            panel1.Controls.Add(labelId);
            panel1.Controls.Add(labelName);
            panel1.Controls.Add(labelWelcome);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(359, 814);
            panel1.TabIndex = 5;
            // 
            // txtStaffID
            // 
            txtStaffID.Location = new Point(113, 95);
            txtStaffID.Name = "txtStaffID";
            txtStaffID.ReadOnly = true;
            txtStaffID.Size = new Size(220, 30);
            txtStaffID.TabIndex = 15;
            // 
            // txtStaffName
            // 
            txtStaffName.Location = new Point(113, 54);
            txtStaffName.Name = "txtStaffName";
            txtStaffName.ReadOnly = true;
            txtStaffName.Size = new Size(220, 30);
            txtStaffName.TabIndex = 14;
            // 
            // buttonAccountControl
            // 
            buttonAccountControl.BackColor = Color.FromArgb(110, 172, 218);
            buttonAccountControl.Font = new Font("Microsoft Sans Serif", 9F);
            buttonAccountControl.Location = new Point(11, 754);
            buttonAccountControl.Name = "buttonAccountControl";
            buttonAccountControl.Size = new Size(328, 41);
            buttonAccountControl.TabIndex = 13;
            buttonAccountControl.Text = "Account Control";
            buttonAccountControl.UseVisualStyleBackColor = false;
            buttonAccountControl.Click += buttonAccountControl_Click;
            // 
            // buttonSystemMaintenance
            // 
            buttonSystemMaintenance.BackColor = Color.FromArgb(110, 172, 218);
            buttonSystemMaintenance.Font = new Font("Microsoft Sans Serif", 9F);
            buttonSystemMaintenance.Location = new Point(11, 707);
            buttonSystemMaintenance.Name = "buttonSystemMaintenance";
            buttonSystemMaintenance.Size = new Size(328, 41);
            buttonSystemMaintenance.TabIndex = 12;
            buttonSystemMaintenance.Text = "System Maintenance";
            buttonSystemMaintenance.UseVisualStyleBackColor = false;
            buttonSystemMaintenance.Click += buttonSystemMaintenance_Click;
            // 
            // buttonInventoryControl
            // 
            buttonInventoryControl.BackColor = Color.White;
            buttonInventoryControl.Font = new Font("Microsoft Sans Serif", 9F);
            buttonInventoryControl.Location = new Point(11, 399);
            buttonInventoryControl.Name = "buttonInventoryControl";
            buttonInventoryControl.Size = new Size(328, 67);
            buttonInventoryControl.TabIndex = 7;
            buttonInventoryControl.Text = "Inventory Control";
            buttonInventoryControl.UseVisualStyleBackColor = false;
            buttonInventoryControl.Click += buttonInventoryControl_Click;
            // 
            // buttonProductSpecificationManagement
            // 
            buttonProductSpecificationManagement.BackColor = Color.FromArgb(110, 172, 218);
            buttonProductSpecificationManagement.Font = new Font("Microsoft Sans Serif", 9F);
            buttonProductSpecificationManagement.Location = new Point(11, 253);
            buttonProductSpecificationManagement.Name = "buttonProductSpecificationManagement";
            buttonProductSpecificationManagement.Size = new Size(328, 67);
            buttonProductSpecificationManagement.TabIndex = 6;
            buttonProductSpecificationManagement.Text = "Product Specification Management";
            buttonProductSpecificationManagement.UseVisualStyleBackColor = false;
            buttonProductSpecificationManagement.Click += buttonProductSpecificationManagement_Click;
            // 
            // buttonProjectManagement
            // 
            buttonProjectManagement.BackColor = Color.FromArgb(110, 172, 218);
            buttonProjectManagement.Font = new Font("Microsoft Sans Serif", 9F);
            buttonProjectManagement.Location = new Point(11, 179);
            buttonProjectManagement.Name = "buttonProjectManagement";
            buttonProjectManagement.Size = new Size(328, 67);
            buttonProjectManagement.TabIndex = 6;
            buttonProjectManagement.Text = "Project Management";
            buttonProjectManagement.UseVisualStyleBackColor = false;
            buttonProjectManagement.Click += buttonProjectManagement_Click;
            // 
            // buttonSalesOrderManagement
            // 
            buttonSalesOrderManagement.BackColor = Color.FromArgb(110, 172, 218);
            buttonSalesOrderManagement.Font = new Font("Microsoft Sans Serif", 9F);
            buttonSalesOrderManagement.Location = new Point(11, 325);
            buttonSalesOrderManagement.Name = "buttonSalesOrderManagement";
            buttonSalesOrderManagement.Size = new Size(328, 67);
            buttonSalesOrderManagement.TabIndex = 5;
            buttonSalesOrderManagement.Text = "Sales Order Management";
            buttonSalesOrderManagement.UseVisualStyleBackColor = false;
            buttonSalesOrderManagement.Click += buttonSalesOrderManagement_Click;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            labelId.ForeColor = SystemColors.Control;
            labelId.Location = new Point(52, 92);
            labelId.Name = "labelId";
            labelId.Size = new Size(52, 29);
            labelId.TabIndex = 3;
            labelId.Text = "ID:";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            labelName.ForeColor = SystemColors.Control;
            labelName.Location = new Point(11, 51);
            labelName.Name = "labelName";
            labelName.Size = new Size(92, 29);
            labelName.TabIndex = 2;
            labelName.Text = "Name:";
            // 
            // labelWelcome
            // 
            labelWelcome.AutoSize = true;
            labelWelcome.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            labelWelcome.ForeColor = SystemColors.Control;
            labelWelcome.Location = new Point(11, 9);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(132, 29);
            labelWelcome.TabIndex = 1;
            labelWelcome.Text = "Welcome!";
            // 
            // FormInventoryControl
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1821, 814);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(5);
            Name = "FormInventoryControl";
            Text = "FormInventoryControl";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Panel panel1;
        private Button buttonAccountControl;
        private Button buttonSystemMaintenance;
        private Button buttonInventoryControl;
        private Button buttonProductSpecificationManagement;
        private Button buttonProjectManagement;
        private Button buttonSalesOrderManagement;
        private Label labelId;
        private Label labelName;
        private Label labelWelcome;
        private TextBox txtStaffID;
        private TextBox txtStaffName;
    }
}