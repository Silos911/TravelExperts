using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExperts {
    static class PackagesProductsSuppliersDB {
        public static List<PackagesProductsSuppliers> GetAllPackagesProductsSuppliers(int packageId) {
            string selectStatement = 
                "SELECT pps.ProductSupplierId, ProdName, SupName FROM "
                + "Packages_Products_Suppliers pps, Products p, Suppliers s, Products_Suppliers ps "
                + "WHERE pps.ProductSupplierId = ps.ProductSupplierId AND ps.ProductId = p.ProductId "
                + "AND ps.SupplierId = s.SupplierId AND pps.PackageId = @PackageId";

            SqlConnection connect = TravelExpertsDB.GetConnection();
            SqlCommand selectCommand = new SqlCommand(selectStatement, connect);
            selectCommand.Parameters.AddWithValue("@PackageId", packageId);

            List<PackagesProductsSuppliers> allProducts = new List<PackagesProductsSuppliers>();
            PackagesProductsSuppliers newInput;

            try {
                connect.Open();
                SqlDataReader read = selectCommand.ExecuteReader();

                while (read.Read()) {
                    newInput = new PackagesProductsSuppliers();
                    newInput.ProductSupplierId = Convert.ToInt32(read["ProductSupplierId"]);
                    newInput.ProductName = read["ProdName"].ToString();
                    newInput.SupplierName = read["SupName"].ToString();
                    allProducts.Add(newInput);
                }
            }
            catch (Exception e) {
                throw e;
            }
            finally {
                connect.Close();
            }
            return allProducts;
        }
    

    }
}
