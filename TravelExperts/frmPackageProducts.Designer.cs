namespace TravelExperts {
    partial class frmPackageProducts {
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
            this.dgvPackagesProductsSuppliers = new System.Windows.Forms.DataGridView();
            this.lblProducts = new System.Windows.Forms.Label();
            this.cmbProducts = new System.Windows.Forms.ComboBox();
            this.lblSuppliers = new System.Windows.Forms.Label();
            this.cmbSuppliers = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackagesProductsSuppliers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPackagesProductsSuppliers
            // 
            this.dgvPackagesProductsSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPackagesProductsSuppliers.Location = new System.Drawing.Point(3, 0);
            this.dgvPackagesProductsSuppliers.Name = "dgvPackagesProductsSuppliers";
            this.dgvPackagesProductsSuppliers.RowTemplate.Height = 24;
            this.dgvPackagesProductsSuppliers.Size = new System.Drawing.Size(240, 224);
            this.dgvPackagesProductsSuppliers.TabIndex = 0;
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Location = new System.Drawing.Point(269, 13);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(68, 17);
            this.lblProducts.TabIndex = 1;
            this.lblProducts.Text = "Products:";
            // 
            // cmbProducts
            // 
            this.cmbProducts.FormattingEnabled = true;
            this.cmbProducts.Location = new System.Drawing.Point(272, 37);
            this.cmbProducts.Name = "cmbProducts";
            this.cmbProducts.Size = new System.Drawing.Size(121, 24);
            this.cmbProducts.TabIndex = 2;
            // 
            // lblSuppliers
            // 
            this.lblSuppliers.AutoSize = true;
            this.lblSuppliers.Location = new System.Drawing.Point(269, 80);
            this.lblSuppliers.Name = "lblSuppliers";
            this.lblSuppliers.Size = new System.Drawing.Size(71, 17);
            this.lblSuppliers.TabIndex = 3;
            this.lblSuppliers.Text = "Suppliers:";
            // 
            // cmbSuppliers
            // 
            this.cmbSuppliers.FormattingEnabled = true;
            this.cmbSuppliers.Location = new System.Drawing.Point(272, 102);
            this.cmbSuppliers.Name = "cmbSuppliers";
            this.cmbSuppliers.Size = new System.Drawing.Size(121, 24);
            this.cmbSuppliers.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(262, 159);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(176, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(262, 198);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(176, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete Selected Product";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // frmPackageProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 236);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbSuppliers);
            this.Controls.Add(this.lblSuppliers);
            this.Controls.Add(this.cmbProducts);
            this.Controls.Add(this.lblProducts);
            this.Controls.Add(this.dgvPackagesProductsSuppliers);
            this.Name = "frmPackageProducts";
            this.Text = "frmPackageProducts";
            this.Load += new System.EventHandler(this.frmPackageProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackagesProductsSuppliers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPackagesProductsSuppliers;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.ComboBox cmbProducts;
        private System.Windows.Forms.Label lblSuppliers;
        private System.Windows.Forms.ComboBox cmbSuppliers;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
    }
}