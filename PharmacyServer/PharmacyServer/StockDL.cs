using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PharmacyServer
{
    public class StockDL
    {
        public static List<StockClass> stocklist = new List<StockClass>();
        public static void addProduct(StockClass product)
        {
            stocklist.Add(product);
        }
       

        public static List<StockClass> deleteProduct(StockClass pr)
        {
         //   List<StockClass> sel = new List<StockClass>();
            //StockClass pr = new StockClass();
            //pr.ItemName = itemName;
            //pr.ItemType = itemType;
            foreach (StockClass st in StockDL.stocklist)
            {
                if (st.ItemName == pr.ItemName && st.ItemType==pr.ItemType)
                {
                    StockDL.stocklist.Remove(st);
                }
            }
            return stocklist;
        }
    }
}