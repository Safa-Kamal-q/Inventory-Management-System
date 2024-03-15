using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System
{
    internal class Product
    {
        private String name { get; set; }
        private decimal price { get; set; }
        private int quantity { get; set; }

        public Product(String name, decimal price, int quantity) 
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }

        public String display()
        {
            return $"Name: {name}, price: {price}, quantity: {quantity}";
        }
    }
}
