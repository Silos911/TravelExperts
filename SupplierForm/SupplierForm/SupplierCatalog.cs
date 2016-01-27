// SUPPLIER DATABASE FORM PROVIDES COMPLETE SUPPLIER INFORMATION 
// FUNCTIONS: SEARCH, ADD, UPDATE AND DELETE
// BY NEHA GHORPADE
// LAST MODIFIED ON JAN 24TH, 2016

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupplierForm
{
    public partial class SupplierCatalog : Form
    {
        SqlConnection connection = TravelExpertsDB.GetConnection();
        SqlDataAdapter da;
        DataTable dt;

        public SupplierCatalog()
        {
            InitializeComponent();
        }

        private void SupplierCatalog_Load(object sender, EventArgs e)
        {
            connection.Open();
            da = new SqlDataAdapter("SELECT Suppliers.[SupplierId],[SupConCompany],[SupConAddress],[SupConCity], [SupConProv], [SupConPostal], [SupConCountry], [SupConBusPhone] , [SupConFax], [SupConEmail], [AffilitationId] FROM [dbo].[SupplierContacts] JOIN Suppliers ON SupplierContacts.SupplierId = Suppliers.SupplierId JOIN [dbo].[Affiliations] ON [dbo].[Affiliations].AffilitationId = SupplierContacts.AffiliationId", connection);
            dt = new DataTable();
            da.Fill(dt);
            dgvSupplierCatalog.DataSource = dt;
            connection.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            connection.Open();
            da = new SqlDataAdapter("SELECT Suppliers.[SupplierId],[SupConCompany],[SupConAddress],[SupConCity], [SupConProv], [SupConPostal], [SupConCountry], [SupConBusPhone] , [SupConFax], [SupConEmail], [AffilitationId] FROM [dbo].[SupplierContacts] JOIN Suppliers ON SupplierContacts.SupplierId = Suppliers.SupplierId JOIN [dbo].[Affiliations] ON [dbo].[Affiliations].AffilitationId = SupplierContacts.AffiliationId WHERE [SupName] like '" +textBox1.Text+ "%'", connection);
            dt = new DataTable();
            da.Fill(dt);
            dgvSupplierCatalog.DataSource = dt;
            connection.Close();
        }

        //private void dgvSupplierCatalog_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        //{ //Fetches clicked datagrid view row value into the textboxes
        //    txtSupplierID.Text = dgvSupplierCatalog.Rows[e.RowIndex].Cells[0].Value.ToString();
        //    txtCompanyName.Text = dgvSupplierCatalog.Rows[e.RowIndex].Cells[1].Value.ToString();
        //    txtAddress.Text = dgvSupplierCatalog.Rows[e.RowIndex].Cells[2].Value.ToString();
        //    txtCity.Text = dgvSupplierCatalog.Rows[e.RowIndex].Cells[3].Value.ToString();
        //    txtProvince.Text = dgvSupplierCatalog.Rows[e.RowIndex].Cells[4].Value.ToString();
        //    txtPostalCode.Text = dgvSupplierCatalog.Rows[e.RowIndex].Cells[5].Value.ToString();
        //    txtCountry.Text = dgvSupplierCatalog.Rows[e.RowIndex].Cells[6].Value.ToString();
        //    txtPhone.Text = dgvSupplierCatalog.Rows[e.RowIndex].Cells[7].Value.ToString();
        //    txtFax.Text = dgvSupplierCatalog.Rows[e.RowIndex].Cells[8].Value.ToString();
        //    txtEmail.Text = dgvSupplierCatalog.Rows[e.RowIndex].Cells[9].Value.ToString();
        //    txtAffiliations.Text = dgvSupplierCatalog.Rows[e.RowIndex].Cells[10].Value.ToString();
        //}
        //Fetches whole row into the textboxes when user clicks on any cell 
        private void dgvSupplierCatalog_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSupplierID.Text = dgvSupplierCatalog.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtCompanyName.Text = dgvSupplierCatalog.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtAddress.Text = dgvSupplierCatalog.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtCity.Text = dgvSupplierCatalog.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtProvince.Text = dgvSupplierCatalog.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtPostalCode.Text = dgvSupplierCatalog.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtCountry.Text = dgvSupplierCatalog.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtPhone.Text = dgvSupplierCatalog.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtFax.Text = dgvSupplierCatalog.Rows[e.RowIndex].Cells[8].Value.ToString();
            txtEmail.Text = dgvSupplierCatalog.Rows[e.RowIndex].Cells[9].Value.ToString();
            txtAffiliations.Text = dgvSupplierCatalog.Rows[e.RowIndex].Cells[10].Value.ToString();
        }
    }
}
