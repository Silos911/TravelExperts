using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelExperts {
    public partial class frmPackageProducts : Form {
        int packageId = 0;
        public frmPackageProducts(int userInput) {
            InitializeComponent();
            packageId = userInput;
        }

        private void frmPackageProducts_Load(object sender, EventArgs e) {
            dgvPackagesProductsSuppliers.DataSource = PackagesProductsSuppliersDB.GetAllPackagesProductsSuppliers(packageId);
        }
    }
}
