namespace TravelExperts
{
    partial class frmAddEditDeleteProductSupplier
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtProductSupplierId = new System.Windows.Forms.TextBox();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSupplierId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAcceptProdSupplier = new System.Windows.Forms.Button();
            this.btnCancelProdSupplier = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Supplier ID";
            // 
            // txtProductSupplierId
            // 
            this.txtProductSupplierId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductSupplierId.Location = new System.Drawing.Point(432, 76);
            this.txtProductSupplierId.Name = "txtProductSupplierId";
            this.txtProductSupplierId.Size = new System.Drawing.Size(156, 28);
            this.txtProductSupplierId.TabIndex = 1;
            // 
            // txtProductId
            // 
            this.txtProductId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductId.Location = new System.Drawing.Point(432, 166);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(156, 28);
            this.txtProductId.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(123, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Product ID";
            // 
            // txtSupplierId
            // 
            this.txtSupplierId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierId.Location = new System.Drawing.Point(432, 253);
            this.txtSupplierId.Name = "txtSupplierId";
            this.txtSupplierId.Size = new System.Drawing.Size(156, 28);
            this.txtSupplierId.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(123, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Supplier Id";
            // 
            // btnAcceptProdSupplier
            // 
            this.btnAcceptProdSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcceptProdSupplier.Location = new System.Drawing.Point(127, 367);
            this.btnAcceptProdSupplier.Name = "btnAcceptProdSupplier";
            this.btnAcceptProdSupplier.Size = new System.Drawing.Size(115, 47);
            this.btnAcceptProdSupplier.TabIndex = 6;
            this.btnAcceptProdSupplier.Text = "Accept";
            this.btnAcceptProdSupplier.UseVisualStyleBackColor = true;
            this.btnAcceptProdSupplier.Click += new System.EventHandler(this.btnAcceptProdSupplier_Click);
            // 
            // btnCancelProdSupplier
            // 
            this.btnCancelProdSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelProdSupplier.Location = new System.Drawing.Point(473, 367);
            this.btnCancelProdSupplier.Name = "btnCancelProdSupplier";
            this.btnCancelProdSupplier.Size = new System.Drawing.Size(115, 47);
            this.btnCancelProdSupplier.TabIndex = 7;
            this.btnCancelProdSupplier.Text = "Cancel";
            this.btnCancelProdSupplier.UseVisualStyleBackColor = true;
            // 
            // AddEditDeleteProductSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 466);
            this.Controls.Add(this.btnCancelProdSupplier);
            this.Controls.Add(this.btnAcceptProdSupplier);
            this.Controls.Add(this.txtSupplierId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtProductId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProductSupplierId);
            this.Controls.Add(this.label1);
            this.Name = "AddEditDeleteProductSupplier";
            this.Text = "AddEditDeleteProductSupplier";
            this.Load += new System.EventHandler(this.AddEditDeleteProductSupplier_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProductSupplierId;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSupplierId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAcceptProdSupplier;
        private System.Windows.Forms.Button btnCancelProdSupplier;
    }
}