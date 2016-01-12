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
    public partial class frmPackages : Form {
        public frmPackages() {
            InitializeComponent();
        }

        private void frmPackages_Load(object sender, EventArgs e)
        {
            dgvPackages.DataSource = PackagesDB.GetAllPackages();
        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            frmAddPackage addPackage = new frmAddPackage();
            addPackage.Show();
        }
    }
}
