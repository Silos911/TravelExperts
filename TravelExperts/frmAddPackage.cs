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
    public partial class frmAddPackage : Form {
        const string NULL_DATE = "   ";             //Displays an empty string
        const string PICKED_DATE = "MMMM dd, yyyy"; //Displays a string "FullMonthName DayNumber, YearNumber"

        public frmAddPackage() {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();   //Closes the window
        }

        private void frmAddPackage_Load(object sender, EventArgs e) {
            //Change the minimum start and end dates to the current day and the next day respectively
            dtpStartDate.MinDate = DateTime.Today;
            dtpEndDate.MinDate = DateTime.Today.AddDays(1);

            ResetStartDate();
            ResetEndDate();
        }

        //Once a value has been assigned, change the format to display the chosen date
        private void dtpStartDate_ValueChanged(object sender, EventArgs e) {
            dtpStartDate.CustomFormat = PICKED_DATE;
        }

        //Once a value has been assigned, change the format to display the chosen date
        private void dtpEndDate_ValueChanged(object sender, EventArgs e) {
            dtpEndDate.CustomFormat = PICKED_DATE;
        }

        //Resets all the values to null
        private void btnReset_Click(object sender, EventArgs e) {
            ResetStartDate();
            ResetEndDate();

            txtPackageName.Text = null;
            txtPackageDescription.Text = null;
            txtBasePrice.Text = null;
            txtAgentCommission.Text = null;
        }

        //Reset the start date to default values and make the display string empty
        private void ResetStartDate() {
            dtpStartDate.Value = null;
            dtpStartDate.CustomFormat = NULL_DATE;
        }

        //Reset the end date to default values and make the display string empty
        private void ResetEndDate() {
            dtpEndDate.Value = null;
            dtpEndDate.CustomFormat = NULL_DATE;
        }
    }
}
