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
                Console.WriteLine(product.Display());
            }
            Console.WriteLine("========================================");
        }

        public void EditingItem (String productName)
        {
            Product? product = products.Find(p => p.Name.Equals(productName, StringComparison.OrdinalIgnoreCase));

            if (product == null )
            {
                Console.WriteLine($"Product {productName} not found.");
                return;
            }

            Console.Write("Enter a new name if you want to change the name, otherwise press enter: ");
            String? newName = Console.ReadLine();
            Console.Write("Enter a new price if you want to change the price, otherwise press enter: ");
            String? newPrice = Console.ReadLine();
            Console.Write("Enter a new quantity if you want to change the quantity, otherwise press enter: ");
            String? newQuantity = Console.ReadLine();

            
            if (newName != "")
            {
                Console.WriteLine(newName);
                product.Name = newName;
            }

            if (newPrice != "")
            {
                decimal price;
                decimal.TryParse(newPrice, out price);
                product.Price = price;
            }

            if (newQuantity != "")
            {
                int quantity;
                int.TryParse(newQuantity, out quantity);
                product.Quantity = quantity;
            }

            Console.WriteLine("Product details updated successfully ");
        }

        public void RemovingItem(String productName)
        {
            Product? product = products.Find(p => p.Name.Equals(productName, StringComparison.OrdinalIgnoreCase));

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
            Product? product = products.Find(p => p.Name.Equals(productName, StringComparison.OrdinalIgnoreCase)); 

            if(product == null)
            {
                Console.WriteLine($"Product {productName} not found");
                return;
            }

            Console.WriteLine("============================");
            Console.WriteLine(product.Display());
            Console.WriteLine("============================");
        }
    }
}
