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
            loadPackages();
        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void loadPackages() {
            dgvPackages.DataSource = PackagesDB.GetAllPackages();
        }


        private void btnAdd_Click(object sender, EventArgs e) {
            frmAddPackage addPackage = new frmAddPackage();
            DialogResult result = addPackage.ShowDialog();
            if (result == DialogResult.OK) {
                loadPackages();
            }
        }

        private void btnModify_Click(object sender, EventArgs e) {
            Package editedPackage = new Package();
            foreach(DataGridViewRow row in dgvPackages.SelectedRows) {
                editedPackage.PackageID = Convert.ToInt32(row.Cells[0].Value);
                editedPackage.PkgName = Convert.ToString(row.Cells[1].Value);
                editedPackage.PkgStartDate = Convert.ToDateTime(row.Cells[2].Value);
                editedPackage.PkgEndDate = Convert.ToDateTime(row.Cells[3].Value);
                editedPackage.PkgDesc = Convert.ToString(row.Cells[4].Value);
                editedPackage.PkgBasePrice = Convert.ToDecimal(row.Cells[5].Value);
                editedPackage.PkgAgencyCommission = Convert.ToDecimal(row.Cells[6].Value);
            }

            frmModifyPackage modifyPackage = new frmModifyPackage(editedPackage);
            DialogResult result = modifyPackage.ShowDialog();

            if (result == DialogResult.OK) {
                loadPackages();
            }
        }
    }
}
