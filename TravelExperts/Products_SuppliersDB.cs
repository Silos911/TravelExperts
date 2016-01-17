/*
Title:             Products_SuppliersDB Class 
Author:            Deya Cerdas
Last Date updated: 2016-01-16
Description:       Provides connection to database for this class. 
                   Includes properties:
                   -AddProductSupplier
                   -EditProductSupplier
                   -DeleteProductSupplier
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
    class Products_SuppliersDB
    {
        public static Products_Suppliers GetProductsSuppliers(string productsSuppliersId)
        {
            //Gets connection data
            SqlConnection connection = TravelExpertsDB.GetConnection();
            //Defining statement to retrieve info using connection above
            string selectStatement =
                "SELECT ProductSupplierId, ProductId, SupplierId " +
                "FROM Products_Suppliers " +
                "WHERE ProductSupplierId = @ProductSupplierId";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@ProductSupplierId", productSupplierId);
            try
            {

            }

        
    }
}

