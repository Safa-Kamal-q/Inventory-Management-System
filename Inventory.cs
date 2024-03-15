using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System
{
    internal class Inventory
    {
        private List<Product> products;

        public Inventory()
        {
            products = new List<Product>();
        }

        public void addingItem(Product product)
        {
            products.Add(product);
            Console.WriteLine("Item added successfully");
        }
    }
}
