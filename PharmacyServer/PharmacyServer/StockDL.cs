﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1
{
    public class StockDL
    {
        public static List<StockClass> stocklist = new List<StockClass>();

        public static void addProduct(StockClass product)
        {
            stocklist.Add(product);
        }
    }
}