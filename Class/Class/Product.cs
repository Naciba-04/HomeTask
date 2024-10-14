using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
     class Product
    {
        public string Name;
        public string BrandName;
        public double Price;
        public Product(string name, string brandName, double price)
        {
            Name = name;
            this.BrandName = brandName;
            Price = price;
        }
    }
}
