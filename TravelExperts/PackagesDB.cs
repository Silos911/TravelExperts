using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExperts {
    class PackagesDB {
        public static List<Package> GetAllPackages() {
            SqlConnection connect = TravelExpertsDB.GetConnection();
            string selectStatement = "SELECT * FROM Packages";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connect);
            List<Package> allPackages = new List<Package>();
            Package newPackage;

            try {
                connect.Open();
                SqlDataReader read = selectCommand.ExecuteReader();

                while (read.Read()) {
                    newPackage = new Package();
                    newPackage.PackageID = Convert.ToInt32(read["PackageID"]);
                    newPackage.PkgName = Convert.ToString(read["PkgName"]);
                    newPackage.PkgStartDate = Convert.ToDateTime(read["PkgStartDate"]);
                    newPackage.PkgEndDate = Convert.ToDateTime(read["PkgEndDate"]);
                    newPackage.PkgDesc = Convert.ToString(read["PkgDesc"]);
                    newPackage.PkgBasePrice = Convert.ToDecimal(read["PkgBasePrice"]);
                    newPackage.PkgAgencyCommission = Convert.ToDecimal(read["PkgAgencyCommission"]);
                    allPackages.Add(newPackage);
                }
            }
            catch(Exception e) {
                throw e;
            }
            finally {
                connect.Close();
            }
            return allPackages;
        }

        public static int AddPackage(Package newPackage)
        {
            int check = 0;

            SqlConnection connect = TravelExpertsDB.GetConnection();
            string insertStatement = "INSERT INTO Packages (PkgName, PkgStartDate, PkgEndDate, PkgDesc, PkgBasePrice, PkgAgencyCommission) VALUES (@PkgName, @PkgStartDate, @PkgEndDate, @PkgDesc, @PkgBasePrice, @PkgAgencyCommission)";
            SqlCommand insertCommand = new SqlCommand(insertStatement, connect);
            insertCommand.Parameters.AddWithValue("@PkgName", newPackage.PkgName);
            insertCommand.Parameters.AddWithValue("@PkgStartDate", newPackage.PkgStartDate);
            insertCommand.Parameters.AddWithValue("@PkgEndDate", newPackage.PkgEndDate);
            insertCommand.Parameters.AddWithValue("@PkgDesc", newPackage.PkgDesc);
            insertCommand.Parameters.AddWithValue("@PkgBasePrice", newPackage.PkgBasePrice);
            insertCommand.Parameters.AddWithValue("@PkgAgencyCommission", newPackage.PkgAgencyCommission);

            try {
                connect.Open();
                check = insertCommand.ExecuteNonQuery();
            }
            catch (Exception e) {
                throw e;
            }
            finally {
                connect.Close();
            }
            return check;
        }
    }
}
