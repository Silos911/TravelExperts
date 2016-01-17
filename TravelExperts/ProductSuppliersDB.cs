/*
Title:             Products_SuppliersDB Class 
Author:            Deya Cerdas
Last Date updated: 2016-01-16
Description:       Displays data grid view of products suppliers.
                   Includes:
                   -AddProductSupplier()
                   -EditProductSupplier()
                   -DeleteProductSupplier()           
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

            //include finally?
            
        }

        //Adds new Product Supplier
        public static string AddProductSupplier(ProductSupplier newProductSupplier)
        {
            //Gets connection data
            SqlConnection connect = TravelExpertsDB.GetConnection();
            //Defining statement to retrieve info using connection above
            string insertStatement =
                "INSERT INTO Products_Suppliers " +
                "(ProductSupplierId, ProductId, SupplierId) " +
                "Values(@ProductSupplierId, @ProductId, @SupplierId)";
            SqlCommand insertCommand = new SqlCommand(insertStatement, connect);
            insertCommand.Parameters.AddWithValue("@ProductSupplierId", newProductSupplier.ProductSupplierId);
            insertCommand.Parameters.AddWithValue("@ProductId", newProductSupplier.ProductId);
            insertCommand.Parameters.AddWithValue("@SupplierId", newProductSupplier.SupplierId);
            try
            {
                //Open connection, executes insert query and verifies data was inserted
                connect.Open();
                int nr = insertCommand.ExecuteNonQuery();
                //if product was successfully inserted, show it on the main form
                if (nr > 0)
                {
                    //Defining statement to retrieve info using connection above
                    string selectStatement = "SELECT * FROM Products_Suppliers WHERE ProductSupplierId = @ProductSupplierId";
                    SqlCommand selectCommand = new SqlCommand(selectStatement, connect);
                    selectCommand.Parameters.AddWithValue("@ProductSupplierId", newProductSupplier.ProductSupplierId);
                    string newProdSupplier = selectCommand.ExecuteScalar().ToString();
                    return newProdSupplier;
                }
                else
                {
                    return null;
                }
            }
            //Catches exceptions
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connect.Close();
            }
        }

       //Update product supplier
       public static bool UpdateProductSupplier(ProductSupplier oldProductSupplier, ProductSupplier newProductSupplier)
        {
            //Gets connection data
            SqlConnection connect = TravelExpertsDB.GetConnection();
            //Defining statement to update info using connection above
            string updateStatement = "UPDATE Products_Suppliers" +
                                     "SET ProductSupplierId = @NewProductSupplierId, " +
                                     "ProductId = @NewProductId, " +
                                     "SupplierId = @NewSupplierId " +
                                     "WHERE ProductSupplierId = @OldProductSupplierId " +
                                     "  AND ProductId = @OldProductId, " +
                                     "  AND SupplierId = @OldSupplierId";
            SqlCommand updateCommand = new SqlCommand(updateStatement, connect);
            updateCommand.Parameters.AddWithValue("@NewProductSupplierId", newProductSupplier.ProductSupplierId);
            updateCommand.Parameters.AddWithValue("@NewProductId", newProductSupplier.ProductId);
            updateCommand.Parameters.AddWithValue("@NewSupplierId", newProductSupplier.SupplierId);
            try
            {
                //Open connection, executes update query and verifies data was updated
                connect.Open();
                int count = updateCommand.ExecuteNonQuery();
                if (count > 0)
                    return true;
                else
                    return false;
            }
            //Catches exceptions
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connect.Close();
            }
        }
        //Delete product supplier
        public static bool DeleteProductSupplier(ProductSupplier productSupplier)
        {
            //Gets connection data
            SqlConnection connect = TravelExpertsDB.GetConnection();
            connect.Open();
            //Define delete statement
            string deleteStatement =
                "DELETE FROM Products_Suppliers " +
                "WHERE ProductSupplierId = @ProductSupplierId";
            //Execute delete statement
            SqlCommand deleteCommand = new SqlCommand(deleteStatement, connect);
            deleteCommand.Parameters.AddWithValue("@ProductSupplierId", productSupplier.ProductSupplierId);
            deleteCommand.ExecuteNonQuery();
            return true;
        }
    }
}     