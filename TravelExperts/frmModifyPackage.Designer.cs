namespace TravelExperts {
    partial class frmModifyPackage {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtPackageID = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblPackageName = new System.Windows.Forms.Label();
            this.txtPackageName = new System.Windows.Forms.TextBox();
            this.lblPackageStartDate = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtPackageDescription = new System.Windows.Forms.TextBox();
            this.lblBasePrice = new System.Windows.Forms.Label();
            this.txtBasePrice = new System.Windows.Forms.TextBox();
            this.txtAgentCommission = new System.Windows.Forms.TextBox();
            this.lblAgentCommission = new System.Windows.Forms.Label();
            this.btnResetStart = new System.Windows.Forms.Button();
            this.btnResetEnd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Package ID: ";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(345, 16);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtPackageID
            // 
            this.txtPackageID.Location = new System.Drawing.Point(176, 19);
            this.txtPackageID.Name = "txtPackageID";
            this.txtPackageID.Size = new System.Drawing.Size(163, 22);
            this.txtPackageID.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(401, 336);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(307, 336);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(205, 336);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // lblPackageName
            // 
            this.lblPackageName.AutoSize = true;
            this.lblPackageName.Location = new System.Drawing.Point(21, 88);
            this.lblPackageName.Name = "lblPackageName";
            this.lblPackageName.Size = new System.Drawing.Size(112, 17);
            this.lblPackageName.TabIndex = 6;
            this.lblPackageName.Text = "Package Name: ";
            // 
            // txtPackageName
            // 
            this.txtPackageName.Location = new System.Drawing.Point(176, 88);
            this.txtPackageName.Name = "txtPackageName";
            this.txtPackageName.Size = new System.Drawing.Size(163, 22);
            this.txtPackageName.TabIndex = 7;
            // 
            // lblPackageStartDate
            // 
            this.lblPackageStartDate.AutoSize = true;
            this.lblPackageStartDate.Location = new System.Drawing.Point(53, 127);
            this.lblPackageStartDate.Name = "lblPackageStartDate";
            this.lblPackageStartDate.Size = new System.Drawing.Size(80, 17);
            this.lblPackageStartDate.TabIndex = 8;
            this.lblPackageStartDate.Text = "Start Date: ";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CustomFormat = "MMMM dd, yyyy";
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(176, 127);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpStartDate.Size = new System.Drawing.Size(163, 22);
            this.dtpStartDate.TabIndex = 9;
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(58, 166);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(75, 17);
            this.lblEndDate.TabIndex = 10;
            this.lblEndDate.Text = "End Date: ";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CustomFormat = "MMMM dd, yyyy";
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(176, 161);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(163, 22);
            this.dtpEndDate.TabIndex = 11;
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.dtpEndDate_ValueChanged);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(46, 201);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(87, 17);
            this.lblDescription.TabIndex = 12;
            this.lblDescription.Text = "Description: ";
            // 
            // txtPackageDescription
            // 
            this.txtPackageDescription.Location = new System.Drawing.Point(176, 198);
            this.txtPackageDescription.Name = "txtPackageDescription";
            this.txtPackageDescription.Size = new System.Drawing.Size(163, 22);
            this.txtPackageDescription.TabIndex = 13;
            // 
            // lblBasePrice
            // 
            this.lblBasePrice.AutoSize = true;
            this.lblBasePrice.Location = new System.Drawing.Point(49, 242);
            this.lblBasePrice.Name = "lblBasePrice";
            this.lblBasePrice.Size = new System.Drawing.Size(84, 17);
            this.lblBasePrice.TabIndex = 14;
            this.lblBasePrice.Text = "Base Price: ";
            // 
            // txtBasePrice
            // 
            this.txtBasePrice.Location = new System.Drawing.Point(176, 239);
            this.txtBasePrice.Name = "txtBasePrice";
            this.txtBasePrice.Size = new System.Drawing.Size(163, 22);
            this.txtBasePrice.TabIndex = 15;
            // 
            // txtAgentCommission
            // 
            this.txtAgentCommission.Location = new System.Drawing.Point(176, 282);
            this.txtAgentCommission.Name = "txtAgentCommission";
            this.txtAgentCommission.Size = new System.Drawing.Size(163, 22);
            this.txtAgentCommission.TabIndex = 16;
            // 
            // lblAgentCommission
            // 
            this.lblAgentCommission.AutoSize = true;
            this.lblAgentCommission.Location = new System.Drawing.Point(1, 285);
            this.lblAgentCommission.Name = "lblAgentCommission";
            this.lblAgentCommission.Size = new System.Drawing.Size(132, 17);
            this.lblAgentCommission.TabIndex = 17;
            this.lblAgentCommission.Text = "Agent Commission: ";
            // 
            // btnResetStart
            // 
            this.btnResetStart.Location = new System.Drawing.Point(345, 129);
            this.btnResetStart.Name = "btnResetStart";
            this.btnResetStart.Size = new System.Drawing.Size(131, 23);
            this.btnResetStart.TabIndex = 18;
            this.btnResetStart.Text = "Reset Start Date";
            this.btnResetStart.UseVisualStyleBackColor = true;
            // 
            // btnResetEnd
            // 
            this.btnResetEnd.Location = new System.Drawing.Point(345, 163);
            this.btnResetEnd.Name = "btnResetEnd";
            this.btnResetEnd.Size = new System.Drawing.Size(131, 23);
            this.btnResetEnd.TabIndex = 19;
            this.btnResetEnd.Text = "Reset End Date";
            this.btnResetEnd.UseVisualStyleBackColor = true;
            // 
            // frmModifyPackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 371);
            this.Controls.Add(this.btnResetEnd);
            this.Controls.Add(this.btnResetStart);
            this.Controls.Add(this.lblAgentCommission);
            this.Controls.Add(this.txtAgentCommission);
            this.Controls.Add(this.txtBasePrice);
            this.Controls.Add(this.lblBasePrice);
            this.Controls.Add(this.txtPackageDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.lblPackageStartDate);
            this.Controls.Add(this.txtPackageName);
            this.Controls.Add(this.lblPackageName);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtPackageID);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label1);
            this.Name = "frmModifyPackage";
            this.Text = "frmModifyPackage";
            this.Load += new System.EventHandler(this.frmModifyPackage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtPackageID;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblPackageName;
        private System.Windows.Forms.TextBox txtPackageName;
        private System.Windows.Forms.Label lblPackageStartDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtPackageDescription;
        private System.Windows.Forms.Label lblBasePrice;
        private System.Windows.Forms.TextBox txtBasePrice;
        private System.Windows.Forms.TextBox txtAgentCommission;
        private System.Windows.Forms.Label lblAgentCommission;
        private System.Windows.Forms.Button btnResetStart;
        private System.Windows.Forms.Button btnResetEnd;
    }
}