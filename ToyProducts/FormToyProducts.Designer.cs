


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
            txtStaffID = new TextBox();
            txtStaffName = new TextBox();
            btnAccountControl = new Button();
            btnsystemManitenance = new Button();
            btninventory = new Button();
            btnproject = new Button();
            btnsales = new Button();
            btnproduct = new Button();
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
            panel1.Controls.Add(txtStaffID);
            panel1.Controls.Add(txtStaffName);
            panel1.Controls.Add(btnAccountControl);
            panel1.Controls.Add(btnsystemManitenance);
            panel1.Controls.Add(btninventory);
            panel1.Controls.Add(btnproject);
            panel1.Controls.Add(btnsales);
            panel1.Controls.Add(btnproduct);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(346, 796);
            panel1.TabIndex = 0;
            // 
            // txtStaffID
            // 
            txtStaffID.Location = new Point(104, 101);
            txtStaffID.Name = "txtStaffID";
            txtStaffID.ReadOnly = true;
            txtStaffID.Size = new Size(220, 30);
            txtStaffID.TabIndex = 40;
            // 
            // txtStaffName
            // 
            txtStaffName.Location = new Point(104, 54);
            txtStaffName.Name = "txtStaffName";
            txtStaffName.ReadOnly = true;
            txtStaffName.Size = new Size(220, 30);
            txtStaffName.TabIndex = 39;
            // 
            // btnAccountControl
            // 
            btnAccountControl.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAccountControl.AutoSize = true;
            btnAccountControl.BackColor = Color.FromArgb(110, 172, 218);
            btnAccountControl.Font = new Font("Microsoft Sans Serif", 9F);
            btnAccountControl.Location = new Point(10, 730);
            btnAccountControl.Name = "btnAccountControl";
            btnAccountControl.Size = new Size(314, 48);
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
            btnsystemManitenance.Font = new Font("Microsoft Sans Serif", 9F);
            btnsystemManitenance.Location = new Point(10, 684);
            btnsystemManitenance.Name = "btnsystemManitenance";
            btnsystemManitenance.Size = new Size(314, 48);
            btnsystemManitenance.TabIndex = 8;
            btnsystemManitenance.Text = "System Maintenance";
            btnsystemManitenance.UseVisualStyleBackColor = false;
            btnsystemManitenance.Click += btnsystemMaintenance_Click;
            // 
            // btninventory
            // 
            btninventory.AutoSize = true;
            btninventory.BackColor = Color.FromArgb(110, 172, 218);
            btninventory.Font = new Font("Microsoft Sans Serif", 9F);
            btninventory.Location = new Point(10, 390);
            btninventory.Name = "btninventory";
            btninventory.Size = new Size(314, 66);
            btninventory.TabIndex = 7;
            btninventory.Text = "Inventory Control";
            btninventory.UseVisualStyleBackColor = false;
            btninventory.Click += btninventory_Click;
            // 
            // btnproject
            // 
            btnproject.AutoSize = true;
            btnproject.BackColor = Color.White;
            btnproject.Font = new Font("Microsoft Sans Serif", 9F);
            btnproject.Location = new Point(10, 176);
            btnproject.Name = "btnproject";
            btnproject.Size = new Size(314, 66);
            btnproject.TabIndex = 6;
            btnproject.Text = "Project Management";
            btnproject.UseVisualStyleBackColor = false;
            btnproject.Click += btnproject_Click;
            // 
            // btnsales
            // 
            btnsales.AutoSize = true;
            btnsales.BackColor = Color.FromArgb(110, 172, 218);
            btnsales.Font = new Font("Microsoft Sans Serif", 9F);
            btnsales.Location = new Point(10, 318);
            btnsales.Name = "btnsales";
            btnsales.Size = new Size(336, 66);
            btnsales.TabIndex = 5;
            btnsales.Text = "Sales Order Management";
            btnsales.UseVisualStyleBackColor = false;
            btnsales.Click += btnsales_Click;
            // 
            // btnproduct
            // 
            btnproduct.AutoSize = true;
            btnproduct.BackColor = Color.FromArgb(110, 172, 218);
            btnproduct.Font = new Font("Microsoft Sans Serif", 9F);
            btnproduct.Location = new Point(10, 248);
            btnproduct.Name = "btnproduct";
            btnproduct.Size = new Size(446, 66);
            btnproduct.TabIndex = 1;
            btnproduct.Text = "Product Specification Management";
            btnproduct.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(50, 90);
            label3.Name = "label3";
            label3.Size = new Size(52, 29);
            label3.TabIndex = 3;
            label3.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(10, 50);
            label2.Name = "label2";
            label2.Size = new Size(92, 29);
            label2.TabIndex = 2;
            label2.Text = "Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(10, 9);
            label1.Name = "label1";
            label1.Size = new Size(132, 29);
            label1.TabIndex = 1;
            label1.Text = "Welcome!";
            // 
            // dataproject
            // 
            dataproject.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataproject.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataproject.Location = new Point(352, 180);
            dataproject.Name = "dataproject";
            dataproject.RowHeadersWidth = 62;
            dataproject.Size = new Size(1370, 600);
            dataproject.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(364, 10);
            label4.Name = "label4";
            label4.Size = new Size(262, 29);
            label4.TabIndex = 10;
            label4.Text = "Project Management";
            // 
            // PID
            // 
            PID.AutoSize = true;
            PID.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            PID.Location = new Point(142, 48);
            PID.Margin = new Padding(4, 0, 4, 0);
            PID.Name = "PID";
            PID.Size = new Size(43, 29);
            PID.TabIndex = 11;
            PID.Text = "ID";
            // 
            // textNName
            // 
            textNName.Location = new Point(194, 46);
            textNName.Margin = new Padding(4);
            textNName.Name = "textNName";
            textNName.Size = new Size(196, 30);
            textNName.TabIndex = 16;
            // 
            // PName
            // 
            PName.AutoSize = true;
            PName.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            PName.Location = new Point(100, 6);
            PName.Margin = new Padding(4, 0, 4, 0);
            PName.Name = "PName";
            PName.Size = new Size(83, 29);
            PName.TabIndex = 14;
            PName.Text = "Name";
            // 
            // textNost
            // 
            textNost.Location = new Point(90, 46);
            textNost.Margin = new Padding(4);
            textNost.Name = "textNost";
            textNost.Size = new Size(66, 30);
            textNost.TabIndex = 19;
            // 
            // textCost
            // 
            textCost.Location = new Point(90, 4);
            textCost.Margin = new Padding(4);
            textCost.Name = "textCost";
            textCost.ReadOnly = true;
            textCost.Size = new Size(66, 30);
            textCost.TabIndex = 18;
            // 
            // PCost
            // 
            PCost.AutoSize = true;
            PCost.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            PCost.Location = new Point(14, 12);
            PCost.Margin = new Padding(4, 0, 4, 0);
            PCost.Name = "PCost";
            PCost.Size = new Size(66, 29);
            PCost.TabIndex = 17;
            PCost.Text = "Cost";
            // 
            // textNPrice
            // 
            textNPrice.Location = new Point(250, 46);
            textNPrice.Margin = new Padding(4);
            textNPrice.Name = "textNPrice";
            textNPrice.Size = new Size(66, 30);
            textNPrice.TabIndex = 22;
            // 
            // textPrice
            // 
            textPrice.Location = new Point(250, 4);
            textPrice.Margin = new Padding(4);
            textPrice.Name = "textPrice";
            textPrice.ReadOnly = true;
            textPrice.Size = new Size(66, 30);
            textPrice.TabIndex = 21;
            // 
            // PPrice
            // 
            PPrice.AutoSize = true;
            PPrice.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            PPrice.Location = new Point(166, 10);
            PPrice.Margin = new Padding(4, 0, 4, 0);
            PPrice.Name = "PPrice";
            PPrice.Size = new Size(73, 29);
            PPrice.TabIndex = 20;
            PPrice.Text = "Price";
            // 
            // PQty
            // 
            PQty.AutoSize = true;
            PQty.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            PQty.Location = new Point(327, 10);
            PQty.Margin = new Padding(4, 0, 4, 0);
            PQty.Name = "PQty";
            PQty.Size = new Size(55, 29);
            PQty.TabIndex = 23;
            PQty.Text = "Qty";
            // 
            // textQty
            // 
            textQty.Location = new Point(392, 4);
            textQty.Margin = new Padding(4);
            textQty.Name = "textQty";
            textQty.ReadOnly = true;
            textQty.Size = new Size(66, 30);
            textQty.TabIndex = 24;
            // 
            // textNQty
            // 
            textNQty.Location = new Point(392, 46);
            textNQty.Margin = new Padding(4);
            textNQty.Name = "textNQty";
            textNQty.Size = new Size(66, 30);
            textNQty.TabIndex = 29;
            // 
            // textPCat
            // 
            textPCat.Location = new Point(135, 6);
            textPCat.Margin = new Padding(4);
            textPCat.Name = "textPCat";
            textPCat.ReadOnly = true;
            textPCat.Size = new Size(66, 30);
            textPCat.TabIndex = 31;
            // 
            // PCat
            // 
            PCat.AutoSize = true;
            PCat.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            PCat.Location = new Point(2, 6);
            PCat.Margin = new Padding(4, 0, 4, 0);
            PCat.Name = "PCat";
            PCat.Size = new Size(121, 29);
            PCat.TabIndex = 30;
            PCat.Text = "Category";
            // 
            // textPStat
            // 
            textPStat.Location = new Point(326, 6);
            textPStat.Margin = new Padding(4);
            textPStat.Name = "textPStat";
            textPStat.ReadOnly = true;
            textPStat.Size = new Size(66, 30);
            textPStat.TabIndex = 33;
            // 
            // PStat
            // 
            PStat.AutoSize = true;
            PStat.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            PStat.Location = new Point(212, 6);
            PStat.Margin = new Padding(4, 0, 4, 0);
            PStat.Name = "PStat";
            PStat.Size = new Size(89, 29);
            PStat.TabIndex = 32;
            PStat.Text = "Status";
            // 
            // cboNPCat
            // 
            cboNPCat.FormattingEnabled = true;
            cboNPCat.Items.AddRange(new object[] { "Toy", "Plush", "Model", "Vehicle", "Construction", "Other" });
            cboNPCat.Location = new Point(21, 46);
            cboNPCat.Margin = new Padding(4);
            cboNPCat.Name = "cboNPCat";
            cboNPCat.Size = new Size(180, 31);
            cboNPCat.TabIndex = 34;
            cboNPCat.Text = "Toy";
            // 
            // cboNPStat
            // 
            cboNPStat.FormattingEnabled = true;
            cboNPStat.Items.AddRange(new object[] { "Active", "Inactive" });
            cboNPStat.Location = new Point(212, 46);
            cboNPStat.Margin = new Padding(4);
            cboNPStat.Name = "cboNPStat";
            cboNPStat.Size = new Size(180, 31);
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
            panel2.Location = new Point(20, 44);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(411, 90);
            panel2.TabIndex = 10;
            // 
            // textName
            // 
            textName.Location = new Point(194, 4);
            textName.Margin = new Padding(4);
            textName.Name = "textName";
            textName.Size = new Size(196, 30);
            textName.TabIndex = 38;
            // 
            // cboID
            // 
            cboID.FormattingEnabled = true;
            cboID.Location = new Point(9, 46);
            cboID.Margin = new Padding(4);
            cboID.Name = "cboID";
            cboID.Size = new Size(85, 31);
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
            panel3.Location = new Point(446, 42);
            panel3.Margin = new Padding(4);
            panel3.Name = "panel3";
            panel3.Size = new Size(482, 90);
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
            panel4.Location = new Point(946, 44);
            panel4.Margin = new Padding(4);
            panel4.Name = "panel4";
            panel4.Size = new Size(411, 90);
            panel4.TabIndex = 37;
            // 
            // btnFirst
            // 
            btnFirst.Font = new Font("Microsoft Sans Serif", 9F);
            btnFirst.Location = new Point(20, 138);
            btnFirst.Margin = new Padding(4);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(112, 34);
            btnFirst.TabIndex = 10;
            btnFirst.Text = "First";
            btnFirst.UseVisualStyleBackColor = true;
            btnFirst.Click += btnFirst_Click;
            // 
            // btnLast
            // 
            btnLast.Font = new Font("Microsoft Sans Serif", 9F);
            btnLast.Location = new Point(290, 138);
            btnLast.Margin = new Padding(4);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(112, 34);
            btnLast.TabIndex = 38;
            btnLast.Text = "Last";
            btnLast.UseVisualStyleBackColor = true;
            // 
            // btnRenew
            // 
            btnRenew.Font = new Font("Microsoft Sans Serif", 9F);
            btnRenew.Location = new Point(453, 138);
            btnRenew.Margin = new Padding(4);
            btnRenew.Name = "btnRenew";
            btnRenew.Size = new Size(112, 34);
            btnRenew.TabIndex = 39;
            btnRenew.Text = "Renew";
            btnRenew.UseVisualStyleBackColor = true;
            btnRenew.Click += btnRenew_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.Font = new Font("Microsoft Sans Serif", 9F);
            btnPrevious.Location = new Point(141, 138);
            btnPrevious.Margin = new Padding(4);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(63, 34);
            btnPrevious.TabIndex = 40;
            btnPrevious.Text = "<";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnNext
            // 
            btnNext.Font = new Font("Microsoft Sans Serif", 9F);
            btnNext.Location = new Point(216, 138);
            btnNext.Margin = new Padding(4);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(63, 34);
            btnNext.TabIndex = 41;
            btnNext.Text = ">";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Microsoft Sans Serif", 9F);
            btnSave.Location = new Point(1140, 138);
            btnSave.Margin = new Padding(4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 42;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnReduction
            // 
            btnReduction.Font = new Font("Microsoft Sans Serif", 9F);
            btnReduction.Location = new Point(964, 138);
            btnReduction.Margin = new Padding(4);
            btnReduction.Name = "btnReduction";
            btnReduction.Size = new Size(112, 34);
            btnReduction.TabIndex = 43;
            btnReduction.Text = "Reduction";
            btnReduction.UseVisualStyleBackColor = true;
            btnReduction.Click += btnReduction_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Microsoft Sans Serif", 9F);
            btnRefresh.Location = new Point(1224, 138);
            btnRefresh.Margin = new Padding(4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(112, 34);
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
            panel5.Location = new Point(333, 0);
            panel5.Margin = new Padding(4);
            panel5.Name = "panel5";
            panel5.Size = new Size(1406, 796);
            panel5.TabIndex = 45;
            panel5.Paint += panel5_Paint;
            // 
            // FormToyProducts
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1738, 796);
            Controls.Add(btnSave);
            Controls.Add(label4);
            Controls.Add(dataproject);
            Controls.Add(panel5);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormToyProducts";
            Text = "Project Management";
            Load += ToyProducts_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Label label3;
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
        private TextBox txtStaffID;
        private TextBox txtStaffName;
    }
}