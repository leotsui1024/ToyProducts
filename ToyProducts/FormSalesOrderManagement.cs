﻿using System;
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
    public partial class FormSalesOrderManagement : Form
    {
        public FormSalesOrderManagement()
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
            FormProductSpecificationManagement productSpecificationManagement = new FormProductSpecificationManagement();
            productSpecificationManagement.Show();
            this.Hide();
        }

        private void buttonSalesOrderManagement_Click(object sender, EventArgs e)
        {

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
