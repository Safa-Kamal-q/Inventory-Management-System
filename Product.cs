using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System
{
    internal class Product
    {
        internal String Name { get; set; }
        internal decimal Price { get; set; }
        internal int Quantity { get; set; }

        internal Product(String name, decimal price, int quantity) 
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        internal String Display()
        {
            return $"Name: {Name}, price: {Price}, quantity: {Quantity}";
        }
    }
}
