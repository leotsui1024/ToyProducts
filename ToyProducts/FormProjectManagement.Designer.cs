namespace ToyProducts
{
    partial class FormProjectManagement
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
            dataGridView1 = new DataGridView();
            buttonSearchProductSpecification = new Button();
            labelProjectManagement = new Label();
            buttonDeleteSalesOrder = new Button();
            buttonCreateProject = new Button();
            textBox1 = new TextBox();
            labelSearchByID = new Label();
            buttonEditSalesOrder = new Button();
            panel1 = new Panel();
            buttonAccountControl = new Button();
            buttonSystemMaintenance = new Button();
            buttonInventoryControl = new Button();
            buttonProductSpecificationManagement = new Button();
            buttonProjectManagement = new Button();
            buttonSalesOrderManagement = new Button();
            iD = new DataGridView();
            name = new DataGridView();
            labelId = new Label();
            labelName = new Label();
            labelWelcome = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)name).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.White;
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(buttonSearchProductSpecification);
            panel2.Controls.Add(labelProjectManagement);
            panel2.Controls.Add(buttonDeleteSalesOrder);
            panel2.Controls.Add(buttonCreateProject);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(labelSearchByID);
            panel2.Controls.Add(buttonEditSalesOrder);
            panel2.Location = new Point(222, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(937, 531);
            panel2.TabIndex = 6;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(8, 121);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(913, 401);
            dataGridView1.TabIndex = 24;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // buttonSearchProductSpecification
            // 
            buttonSearchProductSpecification.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSearchProductSpecification.Location = new Point(206, 81);
            buttonSearchProductSpecification.Name = "buttonSearchProductSpecification";
            buttonSearchProductSpecification.Size = new Size(98, 27);
            buttonSearchProductSpecification.TabIndex = 17;
            buttonSearchProductSpecification.Text = "Search";
            buttonSearchProductSpecification.UseVisualStyleBackColor = true;
            // 
            // labelProjectManagement
            // 
            labelProjectManagement.AutoSize = true;
            labelProjectManagement.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelProjectManagement.Location = new Point(8, 12);
            labelProjectManagement.Name = "labelProjectManagement";
            labelProjectManagement.Size = new Size(207, 23);
            labelProjectManagement.TabIndex = 22;
            labelProjectManagement.Text = "Project Management";
            // 
            // buttonDeleteSalesOrder
            // 
            buttonDeleteSalesOrder.Font = new Font("Arial", 9.75F);
            buttonDeleteSalesOrder.Location = new Point(268, 41);
            buttonDeleteSalesOrder.Name = "buttonDeleteSalesOrder";
            buttonDeleteSalesOrder.Size = new Size(115, 27);
            buttonDeleteSalesOrder.TabIndex = 18;
            buttonDeleteSalesOrder.Text = "Delete Project";
            buttonDeleteSalesOrder.UseVisualStyleBackColor = true;
            // 
            // buttonCreateProject
            // 
            buttonCreateProject.Font = new Font("Arial", 9.75F);
            buttonCreateProject.Location = new Point(8, 41);
            buttonCreateProject.Name = "buttonCreateProject";
            buttonCreateProject.Size = new Size(115, 27);
            buttonCreateProject.TabIndex = 20;
            buttonCreateProject.Text = "Create Project";
            buttonCreateProject.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            textBox1.Location = new Point(89, 80);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 28);
            textBox1.TabIndex = 21;
            // 
            // labelSearchByID
            // 
            labelSearchByID.AutoSize = true;
            labelSearchByID.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSearchByID.Location = new Point(12, 85);
            labelSearchByID.Name = "labelSearchByID";
            labelSearchByID.Size = new Size(80, 17);
            labelSearchByID.TabIndex = 23;
            labelSearchByID.Text = "Project ID: ";
            // 
            // buttonEditSalesOrder
            // 
            buttonEditSalesOrder.Font = new Font("Arial", 9.75F);
            buttonEditSalesOrder.Location = new Point(138, 41);
            buttonEditSalesOrder.Name = "buttonEditSalesOrder";
            buttonEditSalesOrder.Size = new Size(115, 27);
            buttonEditSalesOrder.TabIndex = 19;
            buttonEditSalesOrder.Text = "Edit Project";
            buttonEditSalesOrder.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(3, 52, 110);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(buttonAccountControl);
            panel1.Controls.Add(buttonSystemMaintenance);
            panel1.Controls.Add(buttonInventoryControl);
            panel1.Controls.Add(buttonProductSpecificationManagement);
            panel1.Controls.Add(buttonProjectManagement);
            panel1.Controls.Add(buttonSalesOrderManagement);
            panel1.Controls.Add(iD);
            panel1.Controls.Add(name);
            panel1.Controls.Add(labelId);
            panel1.Controls.Add(labelName);
            panel1.Controls.Add(labelWelcome);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(229, 531);
            panel1.TabIndex = 5;
            // 
            // buttonAccountControl
            // 
            buttonAccountControl.BackColor = Color.FromArgb(110, 172, 218);
            buttonAccountControl.Font = new Font("Arial Unicode MS", 9F);
            buttonAccountControl.Location = new Point(7, 492);
            buttonAccountControl.Margin = new Padding(2);
            buttonAccountControl.Name = "buttonAccountControl";
            buttonAccountControl.Size = new Size(209, 27);
            buttonAccountControl.TabIndex = 13;
            buttonAccountControl.Text = "Account Control";
            buttonAccountControl.UseVisualStyleBackColor = false;
            buttonAccountControl.Click += buttonAccountControl_Click;
            // 
            // buttonSystemMaintenance
            // 
            buttonSystemMaintenance.BackColor = Color.FromArgb(110, 172, 218);
            buttonSystemMaintenance.Font = new Font("Arial Unicode MS", 9F);
            buttonSystemMaintenance.Location = new Point(7, 461);
            buttonSystemMaintenance.Margin = new Padding(2);
            buttonSystemMaintenance.Name = "buttonSystemMaintenance";
            buttonSystemMaintenance.Size = new Size(209, 27);
            buttonSystemMaintenance.TabIndex = 12;
            buttonSystemMaintenance.Text = "System Maintenance";
            buttonSystemMaintenance.UseVisualStyleBackColor = false;
            buttonSystemMaintenance.Click += buttonSystemMaintenance_Click;
            // 
            // buttonInventoryControl
            // 
            buttonInventoryControl.BackColor = Color.FromArgb(110, 172, 218);
            buttonInventoryControl.Font = new Font("Arial Unicode MS", 9F);
            buttonInventoryControl.Location = new Point(7, 260);
            buttonInventoryControl.Margin = new Padding(2);
            buttonInventoryControl.Name = "buttonInventoryControl";
            buttonInventoryControl.Size = new Size(209, 44);
            buttonInventoryControl.TabIndex = 7;
            buttonInventoryControl.Text = "Inventory Control";
            buttonInventoryControl.UseVisualStyleBackColor = false;
            buttonInventoryControl.Click += buttonInventoryControl_Click;
            // 
            // buttonProductSpecificationManagement
            // 
            buttonProductSpecificationManagement.BackColor = Color.FromArgb(110, 172, 218);
            buttonProductSpecificationManagement.Font = new Font("Arial Unicode MS", 9F);
            buttonProductSpecificationManagement.Location = new Point(7, 165);
            buttonProductSpecificationManagement.Margin = new Padding(2);
            buttonProductSpecificationManagement.Name = "buttonProductSpecificationManagement";
            buttonProductSpecificationManagement.Size = new Size(209, 44);
            buttonProductSpecificationManagement.TabIndex = 6;
            buttonProductSpecificationManagement.Text = "Product Specification Management";
            buttonProductSpecificationManagement.UseVisualStyleBackColor = false;
            buttonProductSpecificationManagement.Click += buttonProductSpecificationManagement_Click;
            // 
            // buttonProjectManagement
            // 
            buttonProjectManagement.BackColor = Color.White;
            buttonProjectManagement.Font = new Font("Arial Unicode MS", 9F);
            buttonProjectManagement.Location = new Point(7, 117);
            buttonProjectManagement.Margin = new Padding(2);
            buttonProjectManagement.Name = "buttonProjectManagement";
            buttonProjectManagement.Size = new Size(209, 44);
            buttonProjectManagement.TabIndex = 6;
            buttonProjectManagement.Text = "Project Management";
            buttonProjectManagement.UseVisualStyleBackColor = false;
            buttonProjectManagement.Click += buttonProjectManagement_Click;
            // 
            // buttonSalesOrderManagement
            // 
            buttonSalesOrderManagement.BackColor = Color.FromArgb(110, 172, 218);
            buttonSalesOrderManagement.Font = new Font("Arial Unicode MS", 9F);
            buttonSalesOrderManagement.Location = new Point(7, 212);
            buttonSalesOrderManagement.Margin = new Padding(2);
            buttonSalesOrderManagement.Name = "buttonSalesOrderManagement";
            buttonSalesOrderManagement.Size = new Size(209, 44);
            buttonSalesOrderManagement.TabIndex = 5;
            buttonSalesOrderManagement.Text = "Sales Order Management";
            buttonSalesOrderManagement.UseVisualStyleBackColor = false;
            buttonSalesOrderManagement.Click += buttonSalesOrderManagement_Click;
            // 
            // iD
            // 
            iD.BackgroundColor = Color.FromArgb(110, 172, 218);
            iD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            iD.Location = new Point(72, 60);
            iD.Margin = new Padding(2);
            iD.Name = "iD";
            iD.RowHeadersWidth = 62;
            iD.Size = new Size(140, 27);
            iD.TabIndex = 4;
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
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            labelId.ForeColor = SystemColors.Control;
            labelId.Location = new Point(33, 60);
            labelId.Margin = new Padding(2, 0, 2, 0);
            labelId.Name = "labelId";
            labelId.Size = new Size(34, 19);
            labelId.TabIndex = 3;
            labelId.Text = "ID:";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            labelName.ForeColor = SystemColors.Control;
            labelName.Location = new Point(7, 33);
            labelName.Margin = new Padding(2, 0, 2, 0);
            labelName.Name = "labelName";
            labelName.Size = new Size(62, 19);
            labelName.TabIndex = 2;
            labelName.Text = "Name:";
            // 
            // labelWelcome
            // 
            labelWelcome.AutoSize = true;
            labelWelcome.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            labelWelcome.ForeColor = SystemColors.Control;
            labelWelcome.Location = new Point(7, 6);
            labelWelcome.Margin = new Padding(2, 0, 2, 0);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(88, 19);
            labelWelcome.TabIndex = 1;
            labelWelcome.Text = "Welcome!";
            // 
            // FormProjectManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1159, 531);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormProjectManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CMS";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iD).EndInit();
            ((System.ComponentModel.ISupportInitialize)name).EndInit();
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
        private DataGridView iD;
        private DataGridView name;
        private Label labelId;
        private Label labelName;
        private Label labelWelcome;
        private DataGridView dataGridView1;
        private Button buttonSearchProductSpecification;
        private Label labelProjectManagement;
        private Button buttonDeleteSalesOrder;
        private Button buttonCreateProject;
        private TextBox textBox1;
        private Label labelSearchByID;
        private Button buttonEditSalesOrder;
    }
}