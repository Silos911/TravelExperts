namespace SupplierForm
{
    partial class SupplierCatalog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierCatalog));
            this.dgvSupplierCatalog = new System.Windows.Forms.DataGridView();
            this.lblSearch = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gbCompanyInfo = new System.Windows.Forms.GroupBox();
            this.txtAffiliations = new System.Windows.Forms.TextBox();
            this.lblAffiliations = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.txtProvince = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.txtSupplierID = new System.Windows.Forms.TextBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblPostalCode = new System.Windows.Forms.Label();
            this.lblProvince = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblSupCompanyName = new System.Windows.Forms.Label();
            this.lblSupID = new System.Windows.Forms.Label();
            this.gbContactInfo = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblFax = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplierCatalog)).BeginInit();
            this.gbCompanyInfo.SuspendLayout();
            this.gbContactInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSupplierCatalog
            // 
            this.dgvSupplierCatalog.AllowUserToAddRows = false;
            this.dgvSupplierCatalog.AllowUserToDeleteRows = false;
            this.dgvSupplierCatalog.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvSupplierCatalog.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvSupplierCatalog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupplierCatalog.Location = new System.Drawing.Point(12, 54);
            this.dgvSupplierCatalog.Name = "dgvSupplierCatalog";
            this.dgvSupplierCatalog.ReadOnly = true;
            this.dgvSupplierCatalog.RowTemplate.Height = 24;
            this.dgvSupplierCatalog.Size = new System.Drawing.Size(965, 330);
            this.dgvSupplierCatalog.TabIndex = 0;
            this.dgvSupplierCatalog.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSupplierCatalog_CellClick);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(18, 19);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(113, 17);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "&Search by Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(137, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(193, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // gbCompanyInfo
            // 
            this.gbCompanyInfo.Controls.Add(this.txtAffiliations);
            this.gbCompanyInfo.Controls.Add(this.lblAffiliations);
            this.gbCompanyInfo.Controls.Add(this.txtCountry);
            this.gbCompanyInfo.Controls.Add(this.txtPostalCode);
            this.gbCompanyInfo.Controls.Add(this.txtProvince);
            this.gbCompanyInfo.Controls.Add(this.txtCity);
            this.gbCompanyInfo.Controls.Add(this.txtAddress);
            this.gbCompanyInfo.Controls.Add(this.txtCompanyName);
            this.gbCompanyInfo.Controls.Add(this.txtSupplierID);
            this.gbCompanyInfo.Controls.Add(this.lblCountry);
            this.gbCompanyInfo.Controls.Add(this.lblPostalCode);
            this.gbCompanyInfo.Controls.Add(this.lblProvince);
            this.gbCompanyInfo.Controls.Add(this.lblCity);
            this.gbCompanyInfo.Controls.Add(this.lblAddress);
            this.gbCompanyInfo.Controls.Add(this.lblSupCompanyName);
            this.gbCompanyInfo.Controls.Add(this.lblSupID);
            this.gbCompanyInfo.Location = new System.Drawing.Point(15, 404);
            this.gbCompanyInfo.Name = "gbCompanyInfo";
            this.gbCompanyInfo.Size = new System.Drawing.Size(557, 302);
            this.gbCompanyInfo.TabIndex = 3;
            this.gbCompanyInfo.TabStop = false;
            this.gbCompanyInfo.Text = "Company Information";
            // 
            // txtAffiliations
            // 
            this.txtAffiliations.Location = new System.Drawing.Point(152, 267);
            this.txtAffiliations.Name = "txtAffiliations";
            this.txtAffiliations.ReadOnly = true;
            this.txtAffiliations.Size = new System.Drawing.Size(360, 22);
            this.txtAffiliations.TabIndex = 15;
            // 
            // lblAffiliations
            // 
            this.lblAffiliations.AutoSize = true;
            this.lblAffiliations.Location = new System.Drawing.Point(39, 272);
            this.lblAffiliations.Name = "lblAffiliations";
            this.lblAffiliations.Size = new System.Drawing.Size(89, 17);
            this.lblAffiliations.TabIndex = 14;
            this.lblAffiliations.Text = "Affiliations ID";
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(395, 220);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(117, 22);
            this.txtCountry.TabIndex = 13;
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(152, 223);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(133, 22);
            this.txtPostalCode.TabIndex = 12;
            // 
            // txtProvince
            // 
            this.txtProvince.Location = new System.Drawing.Point(395, 175);
            this.txtProvince.Name = "txtProvince";
            this.txtProvince.Size = new System.Drawing.Size(117, 22);
            this.txtProvince.TabIndex = 11;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(152, 175);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(133, 22);
            this.txtCity.TabIndex = 10;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(152, 128);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(360, 22);
            this.txtAddress.TabIndex = 9;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(152, 80);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(360, 22);
            this.txtCompanyName.TabIndex = 8;
            // 
            // txtSupplierID
            // 
            this.txtSupplierID.Location = new System.Drawing.Point(152, 32);
            this.txtSupplierID.Name = "txtSupplierID";
            this.txtSupplierID.ReadOnly = true;
            this.txtSupplierID.Size = new System.Drawing.Size(100, 22);
            this.txtSupplierID.TabIndex = 7;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(326, 223);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(57, 17);
            this.lblCountry.TabIndex = 6;
            this.lblCountry.Text = "Country";
            // 
            // lblPostalCode
            // 
            this.lblPostalCode.AutoSize = true;
            this.lblPostalCode.Location = new System.Drawing.Point(41, 223);
            this.lblPostalCode.Name = "lblPostalCode";
            this.lblPostalCode.Size = new System.Drawing.Size(84, 17);
            this.lblPostalCode.TabIndex = 5;
            this.lblPostalCode.Text = "Postal Code";
            // 
            // lblProvince
            // 
            this.lblProvince.AutoSize = true;
            this.lblProvince.Location = new System.Drawing.Point(326, 175);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(63, 17);
            this.lblProvince.TabIndex = 4;
            this.lblProvince.Text = "Province";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(94, 175);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(31, 17);
            this.lblCity.TabIndex = 3;
            this.lblCity.Text = "City";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(65, 128);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(60, 17);
            this.lblAddress.TabIndex = 2;
            this.lblAddress.Text = "Address";
            // 
            // lblSupCompanyName
            // 
            this.lblSupCompanyName.AutoSize = true;
            this.lblSupCompanyName.Location = new System.Drawing.Point(17, 80);
            this.lblSupCompanyName.Name = "lblSupCompanyName";
            this.lblSupCompanyName.Size = new System.Drawing.Size(108, 17);
            this.lblSupCompanyName.TabIndex = 1;
            this.lblSupCompanyName.Text = "Company Name";
            // 
            // lblSupID
            // 
            this.lblSupID.AutoSize = true;
            this.lblSupID.Location = new System.Drawing.Point(48, 35);
            this.lblSupID.Name = "lblSupID";
            this.lblSupID.Size = new System.Drawing.Size(77, 17);
            this.lblSupID.TabIndex = 0;
            this.lblSupID.Text = "Supplier ID";
            // 
            // gbContactInfo
            // 
            this.gbContactInfo.Controls.Add(this.txtEmail);
            this.gbContactInfo.Controls.Add(this.txtFax);
            this.gbContactInfo.Controls.Add(this.txtPhone);
            this.gbContactInfo.Controls.Add(this.lblEmail);
            this.gbContactInfo.Controls.Add(this.lblFax);
            this.gbContactInfo.Controls.Add(this.lblPhone);
            this.gbContactInfo.Location = new System.Drawing.Point(592, 404);
            this.gbContactInfo.Name = "gbContactInfo";
            this.gbContactInfo.Size = new System.Drawing.Size(385, 174);
            this.gbContactInfo.TabIndex = 4;
            this.gbContactInfo.TabStop = false;
            this.gbContactInfo.Text = "Contact Information";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(113, 131);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(229, 22);
            this.txtEmail.TabIndex = 16;
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(113, 83);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(229, 22);
            this.txtFax.TabIndex = 15;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(113, 35);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(229, 22);
            this.txtPhone.TabIndex = 14;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(40, 131);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 17);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email";
            // 
            // lblFax
            // 
            this.lblFax.AutoSize = true;
            this.lblFax.Location = new System.Drawing.Point(52, 83);
            this.lblFax.Name = "lblFax";
            this.lblFax.Size = new System.Drawing.Size(30, 17);
            this.lblFax.TabIndex = 1;
            this.lblFax.Text = "Fax";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(33, 38);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(49, 17);
            this.lblPhone.TabIndex = 0;
            this.lblPhone.Text = "Phone";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(657, 676);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(96, 30);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(769, 676);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(96, 30);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(881, 676);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(96, 30);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // SupplierCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 722);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gbContactInfo);
            this.Controls.Add(this.gbCompanyInfo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.dgvSupplierCatalog);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SupplierCatalog";
            this.Text = "Supplier Catalog";
            this.Load += new System.EventHandler(this.SupplierCatalog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplierCatalog)).EndInit();
            this.gbCompanyInfo.ResumeLayout(false);
            this.gbCompanyInfo.PerformLayout();
            this.gbContactInfo.ResumeLayout(false);
            this.gbContactInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSupplierCatalog;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox gbCompanyInfo;
        private System.Windows.Forms.TextBox txtAffiliations;
        private System.Windows.Forms.Label lblAffiliations;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.TextBox txtProvince;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.TextBox txtSupplierID;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblPostalCode;
        private System.Windows.Forms.Label lblProvince;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblSupCompanyName;
        private System.Windows.Forms.Label lblSupID;
        private System.Windows.Forms.GroupBox gbContactInfo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblFax;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}

