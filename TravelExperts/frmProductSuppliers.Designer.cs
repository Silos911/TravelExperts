namespace TravelExperts
{
    partial class frmProductSuppliers
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
            this.dgvProductsSuppliers = new System.Windows.Forms.DataGridView();
            this.btnAddProductSupplier = new System.Windows.Forms.Button();
            this.btnEditProductSupplier = new System.Windows.Forms.Button();
            this.btnDeleteProductSupplier = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsSuppliers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProductsSuppliers
            // 
            this.dgvProductsSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductsSuppliers.Location = new System.Drawing.Point(63, 34);
            this.dgvProductsSuppliers.MultiSelect = false;
            this.dgvProductsSuppliers.Name = "dgvProductsSuppliers";
            this.dgvProductsSuppliers.RowTemplate.Height = 24;
            this.dgvProductsSuppliers.Size = new System.Drawing.Size(703, 245);
            this.dgvProductsSuppliers.TabIndex = 1;
            // 
            // btnAddProductSupplier
            // 
            this.btnAddProductSupplier.Location = new System.Drawing.Point(63, 323);
            this.btnAddProductSupplier.Name = "btnAddProductSupplier";
            this.btnAddProductSupplier.Size = new System.Drawing.Size(116, 45);
            this.btnAddProductSupplier.TabIndex = 2;
            this.btnAddProductSupplier.Text = "Add Product Supplier";
            this.btnAddProductSupplier.UseVisualStyleBackColor = true;
            this.btnAddProductSupplier.Click += new System.EventHandler(this.btnAddProductSupplier_Click);
            // 
            // btnEditProductSupplier
            // 
            this.btnEditProductSupplier.Location = new System.Drawing.Point(354, 323);
            this.btnEditProductSupplier.Name = "btnEditProductSupplier";
            this.btnEditProductSupplier.Size = new System.Drawing.Size(116, 45);
            this.btnEditProductSupplier.TabIndex = 3;
            this.btnEditProductSupplier.Text = "Edit Product Supplier";
            this.btnEditProductSupplier.UseVisualStyleBackColor = true;
            // 
            // btnDeleteProductSupplier
            // 
            this.btnDeleteProductSupplier.Location = new System.Drawing.Point(650, 323);
            this.btnDeleteProductSupplier.Name = "btnDeleteProductSupplier";
            this.btnDeleteProductSupplier.Size = new System.Drawing.Size(116, 45);
            this.btnDeleteProductSupplier.TabIndex = 4;
            this.btnDeleteProductSupplier.Text = "Delete Product Supplier";
            this.btnDeleteProductSupplier.UseVisualStyleBackColor = true;
            // 
            // frmProductSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 446);
            this.Controls.Add(this.btnDeleteProductSupplier);
            this.Controls.Add(this.btnEditProductSupplier);
            this.Controls.Add(this.btnAddProductSupplier);
            this.Controls.Add(this.dgvProductsSuppliers);
            this.Name = "frmProductSuppliers";
            this.Text = "frmProducts_Suppliers";
            this.Load += new System.EventHandler(this.frmProducts_Suppliers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsSuppliers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductsSuppliers;
        private System.Windows.Forms.Button btnAddProductSupplier;
        private System.Windows.Forms.Button btnEditProductSupplier;
        private System.Windows.Forms.Button btnDeleteProductSupplier;
    }
}