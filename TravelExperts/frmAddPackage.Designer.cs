namespace TravelExperts {
    partial class frmAddPackage {
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblPackageName = new System.Windows.Forms.Label();
            this.lblPackageStartDate = new System.Windows.Forms.Label();
            this.lblPackageEndDate = new System.Windows.Forms.Label();
            this.lblPackageDescription = new System.Windows.Forms.Label();
            this.lblPackageBasePrice = new System.Windows.Forms.Label();
            this.lblPackageCommission = new System.Windows.Forms.Label();
            this.txtPackageName = new System.Windows.Forms.TextBox();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.txtPackageDescription = new System.Windows.Forms.TextBox();
            this.txtBasePrice = new System.Windows.Forms.TextBox();
            this.txtAgentCommission = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(325, 334);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 38);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(224, 334);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(88, 38);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // lblPackageName
            // 
            this.lblPackageName.AutoSize = true;
            this.lblPackageName.Location = new System.Drawing.Point(48, 45);
            this.lblPackageName.Name = "lblPackageName";
            this.lblPackageName.Size = new System.Drawing.Size(112, 17);
            this.lblPackageName.TabIndex = 2;
            this.lblPackageName.Text = "Package Name: ";
            // 
            // lblPackageStartDate
            // 
            this.lblPackageStartDate.AutoSize = true;
            this.lblPackageStartDate.Location = new System.Drawing.Point(80, 91);
            this.lblPackageStartDate.Name = "lblPackageStartDate";
            this.lblPackageStartDate.Size = new System.Drawing.Size(80, 17);
            this.lblPackageStartDate.TabIndex = 3;
            this.lblPackageStartDate.Text = "Start Date: ";
            // 
            // lblPackageEndDate
            // 
            this.lblPackageEndDate.AutoSize = true;
            this.lblPackageEndDate.Location = new System.Drawing.Point(89, 141);
            this.lblPackageEndDate.Name = "lblPackageEndDate";
            this.lblPackageEndDate.Size = new System.Drawing.Size(75, 17);
            this.lblPackageEndDate.TabIndex = 4;
            this.lblPackageEndDate.Text = "End Date: ";
            // 
            // lblPackageDescription
            // 
            this.lblPackageDescription.AutoSize = true;
            this.lblPackageDescription.Location = new System.Drawing.Point(73, 188);
            this.lblPackageDescription.Name = "lblPackageDescription";
            this.lblPackageDescription.Size = new System.Drawing.Size(87, 17);
            this.lblPackageDescription.TabIndex = 5;
            this.lblPackageDescription.Text = "Description: ";
            // 
            // lblPackageBasePrice
            // 
            this.lblPackageBasePrice.AutoSize = true;
            this.lblPackageBasePrice.Location = new System.Drawing.Point(76, 236);
            this.lblPackageBasePrice.Name = "lblPackageBasePrice";
            this.lblPackageBasePrice.Size = new System.Drawing.Size(84, 17);
            this.lblPackageBasePrice.TabIndex = 6;
            this.lblPackageBasePrice.Text = "Base Price: ";
            // 
            // lblPackageCommission
            // 
            this.lblPackageCommission.AutoSize = true;
            this.lblPackageCommission.Location = new System.Drawing.Point(28, 286);
            this.lblPackageCommission.Name = "lblPackageCommission";
            this.lblPackageCommission.Size = new System.Drawing.Size(132, 17);
            this.lblPackageCommission.TabIndex = 7;
            this.lblPackageCommission.Text = "Agent Commission: ";
            // 
            // txtPackageName
            // 
            this.txtPackageName.Location = new System.Drawing.Point(166, 45);
            this.txtPackageName.Name = "txtPackageName";
            this.txtPackageName.Size = new System.Drawing.Size(100, 22);
            this.txtPackageName.TabIndex = 8;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(166, 91);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 22);
            this.dtpStartDate.TabIndex = 9;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(166, 141);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 22);
            this.dtpEndDate.TabIndex = 10;
            // 
            // txtPackageDescription
            // 
            this.txtPackageDescription.Location = new System.Drawing.Point(166, 188);
            this.txtPackageDescription.Name = "txtPackageDescription";
            this.txtPackageDescription.Size = new System.Drawing.Size(100, 22);
            this.txtPackageDescription.TabIndex = 11;
            // 
            // txtBasePrice
            // 
            this.txtBasePrice.Location = new System.Drawing.Point(166, 236);
            this.txtBasePrice.Name = "txtBasePrice";
            this.txtBasePrice.Size = new System.Drawing.Size(100, 22);
            this.txtBasePrice.TabIndex = 12;
            // 
            // txtAgentCommission
            // 
            this.txtAgentCommission.Location = new System.Drawing.Point(166, 286);
            this.txtAgentCommission.Name = "txtAgentCommission";
            this.txtAgentCommission.Size = new System.Drawing.Size(100, 22);
            this.txtAgentCommission.TabIndex = 13;
            // 
            // frmAddPackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 389);
            this.Controls.Add(this.txtAgentCommission);
            this.Controls.Add(this.txtBasePrice);
            this.Controls.Add(this.txtPackageDescription);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.txtPackageName);
            this.Controls.Add(this.lblPackageCommission);
            this.Controls.Add(this.lblPackageBasePrice);
            this.Controls.Add(this.lblPackageDescription);
            this.Controls.Add(this.lblPackageEndDate);
            this.Controls.Add(this.lblPackageStartDate);
            this.Controls.Add(this.lblPackageName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Name = "frmAddPackage";
            this.Text = "Add Package";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblPackageName;
        private System.Windows.Forms.Label lblPackageStartDate;
        private System.Windows.Forms.Label lblPackageEndDate;
        private System.Windows.Forms.Label lblPackageDescription;
        private System.Windows.Forms.Label lblPackageBasePrice;
        private System.Windows.Forms.Label lblPackageCommission;
        private System.Windows.Forms.TextBox txtPackageName;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.TextBox txtPackageDescription;
        private System.Windows.Forms.TextBox txtBasePrice;
        private System.Windows.Forms.TextBox txtAgentCommission;
    }
}