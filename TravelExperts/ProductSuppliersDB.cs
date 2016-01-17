/*
Title:             Products_SuppliersDB Class 
Author:            Deya Cerdas
Last Date updated: 2016-01-16
Description:       Displays data grid view of products suppliers.
                   
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace TravelExperts
{
    class ProductSuppliersDB
    {
        public static List<ProductSupplier> GetAllProductSuppliers()
        {
            //Gets connection data
            SqlConnection connect = TravelExpertsDB.GetConnection();
            //Defining statement to retrieve info using connection above
            string selectStatement = "SELECT * FROM Products_Suppliers";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connect);
            List<ProductSupplier> allProductSuppliers = new List<ProductSupplier>();
            ProductSupplier newProductSupplier;

            try
            {
                connect.Open();
                SqlDataReader read = selectCommand.ExecuteReader();
                while (read.Read())
                {
                    newProductSupplier = new ProductSupplier();
                    newProductSupplier.ProductSupplierId = Convert.ToInt32(read["ProductSupplierId"]);
                    newProductSupplier.ProductId = Convert.ToInt32(read["ProductId"]);
                    newProductSupplier.SupplierId = Convert.ToInt32(read["SupplierId"]);
                    allProductSuppliers.Add(newProductSupplier);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return allProductSuppliers;
        }
    }
}