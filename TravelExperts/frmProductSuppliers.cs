/*
Title:             ProductSuppliers form code 
Author:            Deya Cerdas
Last Date updated: 2016-01-16
Description:                
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TravelExperts
{
    public partial class frmProductSuppliers : Form
    {
        public frmProductSuppliers()
        {
            InitializeComponent();
        }

        private ProductSupplier productSupplier;

        private void frmProducts_Suppliers_Load(object sender, EventArgs e)
        {
            dgvProductsSuppliers.DataSource = ProductSuppliersDB.GetAllProductSuppliers();
        }

        private void btnAddProductSupplier_Click(object sender, EventArgs e)
        {
            frmProductSuppliers addProductSupplierForm = new frmProductSuppliers();
            addProductSupplierForm.addProductSupplier = true;
            //If user confirms add then call add method with current product
            DialogResult result = addProductSupplierForm.ShowDialog();
            //If added successfully, display product
            if (result == DialogResult.OK)
            {
                productSupplier = addProductSupplierForm.productSupplier;
                txtProductCode.Text = product.ProductCode.ToString();
                this.DisplayProduct();
            }
        }
    }
}
