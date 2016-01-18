/*
 *  Title: frmModifyPackage
 *  Author: Stephen Strome
 *  Last Date Modified: January 18, 2016
 *
 *  Form that lets the user edit a package. When it opens, set all the text boxes to the values from the row
 *  selected on frmPackages. If the user wishes to, they can reset the form and search for a different package id.
 *  When the user is done, they can finalize their changes and a message box will appear informing them if they
 *  were successful or not.
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

namespace TravelExperts {
    public partial class frmModifyPackage : Form {
        const string NULL_DATE = "   ";             //Displays an empty string
        const string PICKED_DATE = "MMMM dd, yyyy"; //Displays a string "FullMonthName DayNumber, YearNumber"
        public bool endDatePicked = false;
        public bool startDatePicked = false;
        Package oldPackage = new Package();

        public frmModifyPackage(Package editedPackage) {
            InitializeComponent();

            txtPackageID.Text = editedPackage.PackageID.ToString();
            txtPackageName.Text = editedPackage.PkgName;
            txtPackageDescription.Text = editedPackage.PkgDesc;
            txtBasePrice.Text = editedPackage.PkgBasePrice.ToString();
            txtAgentCommission.Text = editedPackage.PkgAgencyCommission.ToString();

            oldPackage = editedPackage;

            if (dtpStartDate.Value != null) {
                startDatePicked = true;
                dtpStartDate.Value = editedPackage.PkgStartDate;
            }
            if (dtpEndDate.Value != null) {
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
            if (endDatePicked == false) {
                ResetEndDate();
            }
            if (startDatePicked == false) {
                ResetStartDate();
            }
            txtPackageID.Enabled = false;
            btnSearch.Enabled = false;
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

            txtPackageID.Text = null;
            txtPackageID.Enabled = true;

            ResetEndDate();
            ResetStartDate();

            dtpEndDate.Enabled = false;
            dtpStartDate.Enabled = false;

            btnSearch.Enabled = true;

            oldPackage = null;
        }

        private void ResetStartDate() {
            dtpStartDate.MinDate = DateTime.Today;
            dtpStartDate.CustomFormat = NULL_DATE;
        }

        private void ResetEndDate() {
            dtpEndDate.MinDate = DateTime.Today.AddDays(1);
            dtpEndDate.CustomFormat = NULL_DATE;
        }

        private void btnEdit_Click(object sender, EventArgs e) {
            Package newPackage = new Package();

            if(oldPackage == null) {
                MessageBox.Show("No package selected. Please try again.");
            }
            else {
                newPackage.PkgName = txtPackageName.Text;
                newPackage.PkgStartDate = dtpStartDate.Value;
                newPackage.PkgEndDate = dtpEndDate.Value;
                newPackage.PkgDesc = txtPackageDescription.Text;
                newPackage.PkgBasePrice = Convert.ToDecimal(txtBasePrice.Text);
                newPackage.PkgAgencyCommission = Convert.ToDecimal(txtAgentCommission.Text);

                int check = 0;

                try {
                    check = PackagesDB.ModifyPackage(oldPackage, newPackage);
                }
                catch (Exception ex) {
                    MessageBox.Show("An error has occurred: " + ex.Message);
                }

                if (check > 0) {
                    MessageBox.Show("Modification successful.");
                    DialogResult = DialogResult.OK;
                }
                else {
                    MessageBox.Show("Modification failed, please try again.");
                }
            }
            
        }

        private void btnResetStart_Click(object sender, EventArgs e) {
            ResetStartDate();
        }

        private void btnResetEnd_Click(object sender, EventArgs e) {
            ResetEndDate();
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            try {
                Package singlePackage = PackagesDB.GetSinglePackage(txtPackageID.Text);

                if(singlePackage.PkgName == null) {
                    MessageBox.Show("There is no record at ID " + txtPackageID.Text);
                }
                else {
                    txtPackageName.Text = singlePackage.PkgName;

                    if (dtpStartDate.MinDate > singlePackage.PkgStartDate) {
                        dtpStartDate.MinDate = singlePackage.PkgStartDate;
                    }
                    dtpStartDate.Value = singlePackage.PkgStartDate;

                    if (dtpEndDate.MinDate > singlePackage.PkgEndDate) {
                        dtpEndDate.MinDate = singlePackage.PkgEndDate;
                    }
                    dtpEndDate.Value = singlePackage.PkgEndDate;
                    txtPackageDescription.Text = singlePackage.PkgDesc;
                    txtBasePrice.Text = singlePackage.PkgBasePrice.ToString();
                    txtAgentCommission.Text = singlePackage.PkgAgencyCommission.ToString();

                    txtPackageID.Enabled = false;
                    btnSearch.Enabled = false;

                    txtPackageName.Enabled = true;
                    dtpStartDate.Enabled = true;
                    dtpEndDate.Enabled = true;
                    txtPackageDescription.Enabled = true;
                    txtBasePrice.Enabled = true;
                    txtAgentCommission.Enabled = true;

                    oldPackage = singlePackage;
                }
            }
            catch(Exception ex) {
                MessageBox.Show("An error has occurred: " + ex.Message);
            }

        }
    }
}
