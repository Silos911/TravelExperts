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
            dtpStartDate.MinDate = DateTime.Today;              //Sets the minimum start date to the current day
            dtpEndDate.MinDate = DateTime.Today.AddDays(1);     //Sets the minimum end date to the next day

            //Sets the current display strings to blank
            dtpStartDate.CustomFormat = NULL_DATE;
            dtpEndDate.CustomFormat = NULL_DATE;
        }

        //Once a value has been assigned, change the format to display the chosen date
        private void dtpStartDate_ValueChanged(object sender, EventArgs e) {
            dtpStartDate.CustomFormat = PICKED_DATE;
        }

        //Once a value has been assigned, change the format to display the chosen date
        private void dtpEndDate_ValueChanged(object sender, EventArgs e) {
            dtpEndDate.CustomFormat = PICKED_DATE;
        }
    }
}
