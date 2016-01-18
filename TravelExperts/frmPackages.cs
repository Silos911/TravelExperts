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

        //When form first appears, load all rows of data
        private void frmPackages_Load(object sender, EventArgs e)
        {
            loadPackages();
        }

        //Close the form
        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }

        //Displays all data in the data grid view
        private void loadPackages() {
            dgvPackages.DataSource = PackagesDB.GetAllPackages();
        }

        //Open form to add a package, reload packages if insert is successful
        private void btnAdd_Click(object sender, EventArgs e) {
            frmAddPackage addPackage = new frmAddPackage();
            DialogResult result = addPackage.ShowDialog();
            if (result == DialogResult.OK) {
                loadPackages();
            }
        }

        //Store data in selected row in an object, open frmModifyPackage and reload data grid view if successful
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

        //Store selected row in an object, double check the user does want to delete the package, reload data grid
        //view if successful
        private void btnDelete_Click(object sender, EventArgs e) {
            Package deletedPackage = new Package();
            int check = 0;
            foreach (DataGridViewRow row in dgvPackages.SelectedRows) {
                deletedPackage.PackageID = Convert.ToInt32(row.Cells[0].Value);
                deletedPackage.PkgName = Convert.ToString(row.Cells[1].Value);
                deletedPackage.PkgStartDate = Convert.ToDateTime(row.Cells[2].Value);
                deletedPackage.PkgEndDate = Convert.ToDateTime(row.Cells[3].Value);
                deletedPackage.PkgDesc = Convert.ToString(row.Cells[4].Value);
                deletedPackage.PkgBasePrice = Convert.ToDecimal(row.Cells[5].Value);
                deletedPackage.PkgAgencyCommission = Convert.ToDecimal(row.Cells[6].Value);
            }
            DialogResult result = MessageBox.Show("Are you sure you want to delete package " + deletedPackage.PackageID + "?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) {
                try {
                    check = PackagesDB.DeletePackage(deletedPackage);
                    if (check > 0) {
                        MessageBox.Show("Package deleted.");
                    }
                    else {
                        MessageBox.Show("An error occurred, please try again.");
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show("An error has occurred: " + ex.Message);
                }
                loadPackages();
            }
        }


    }
}
