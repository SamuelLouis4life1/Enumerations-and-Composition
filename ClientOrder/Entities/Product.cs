using System;
using System.Collections.Generic;
using System.Text;

namespace ClientOrder.Entities
{
    class Product
    {
        public string ProductName { get; set; }
        public double Price { get; set; }

        public Product()
        {
        }

        public Product(string name, double price)
        {
            ProductName = name;
            Price = price;
        }
    }
}
