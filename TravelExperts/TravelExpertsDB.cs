/*
    Title:              TravelExpertsDB Class
    Author:             Stephen Strome
    Last Date Updated:  January 11, 2016

    This class will return a connection to the TravelExperts database. It reads one line
    from databasestring.txt to know where to connect to, then establishes a connection.

    Testing, delete this line
*/

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExperts {
    class TravelExpertsDB {
        public static SqlConnection GetConnection() {
            try {
                //Read a line from where your connection string should be stored
                StreamReader file = new StreamReader("databasestring.txt");
                string databaseConnection = file.ReadLine();

                SqlConnection connect = new SqlConnection(databaseConnection);
                return connect;
            }
            catch(Exception e) {
                throw e;
            }
        }
    }
}
