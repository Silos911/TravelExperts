using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelExperts
{
    public partial class frmProducts_Suppliers : Form
    {
        public frmProducts_Suppliers()
        {
            InitializeComponent();
        }

        private void frmProducts_Suppliers_Load(object sender, EventArgs e)
        {
            dgvProductsSuppliers.DataSource = Products_SuppliersDB.GetProductsSuppliers();
        }
    }
}
