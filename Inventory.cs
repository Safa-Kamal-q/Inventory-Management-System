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

        public void AddingItem(Product product)
        {
            products.Add(product);
            Console.WriteLine("Item added successfully");
        }

        public void DisplayingAllProducts()
        {
            if (products.Count == 0)
            {
                Console.WriteLine("No products to display");
                return;
            }

            Console.WriteLine("All Products\n========================================");
            foreach (Product product in products)
            {
                product.Display();
            }
            Console.WriteLine("========================================");
        }

        public void EditingItem (String productName, String? newName = null, decimal? newPrice= null, int? newQuantity=null )
        {
            Product? product = products.Find(p => p.Name.ToLowerInvariant().Equals(productName.ToLowerInvariant()));

            if (product == null )
            {
                Console.WriteLine($"Product {productName} not found.");
                return;
            }

            if (newName != null)
            {
                product.Name = newName;
            }

            if (newPrice != null)
            {
                product.Price = (decimal)newPrice;
            }

            if (newQuantity != null)
            {
                product.Quantity = (int)newQuantity;
            }

            Console.WriteLine("Product details updated successfully ");
        }

        public void RemovingItem(String productName)
        {
            Product? product = products.Find(p => p.Name.ToLowerInvariant().Equals(productName.ToLowerInvariant()));

            if(product == null)
            {
                Console.WriteLine($"Product {productName} not found.");
                return;
            }

            products.Remove(product);

            Console.WriteLine("Product remove successfully");
        }

        public void SearchingProduct(String productName)
        {
            Product? product = products.Find(p => p.Name.ToLowerInvariant().Equals(productName.ToLowerInvariant())); 

            if(product == null)
            {
                Console.WriteLine($"Product {productName} not found");
                return;
            }

            Console.WriteLine("============================");
            product.Display();
            Console.WriteLine("============================");
        }
    }
}
