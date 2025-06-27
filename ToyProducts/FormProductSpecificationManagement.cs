using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToyProducts
{
    public partial class FormProductSpecificationManagement : Form
    {
        public FormProductSpecificationManagement()
        {
            InitializeComponent();
        }

        private void buttonProjectManagement_Click(object sender, EventArgs e)
        {
            FormToyProducts toyProducts = new FormToyProducts();
            toyProducts.Show();
            this.Hide();
        }

        private void buttonProductSpecificationManagement_Click(object sender, EventArgs e)
        {

        }

        private void buttonSalesOrderManagement_Click(object sender, EventArgs e)
        {
            FormSalesOrderManagement salesOrderManagement = new FormSalesOrderManagement();
            salesOrderManagement.Show();
            this.Hide();
        }

        private void buttonInventoryControl_Click(object sender, EventArgs e)
        {
            FormInventoryControl inventoryControl = new FormInventoryControl();
            inventoryControl.Show();
            this.Hide();
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
