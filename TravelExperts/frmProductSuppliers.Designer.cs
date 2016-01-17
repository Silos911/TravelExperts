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
            // frmProducts_Suppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 446);
            this.Controls.Add(this.dgvProductsSuppliers);
            this.Name = "frmProducts_Suppliers";
            this.Text = "frmProducts_Suppliers";
            this.Load += new System.EventHandler(this.frmProducts_Suppliers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsSuppliers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductsSuppliers;
    }
}