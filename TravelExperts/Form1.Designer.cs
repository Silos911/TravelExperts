namespace TravelExperts {
    partial class Form1 {
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
            this.btnPackages = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnProductSuppliers = new System.Windows.Forms.Button();
            this.btnSuppliers = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnProductsSuppliers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPackages
            // 
            this.btnPackages.Location = new System.Drawing.Point(739, 30);
            this.btnPackages.Name = "btnPackages";
            this.btnPackages.Size = new System.Drawing.Size(105, 37);
            this.btnPackages.TabIndex = 0;
            this.btnPackages.Text = "Packages";
            this.btnPackages.UseVisualStyleBackColor = true;
            this.btnPackages.Click += new System.EventHandler(this.btnPackages_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.Location = new System.Drawing.Point(739, 112);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(105, 37);
            this.btnProducts.TabIndex = 1;
            this.btnProducts.Text = "Products";
            this.btnProducts.UseVisualStyleBackColor = true;
            // 
            // btnProductSuppliers
            // 
            this.btnProductSuppliers.Location = new System.Drawing.Point(739, 203);
            this.btnProductSuppliers.Name = "btnProductSuppliers";
            this.btnProductSuppliers.Size = new System.Drawing.Size(105, 59);
            this.btnProductSuppliers.TabIndex = 2;
            this.btnProductSuppliers.Text = "Product Suppliers";
            this.btnProductSuppliers.UseVisualStyleBackColor = true;
            // 
            // btnSuppliers
            // 
            this.btnSuppliers.Location = new System.Drawing.Point(739, 287);
            this.btnSuppliers.Name = "btnSuppliers";
            this.btnSuppliers.Size = new System.Drawing.Size(105, 37);
            this.btnSuppliers.TabIndex = 3;
            this.btnSuppliers.Text = "Suppliers";
            this.btnSuppliers.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(739, 453);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(105, 37);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnProductsSuppliers
            // 
            this.btnProductsSuppliers.Location = new System.Drawing.Point(739, 378);
            this.btnProductsSuppliers.Name = "btnProductsSuppliers";
            this.btnProductsSuppliers.Size = new System.Drawing.Size(105, 46);
            this.btnProductsSuppliers.TabIndex = 5;
            this.btnProductsSuppliers.Text = "Product Suppliers";
            this.btnProductsSuppliers.UseVisualStyleBackColor = true;
            this.btnProductsSuppliers.Click += new System.EventHandler(this.btnProductsSuppliers_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 535);
            this.Controls.Add(this.btnProductsSuppliers);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSuppliers);
            this.Controls.Add(this.btnProductSuppliers);
            this.Controls.Add(this.btnProducts);
            this.Controls.Add(this.btnPackages);
            this.Name = "Form1";
            this.Text = " ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPackages;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnProductSuppliers;
        private System.Windows.Forms.Button btnSuppliers;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnProductsSuppliers;
    }
}

