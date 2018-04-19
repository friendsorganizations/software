using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace PharmacyServer
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }
        public void add(string name, string type, string formula, int price, int quantity, DateTime exp)
        {
            StockClass st = new StockClass();
            st.ItemName = name;
            st.ItemType = type;
            st.ItemFormula = formula;
            st.ItemPrice = price;
            st.ItemQuantity = quantity;
            st.ExpiryDate = exp;
            StockDL.addProduct(st);

            //throw new NotImplementedException();
        }
        public void delete_product(string name, string type)
        {
            StockClass st = new StockClass();
            st.ItemName = name;
            st.ItemType = type;
            StockDL.deleteProduct(st);

            //throw new NotImplementedException();
        }
        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

     
    }
}
