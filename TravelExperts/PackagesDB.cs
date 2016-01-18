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
            SqlConnection connect = TravelExpertsDB.GetConnection(); //The connection to the database
            string selectStatement = "SELECT * FROM Packages";  //The select statement to pull the data
            SqlCommand selectCommand = new SqlCommand(selectStatement, connect);    //The command for the database
            List<Package> allPackages = new List<Package>();    //The list everything will be stored in
            Package newPackage; //The object each row will temporarily be stored in

            try {
                connect.Open();
                SqlDataReader read = selectCommand.ExecuteReader();

                //Reads each row from the database and stores it in a list
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
            string insertStatement = "INSERT INTO Packages (PkgName, PkgStartDate, PkgEndDate, "
                + "PkgDesc, PkgBasePrice, PkgAgencyCommission) VALUES (@PkgName, @PkgStartDate, "
                + "@PkgEndDate, @PkgDesc, @PkgBasePrice, @PkgAgencyCommission)";
            
            //Create the command and set all parameters
            SqlCommand insertCommand = new SqlCommand(insertStatement, connect);
            insertCommand.Parameters.AddWithValue("@PkgName", newPackage.PkgName);
            insertCommand.Parameters.AddWithValue("@PkgStartDate", newPackage.PkgStartDate);
            insertCommand.Parameters.AddWithValue("@PkgEndDate", newPackage.PkgEndDate);
            insertCommand.Parameters.AddWithValue("@PkgDesc", newPackage.PkgDesc);
            insertCommand.Parameters.AddWithValue("@PkgBasePrice", newPackage.PkgBasePrice);
            insertCommand.Parameters.AddWithValue("@PkgAgencyCommission", newPackage.PkgAgencyCommission);

            //Try to insert the data
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
            return check;   //Return an integer that stores the amount of rows effected
        }

        public static int ModifyPackage(Package oldPackage, Package newPackage) {
            //What to update and where
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

            //Create the command and set all parameters
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

            //Try to execute command
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
            //Return result of the command
            return check;
        }

        public static int DeletePackage(Package package) {
            string deleteStatement = "DELETE FROM Packages WHERE PackageID = @PackageID AND "
                + "PkgName = @PkgName AND PkgStartDate = @PkgStartDate AND PkgEndDate = @PkgEndDate AND "
                + "PkgDesc = @PkgDesc AND PkgBasePrice = @PkgBasePrice AND "
                + "PkgAgencyCommission = @PkgAgencyCommission";
            SqlConnection connect = TravelExpertsDB.GetConnection();

            //Create command and set all parameters
            SqlCommand deleteCommand = new SqlCommand(deleteStatement, connect);
            deleteCommand.Parameters.AddWithValue("@PackageID", package.PackageID);
            deleteCommand.Parameters.AddWithValue("@PkgName", package.PkgName);
            deleteCommand.Parameters.AddWithValue("@PkgStartDate", package.PkgStartDate);
            deleteCommand.Parameters.AddWithValue("@PkgEndDate", package.PkgEndDate);
            deleteCommand.Parameters.AddWithValue("@PkgDesc", package.PkgDesc);
            deleteCommand.Parameters.AddWithValue("@PkgBasePrice", package.PkgBasePrice);
            deleteCommand.Parameters.AddWithValue("@PkgAgencyCommission", package.PkgAgencyCommission);
            int check = 0;

            //Try to delete the row of data
            try {
                connect.Open();
                check = deleteCommand.ExecuteNonQuery();
            }
            catch (Exception e) {
                throw e;
            }
            finally {
                connect.Close();
            }
            return check;
        }

        public static Package GetSinglePackage(string packageID) {
            SqlConnection connect = TravelExpertsDB.GetConnection(); //The connection to the database
            string selectStatement = "SELECT * FROM Packages WHERE PackageID = @PackageID";  //The select statement to pull the data
            SqlCommand selectCommand = new SqlCommand(selectStatement, connect);    //The command for the database
            selectCommand.Parameters.AddWithValue("@PackageID", packageID);
            Package singlePackage = new Package(); //The object each row will temporarily be stored in

            try {
                connect.Open();
                SqlDataReader read = selectCommand.ExecuteReader();

                //Reads each row from the database and stores it in a list
                while (read.Read()) {
                    singlePackage.PackageID = Convert.ToInt32(read["PackageID"]);
                    singlePackage.PkgName = Convert.ToString(read["PkgName"]);
                    singlePackage.PkgStartDate = Convert.ToDateTime(read["PkgStartDate"]);
                    singlePackage.PkgEndDate = Convert.ToDateTime(read["PkgEndDate"]);
                    singlePackage.PkgDesc = Convert.ToString(read["PkgDesc"]);
                    singlePackage.PkgBasePrice = Convert.ToDecimal(read["PkgBasePrice"]);
                    singlePackage.PkgAgencyCommission = Convert.ToDecimal(read["PkgAgencyCommission"]);
                }
            }
            catch (Exception e) {
                throw e;
            }
            finally {
                connect.Close();
            }
            return singlePackage;
        }
    }

}
