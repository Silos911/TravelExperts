﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SupplierForm
{
    public static class TravelExpertsDB
    {
        public static SqlConnection GetConnection()
        {
            string connectionString = "Data Source=ICTVM-VQ2KUU8EC\\sait;Initial Catalog=TravelExperts;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}