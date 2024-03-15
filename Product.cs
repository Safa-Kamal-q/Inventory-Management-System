using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System
{
    internal class Product
    {
        public String Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public Product(String name, decimal price, int quantity) 
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public String Display()
        {
            return $"Name: {Name}, price: {Price}, quantity: {Quantity}";
        }
    }
}
