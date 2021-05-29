using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestProject1.dto
{
    class Product
    {
        public Product(string productname, string category, string supplier, string unitprice, string quantity, string unitsinstock, string unitsonorder, string reorderlevel, string discontinued)
        {
            Productname = productname;
            Category = category;
            Supplier = supplier;
            UnitPrice = unitprice;
            QuantityPerUnit = quantity;
            UnitsInStock = unitsinstock;
            UnitsOnOrder = unitsonorder;
            ReorderLevel = reorderlevel;
            Discontinued = discontinued;
        }

        public string Productname { get; set; }
        public string Category { get; set; }
        public string Supplier { get; set; }
        public string UnitPrice { get; set; }
        public string QuantityPerUnit { get; set; }
        public string UnitsInStock { get; set; }
        public string UnitsOnOrder { get; set; }
        public string ReorderLevel { get; set; }
        public string Discontinued { get; set; }
    }
}
