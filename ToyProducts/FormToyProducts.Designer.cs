


namespace ToyProducts
{
    partial class FormToyProducts
    {
       // private System.Windows.Forms.TextBox textPCat;
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
            btnAccountControl = new Button();
            btnsystemManitenance = new Button();
            btninventory = new Button();
            btnproject = new Button();
            btnsales = new Button();
            btnproduct = new Button();
            dataGridView1 = new DataGridView();
            name = new DataGridView();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataproject = new DataGridView();
            label4 = new Label();
            PID = new Label();
            textNName = new TextBox();
            PName = new Label();
            textNost = new TextBox();
            textCost = new TextBox();
            PCost = new Label();
            textNPrice = new TextBox();
            textPrice = new TextBox();
            PPrice = new Label();
            PQty = new Label();
            textQty = new TextBox();
            textNQty = new TextBox();
            textPCat = new TextBox();
            PCat = new Label();
            textPStat = new TextBox();
            PStat = new Label();
            cboNPCat = new ComboBox();
            cboNPStat = new ComboBox();
            panel2 = new Panel();
            textName = new TextBox();
            cboID = new ComboBox();
            panel3 = new Panel();
            panel4 = new Panel();
            btnFirst = new Button();
            btnLast = new Button();
            btnRenew = new Button();
            btnPrevious = new Button();
            btnNext = new Button();
            btnSave = new Button();
            btnReduction = new Button();
            btnRefresh = new Button();
            panel5 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)name).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataproject).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(3, 52, 110);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnAccountControl);
            panel1.Controls.Add(btnsystemManitenance);
            panel1.Controls.Add(btninventory);
            panel1.Controls.Add(btnproject);
            panel1.Controls.Add(btnsales);
            panel1.Controls.Add(btnproduct);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(name);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(231, 531);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnAccountControl
            // 
            btnAccountControl.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAccountControl.AutoSize = true;
            btnAccountControl.BackColor = Color.FromArgb(110, 172, 218);
            btnAccountControl.Font = new Font("Arial Unicode MS", 9F);
            btnAccountControl.Location = new Point(7, 492);
            btnAccountControl.Margin = new Padding(2);
            btnAccountControl.Name = "btnAccountControl";
            btnAccountControl.Size = new Size(209, 27);
            btnAccountControl.TabIndex = 9;
            btnAccountControl.Text = "Account Control";
            btnAccountControl.UseVisualStyleBackColor = false;
            btnAccountControl.Click += btnAccountControl_Click;
            // 
            // btnsystemManitenance
            // 
            btnsystemManitenance.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnsystemManitenance.AutoSize = true;
            btnsystemManitenance.BackColor = Color.FromArgb(110, 172, 218);
            btnsystemManitenance.Font = new Font("Arial Unicode MS", 9F);
            btnsystemManitenance.Location = new Point(7, 461);
            btnsystemManitenance.Margin = new Padding(2);
            btnsystemManitenance.Name = "btnsystemManitenance";
            btnsystemManitenance.Size = new Size(209, 27);
            btnsystemManitenance.TabIndex = 8;
            btnsystemManitenance.Text = "System Maintenance";
            btnsystemManitenance.UseVisualStyleBackColor = false;
            btnsystemManitenance.Click += btnsystemMaintenance_Click;
            // 
            // btninventory
            // 
            btninventory.AutoSize = true;
            btninventory.BackColor = Color.FromArgb(110, 172, 218);
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
            // btnproject
            // 
            btnproject.AutoSize = true;
            btnproject.BackColor = Color.White;
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
            // btnsales
            // 
            btnsales.AutoSize = true;
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
            // btnproduct
            // 
            btnproduct.AutoSize = true;
            btnproduct.BackColor = Color.FromArgb(110, 172, 218);
            btnproduct.Font = new Font("Arial Unicode MS", 9F);
            btnproduct.Location = new Point(7, 165);
            btnproduct.Margin = new Padding(2);
            btnproduct.Name = "btnproduct";
            btnproduct.Size = new Size(209, 44);
            btnproduct.TabIndex = 1;
            btnproduct.Text = "Product Specification Management";
            btnproduct.UseVisualStyleBackColor = false;
            btnproduct.Click += btnproduct_Click;
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
            label1.Location = new Point(7, 6);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(88, 19);
            label1.TabIndex = 1;
            label1.Text = "Welcome!";
            // 
            // dataproject
            // 
            dataproject.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataproject.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataproject.Location = new Point(235, 120);
            dataproject.Margin = new Padding(2);
            dataproject.Name = "dataproject";
            dataproject.RowHeadersWidth = 62;
            dataproject.Size = new Size(913, 400);
            dataproject.TabIndex = 1;
            dataproject.CellContentClick += dataproject_CellContentClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(243, 7);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(179, 19);
            label4.TabIndex = 10;
            label4.Text = "Project Management";
            // 
            // PID
            // 
            PID.AutoSize = true;
            PID.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            PID.Location = new Point(95, 32);
            PID.Name = "PID";
            PID.Size = new Size(28, 19);
            PID.TabIndex = 11;
            PID.Text = "ID";
            // 
            // textNName
            // 
            textNName.Location = new Point(129, 31);
            textNName.Name = "textNName";
            textNName.Size = new Size(132, 23);
            textNName.TabIndex = 16;
            // 
            // PName
            // 
            PName.AutoSize = true;
            PName.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            PName.Location = new Point(67, 4);
            PName.Name = "PName";
            PName.Size = new Size(56, 19);
            PName.TabIndex = 14;
            PName.Text = "Name";
            // 
            // textNost
            // 
            textNost.Location = new Point(60, 31);
            textNost.Name = "textNost";
            textNost.Size = new Size(45, 23);
            textNost.TabIndex = 19;
            // 
            // textCost
            // 
            textCost.Location = new Point(60, 3);
            textCost.Name = "textCost";
            textCost.ReadOnly = true;
            textCost.Size = new Size(45, 23);
            textCost.TabIndex = 18;
            // 
            // PCost
            // 
            PCost.AutoSize = true;
            PCost.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            PCost.Location = new Point(9, 8);
            PCost.Name = "PCost";
            PCost.Size = new Size(45, 19);
            PCost.TabIndex = 17;
            PCost.Text = "Cost";
            // 
            // textNPrice
            // 
            textNPrice.Location = new Point(167, 31);
            textNPrice.Name = "textNPrice";
            textNPrice.Size = new Size(45, 23);
            textNPrice.TabIndex = 22;
            // 
            // textPrice
            // 
            textPrice.Location = new Point(167, 3);
            textPrice.Name = "textPrice";
            textPrice.ReadOnly = true;
            textPrice.Size = new Size(45, 23);
            textPrice.TabIndex = 21;
            // 
            // PPrice
            // 
            PPrice.AutoSize = true;
            PPrice.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            PPrice.Location = new Point(111, 7);
            PPrice.Name = "PPrice";
            PPrice.Size = new Size(50, 19);
            PPrice.TabIndex = 20;
            PPrice.Text = "Price";
            // 
            // PQty
            // 
            PQty.AutoSize = true;
            PQty.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            PQty.Location = new Point(218, 7);
            PQty.Name = "PQty";
            PQty.Size = new Size(37, 19);
            PQty.TabIndex = 23;
            PQty.Text = "Qty";
            // 
            // textQty
            // 
            textQty.Location = new Point(261, 3);
            textQty.Name = "textQty";
            textQty.ReadOnly = true;
            textQty.Size = new Size(45, 23);
            textQty.TabIndex = 24;
            // 
            // textNQty
            // 
            textNQty.Location = new Point(261, 31);
            textNQty.Name = "textNQty";
            textNQty.Size = new Size(45, 23);
            textNQty.TabIndex = 29;
            // 
            // textPCat
            // 
            textPCat.Location = new Point(90, 4);
            textPCat.Name = "textPCat";
            textPCat.ReadOnly = true;
            textPCat.Size = new Size(45, 23);
            textPCat.TabIndex = 31;
            // 
            // PCat
            // 
            PCat.AutoSize = true;
            PCat.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            PCat.Location = new Point(1, 4);
            PCat.Name = "PCat";
            PCat.Size = new Size(83, 19);
            PCat.TabIndex = 30;
            PCat.Text = "Category";
            // 
            // textPStat
            // 
            textPStat.Location = new Point(217, 4);
            textPStat.Name = "textPStat";
            textPStat.ReadOnly = true;
            textPStat.Size = new Size(45, 23);
            textPStat.TabIndex = 33;
            textPStat.TextChanged += textPStat_TextChanged;
            // 
            // PStat
            // 
            PStat.AutoSize = true;
            PStat.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            PStat.Location = new Point(141, 4);
            PStat.Name = "PStat";
            PStat.Size = new Size(61, 19);
            PStat.TabIndex = 32;
            PStat.Text = "Status";
            // 
            // cboNPCat
            // 
            cboNPCat.FormattingEnabled = true;
            cboNPCat.Items.AddRange(new object[] { "Toy", "Plush", "Model", "Vehicle", "Construction", "Other" });
            cboNPCat.Location = new Point(14, 31);
            cboNPCat.Name = "cboNPCat";
            cboNPCat.Size = new Size(121, 23);
            cboNPCat.TabIndex = 34;
            cboNPCat.Text = "Toy";
            // 
            // cboNPStat
            // 
            cboNPStat.FormattingEnabled = true;
            cboNPStat.Items.AddRange(new object[] { "Active", "Inactive" });
            cboNPStat.Location = new Point(141, 31);
            cboNPStat.Name = "cboNPStat";
            cboNPStat.Size = new Size(121, 23);
            cboNPStat.TabIndex = 35;
            cboNPStat.Text = "Active";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDark;
            panel2.Controls.Add(textName);
            panel2.Controls.Add(cboID);
            panel2.Controls.Add(PID);
            panel2.Controls.Add(PName);
            panel2.Controls.Add(textNName);
            panel2.Location = new Point(13, 29);
            panel2.Name = "panel2";
            panel2.Size = new Size(274, 60);
            panel2.TabIndex = 10;
            // 
            // textName
            // 
            textName.Location = new Point(129, 3);
            textName.Name = "textName";
            textName.Size = new Size(132, 23);
            textName.TabIndex = 38;
            // 
            // cboID
            // 
            cboID.FormattingEnabled = true;
            cboID.Location = new Point(6, 31);
            cboID.Name = "cboID";
            cboID.Size = new Size(58, 23);
            cboID.TabIndex = 36;
            cboID.SelectedIndexChanged += cboID_SelectedIndexChanged_1;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlDark;
            panel3.Controls.Add(textNQty);
            panel3.Controls.Add(textQty);
            panel3.Controls.Add(PQty);
            panel3.Controls.Add(textNPrice);
            panel3.Controls.Add(textPrice);
            panel3.Controls.Add(PPrice);
            panel3.Controls.Add(textNost);
            panel3.Controls.Add(textCost);
            panel3.Controls.Add(PCost);
            panel3.Location = new Point(297, 28);
            panel3.Name = "panel3";
            panel3.Size = new Size(321, 60);
            panel3.TabIndex = 36;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ControlDark;
            panel4.Controls.Add(cboNPStat);
            panel4.Controls.Add(cboNPCat);
            panel4.Controls.Add(textPStat);
            panel4.Controls.Add(PStat);
            panel4.Controls.Add(textPCat);
            panel4.Controls.Add(PCat);
            panel4.Location = new Point(631, 29);
            panel4.Name = "panel4";
            panel4.Size = new Size(274, 60);
            panel4.TabIndex = 37;
            // 
            // btnFirst
            // 
            btnFirst.Font = new Font("Arial Unicode MS", 9F);
            btnFirst.Location = new Point(13, 92);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(75, 23);
            btnFirst.TabIndex = 10;
            btnFirst.Text = "First";
            btnFirst.UseVisualStyleBackColor = true;
            btnFirst.Click += btnFirst_Click;
            // 
            // btnLast
            // 
            btnLast.Font = new Font("Arial Unicode MS", 9F);
            btnLast.Location = new Point(193, 92);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(75, 23);
            btnLast.TabIndex = 38;
            btnLast.Text = "Last";
            btnLast.UseVisualStyleBackColor = true;
            btnLast.Click += btnLast_Click_1;
            // 
            // btnRenew
            // 
            btnRenew.Font = new Font("Arial Unicode MS", 9F);
            btnRenew.Location = new Point(302, 92);
            btnRenew.Name = "btnRenew";
            btnRenew.Size = new Size(75, 23);
            btnRenew.TabIndex = 39;
            btnRenew.Text = "Renew";
            btnRenew.UseVisualStyleBackColor = true;
            btnRenew.Click += btnRenew_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.Font = new Font("Arial Unicode MS", 9F);
            btnPrevious.Location = new Point(94, 92);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(42, 23);
            btnPrevious.TabIndex = 40;
            btnPrevious.Text = "<";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnNext
            // 
            btnNext.Font = new Font("Arial Unicode MS", 9F);
            btnNext.Location = new Point(144, 92);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(42, 23);
            btnNext.TabIndex = 41;
            btnNext.Text = ">";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Arial Unicode MS", 9F);
            btnSave.Location = new Point(760, 92);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 42;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnReduction
            // 
            btnReduction.Font = new Font("Arial Unicode MS", 9F);
            btnReduction.Location = new Point(643, 92);
            btnReduction.Name = "btnReduction";
            btnReduction.Size = new Size(75, 23);
            btnReduction.TabIndex = 43;
            btnReduction.Text = "Reduction";
            btnReduction.UseVisualStyleBackColor = true;
            btnReduction.Click += btnReduction_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Arial Unicode MS", 9F);
            btnRefresh.Location = new Point(816, 92);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 23);
            btnRefresh.TabIndex = 44;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel5.AutoSize = true;
            panel5.BackColor = Color.White;
            panel5.Controls.Add(btnRefresh);
            panel5.Controls.Add(panel4);
            panel5.Controls.Add(btnLast);
            panel5.Controls.Add(panel3);
            panel5.Controls.Add(btnPrevious);
            panel5.Controls.Add(btnFirst);
            panel5.Controls.Add(btnNext);
            panel5.Controls.Add(panel2);
            panel5.Controls.Add(btnReduction);
            panel5.Controls.Add(btnRenew);
            panel5.Location = new Point(222, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(937, 531);
            panel5.TabIndex = 45;
            // 
            // FormToyProducts
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1159, 531);
            Controls.Add(btnSave);
            Controls.Add(label4);
            Controls.Add(dataproject);
            Controls.Add(panel5);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            Name = "FormToyProducts";
            Text = "Project Management";
            Load += ToyProducts_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)name).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataproject).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
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
        private Button btnproduct;
        private Button btnsales;
        private Button btninventory;
        private Button btnproject;
        private Button btnAccountControl;
        private Button btnsystemManitenance;
        private DataGridView dataproject;
        private Label label4;
        private Label PID;
        private TextBox textPID;
        private TextBox textNName;
        private TextBox textName;
        private Label PName;
        private TextBox textNost;
        private TextBox textCost;
        private Label PCost;
        private TextBox textNPrice;
        private TextBox textPrice;
        private Label PPrice;
        private Label PQty;
        private TextBox textQty;
        private ComboBox cboNQty;
        private ComboBox cboNPCat;
        private TextBox textNQty;
        private TextBox textPCat;
        private Label PCat;
        private TextBox textPStat;
        private Label PStat;
        private ComboBox cboNPStat;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private ComboBox cboID;
        private Button btnFirst;
        private Button btnLast;
        private Button btnRenew;
        private Button btnPrevious;
        private Button btnNext;
        private Button btnSave;
        private Button btnReduction;
        private Button btnRefresh;
        private Panel panel5;
    }
}