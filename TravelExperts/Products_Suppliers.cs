﻿/*
Title:             Products_Suppliers Class 
Author:            Deya Cerdas
Last Date updated: 2016-01-16
Description:       Constructor for this class. 
                   Includes objects: 
                   -ProductSupplierId
                   -ProductId
                   -SupplierId
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExperts
{
    //Constructor for Products_Suppliers class
    class Products_Suppliers
    {
        public int ProductSupplierId { get; set; }

        public int ProductId { get; set; }

        public int SupplierId { get; set; }
    }
}