using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProductForm
{
    public static class ProductDB
    {
        //public static int AddProduct(Product product)
        //{
        //    SqlConnection connection = TravelExpertsDB.GetConnection();
        //    string insertStatement = "INSERT INTO Products " +
        //                               "(ProdName) " +
        //                               "VALUES(@ProdName) ";
        //    SqlCommand insertCommand = new SqlCommand(insertStatement);
        //    insertCommand.Parameters.AddWithValue("@ProdName", product.ProdName);
            
        //    try
        //    {
        //        connection.Open();
        //        int id = insertCommand.ExecuteNonQuery();
        //        if (id > 0)
        //        {
        //            string selectStatement = "SELECT IDENT_CURRENT('Products') " +
        //                                     "FROM Products";
        //            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
        //            int prodID = Convert.ToInt32(selectCommand.ExecuteScalar());
        //            return prodID;                    
        //        }
        //        else
        //        {
        //            return -1;
        //        }
        //    }
        //    catch(SqlException ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        connection.Open();
        //    }
        //}

        //public static bool UpdateProduct(Product oldProduct, Product newProduct)
        //{
        //    SqlConnection connection = TravelExpertsDB.GetConnection();
        //    string updateStatement = "UPDATE Products " +
        //                              "SET ProdName = @newProdName " +
        //                              "WHERE ProductId = @ProductId " +
        //                              " AND ProdName = @oldProdName " ;
        //    SqlCommand updateCommand = new SqlCommand(updateStatement, connection);
        //    updateCommand.Parameters.AddWithValue("@newProdName", newProduct.ProdName);
        //    updateCommand.Parameters.AddWithValue("@ProductId", oldProduct.ProductId);
        //    updateCommand.Parameters.AddWithValue("@oldProdName", oldProduct.ProdName);

        //    try
        //    {
        //        connection.Open();
        //        int count = updateCommand.ExecuteNonQuery();
        //        if (count > 0)
        //        {
        //            return true;                    
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }
        //    catch(SqlException ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        connection.Close();
        //    }
        //}

        //public static bool DeleteProduct(Product product)
        //{
        //    SqlConnection connection = TravelExpertsDB.GetConnection();
        //    string deleteStatement = "DELETE FROM Products " +
        //                              "WHERE ProductId = @ProductId " +
        //                              " AND ProdName = @ProdName ";
        //    SqlCommand delectCommand = new SqlCommand(deleteStatement, connection);
        //    delectCommand.Parameters.AddWithValue("@ProdName", product.ProdName);

        //    try
        //    {
        //        connection.Close();
        //        int count = delectCommand.ExecuteNonQuery();
        //        if (count > 0)
        //        {
        //            return true;
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }
        //    catch(SqlException ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        connection.Close();
        //    }

        //}


    }
}
