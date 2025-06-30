using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToyProducts
{
    public partial class FormInventoryControl : Form
    {
        private string dbPath;
        private OleDbConnection con;

        public FormInventoryControl()
        {
            InitializeComponent();

            // ✅ 使用 UserSession 初始化登入資訊與資料來源
            txtStaffName.Text = UserSession.StaffName;
            txtStaffID.Text = UserSession.StaffID;
            dbPath = UserSession.DbPath;
            con = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath};");
        }

        private void buttonProjectManagement_Click(object sender, EventArgs e)
        {
            FormToyProducts toyProducts = new FormToyProducts();
            toyProducts.Show();
            this.Hide();
        }

        private void buttonProductSpecificationManagement_Click(object sender, EventArgs e)
        {
            FormProductSpecificationManagement productSpecificationManagement = new FormProductSpecificationManagement();
            productSpecificationManagement.Show();
            this.Hide();
        }

        private void buttonSalesOrderManagement_Click(object sender, EventArgs e)
        {
            FormSalesOrderManagement salesOrderManagement = new FormSalesOrderManagement();
            salesOrderManagement.Show();
            this.Hide();
        }

        private void buttonInventoryControl_Click(object sender, EventArgs e)
        {
            // 本頁為當前表單，可不動作
        }

        private void buttonSystemMaintenance_Click(object sender, EventArgs e)
        {
            FormSystemMaintenance systemMaintenance = new FormSystemMaintenance();
            systemMaintenance.ShowDialog();
        }

        private void buttonAccountControl_Click(object sender, EventArgs e)
        {
            FormAccountControl accountControl = new FormAccountControl();
            accountControl.ShowDialog();
        }
    }
}
