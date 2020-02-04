using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBConnector
{
    public class Product
    {
        public int ProductID { get; set; }

        public string ProdName { get; set; }


        public Product CopyProduct()
        {
            Product copy = new Product();
            copy.ProductID = ProductID; ; // this customer's ID
            copy.ProdName = ProdName;
            return copy;
        }
    }
}
