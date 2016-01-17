/*
 * Title: PackagesDB
 * Author: Stephen Strome
 * Last Date Updated: January 17, 2016
 * 
 * The background operation for getting data from the database, adding data, modifying it, and deleting it.
 * Connects to TravelPackagesDB, and is called from frmPackages, frmAddPackage, and frmModifyPackage.
 */

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

        public static int ModifyPackage(Package oldPackage, Package newPackage) {
            string updateStatement = "UPDATE Packages SET PkgName = @newPkgName, "
                + "PkgStartDate = @newPkgStartDate, "
                + "PkgEndDate = @newPkgEndDate,"
                + "PkgDesc = @newPkgDesc, "
                + "PkgBasePrice = @newPkgBasePrice, "
                + "PkgAgencyCommission = @newPkgAgencyCommission WHERE "
                + "PkgName = @oldPkgName AND PkgStartDate = @oldPkgStartDate AND PkgEndDate = @oldPkgEndDate "
                + "AND PkgDesc = @oldPkgDesc AND PkgBasePrice = @oldPkgBasePrice AND "
                + "PkgAgencyCommission = @oldPkgAgencyCommission";
            SqlConnection connect = TravelExpertsDB.GetConnection();

            SqlCommand updateCommand = new SqlCommand(updateStatement, connect);
            updateCommand.Parameters.AddWithValue("@newPkgName", newPackage.PkgName);
            updateCommand.Parameters.AddWithValue("@newPkgStartDate", newPackage.PkgStartDate);
            updateCommand.Parameters.AddWithValue("@newPkgEndDate", newPackage.PkgEndDate);
            updateCommand.Parameters.AddWithValue("@newPkgDesc", newPackage.PkgDesc);
            updateCommand.Parameters.AddWithValue("@newPkgBasePrice", newPackage.PkgBasePrice);
            updateCommand.Parameters.AddWithValue("@newPkgAgencyCommission", newPackage.PkgAgencyCommission);

            updateCommand.Parameters.AddWithValue("@oldPkgName", oldPackage.PkgName);
            updateCommand.Parameters.AddWithValue("@oldPkgStartDate", oldPackage.PkgStartDate);
            updateCommand.Parameters.AddWithValue("@oldPkgEndDate", oldPackage.PkgEndDate);
            updateCommand.Parameters.AddWithValue("@oldPkgDesc", oldPackage.PkgDesc);
            updateCommand.Parameters.AddWithValue("@oldPkgBasePrice", oldPackage.PkgBasePrice);
            updateCommand.Parameters.AddWithValue("@oldPkgAgencyCommission", oldPackage.PkgAgencyCommission);

            int check = 0;

            try {
                connect.Open();
                check = updateCommand.ExecuteNonQuery();
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
