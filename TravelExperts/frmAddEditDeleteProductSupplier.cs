﻿/*
Title:             AddEditDeleteProductSuppliers form code 
Author:            Deya Cerdas
Last Date updated: 2016-01-16
Description:                
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelExperts
{
    public partial class frmAddEditDeleteProductSupplier : Form
    {
        public frmAddEditDeleteProductSupplier()
        {
            InitializeComponent();
        }
        public bool addProductSupplier;
        public ProductSupplier productSupplier;

        private void AddEditDeleteProductSupplier_Load(object sender, EventArgs e)
        {
            //Depending on user's action, put corresponding title
            if (addProductSupplier)
            {
                this.Text = "Add Product Supplier";
                txtProductSupplierId.Enabled = true;
            }
            else
            {
                this.Text = "Modify Product Supplier";
                this.DisplayProductSupplier();
                txtProductSupplierId.Enabled = false;
            }
        }
        //Method to show product supplier info
        private void DisplayProductSupplier()
        {
            txtProductSupplierId.Text = productSupplier.ProductSupplierId.ToString();
            txtProductId.Text = productSupplier.ProductId.ToString();
            txtSupplierId.Text = productSupplier.SupplierId.ToString();
        }

        private void btnAcceptProdSupplier_Click(object sender, EventArgs e)
        {
            //When user clicks accept button, validate data
           // if (isValidData())
           // {
                //If valid, add/modify product
                if (addProductSupplier)
                {
                    productSupplier = new ProductSupplier();
                    //this.PutProductSupplierData(productSupplier);
                    try
                    {
                        //Get ID of the new product supplier created
                        //productSupplier.ProductId = ProductSuppliersDB.AddProductSupplier(productSupplier.ToString());//HAD ISSUE WITH CONVERSION, AND ACCEPTED VS OPTION OF CREATING METHOD
                        this.DialogResult = DialogResult.OK;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                }
                else
                {
                    ProductSupplier newProductSupplier = new ProductSupplier();
                    newProductSupplier.ProductSupplierId = productSupplier.ProductSupplierId;
                    //this.PutProductSupplierData(newProductSupplier);
                    try
                    {
                        //If product not updated, show error message
                        if (!ProductSuppliersDB.UpdateProductSupplier(productSupplier, newProductSupplier))
                        {
                            MessageBox.Show("Another user has updated or delete that product supplier.", "Database error");
                            this.DialogResult = DialogResult.Retry;
                        }
                        else
                        {
                            //Else, if product supplier updated, display it
                            productSupplier = newProductSupplier;
                            this.DialogResult = DialogResult.OK;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        //Validates if values are present and if they are the correct types 
        //private bool isValidData()
        //{
        //    return
               //Validator.IsPresent(txtProductSupplierId) &&
               //Validator.IsPositiveInt32(txtProductSupplierId) &&
               //Validator.IsPositiveInt32(txtProductId) &&
               //Validator.IsPositiveInt32(txtSupplierId);
        //}
        //Load product data 
        //private void PutProductSupplierData(ProductSupplier productSupplier)
        //{
        //    productSupplier.ProductSupplierId = Convert.ToInt32(txtProductSupplierId.Text);
        //    productSupplier.ProductId = Convert.ToInt32(txtProductId.Text);
        //    productSupplier.SupplierId = Convert.ToInt32(txtSupplierId.Text);
        //}
    }
//}
