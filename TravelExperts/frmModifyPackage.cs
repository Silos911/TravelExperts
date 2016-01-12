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
    public partial class frmModifyPackage : Form {
        const string NULL_DATE = "   ";             //Displays an empty string
        const string PICKED_DATE = "MMMM dd, yyyy"; //Displays a string "FullMonthName DayNumber, YearNumber"
        public bool endDatePicked = false;
        public bool startDatePicked = false;

        public frmModifyPackage(Package editedPackage) {
            InitializeComponent();

            txtPackageID.Text = editedPackage.PackageID.ToString();
            txtPackageName.Text = editedPackage.PkgName;
            txtPackageDescription.Text = editedPackage.PkgDesc;
            txtBasePrice.Text = editedPackage.PkgBasePrice.ToString();
            txtAgentCommission.Text = editedPackage.PkgAgencyCommission.ToString();

            if(dtpStartDate.Value != null) {
                startDatePicked = true;
                dtpStartDate.Value = editedPackage.PkgStartDate;
            }
            if(dtpEndDate.Value != null) {
                endDatePicked = true;
                dtpEndDate.Value = editedPackage.PkgEndDate;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e) {
            dtpStartDate.CustomFormat = PICKED_DATE;
        }

        private void frmModifyPackage_Load(object sender, EventArgs e) {
            if(endDatePicked == false) {
                ResetEndDate();
            }
            if(startDatePicked == false) {
                ResetStartDate();
            }
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e) {
            dtpEndDate.CustomFormat = PICKED_DATE;
        }

        private void btnReset_Click(object sender, EventArgs e) {
            txtPackageID.Text = null;
            txtPackageName.Text = null;
            txtPackageName.Enabled = false;

            txtPackageDescription.Text = null;
            txtPackageDescription.Enabled = false;

            txtBasePrice.Text = null;
            txtBasePrice.Enabled = false;

            txtAgentCommission.Text = null;
            txtAgentCommission.Enabled = false;

            ResetEndDate();
            ResetStartDate();
        }

        private void ResetStartDate() {
            dtpStartDate.MinDate = DateTime.Today;
            dtpStartDate.CustomFormat = NULL_DATE;
        }

        private void ResetEndDate() {
            dtpEndDate.MinDate = DateTime.Today.AddDays(1);
            dtpEndDate.CustomFormat = NULL_DATE;
        }
    }
}
