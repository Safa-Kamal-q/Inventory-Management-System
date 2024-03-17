using System.Diagnostics.Metrics;
using System.Numerics;
using System.Xml.Linq;

namespace Inventory_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();

            bool exit = false;

            do
            {
                Console.WriteLine("********************************");
                Console.WriteLine("Menu: ");
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. View All Product");
                Console.WriteLine("3. Edit Product by its name");
                Console.WriteLine("4. Delet Product ");
                Console.WriteLine("5. Search for a Product");
                Console.WriteLine("6. Exit");
                Console.WriteLine("********************************");

                int choice;

                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice) 
                    {
                        case 1:
                            Console.Write("Enter product name:");
                            String productName = Console.ReadLine();
                            Console.Write("Enter product price:");
                            decimal productPrice;
                            decimal.TryParse(Console.ReadLine(), out productPrice);
                            Console.Write("Enter product quantity:");
                            int productQuantity;
                            int.TryParse(Console.ReadLine(), out productQuantity);

                            inventory.AddItem(new Product(productName, productPrice, productQuantity));
                            Console.WriteLine("Item added successfully");
                            break;

                        case 2:
                            try
                            {
                                List<Product> products = inventory.DisplayAllProducts();

                                Console.WriteLine("All Products\n========================================");
                                foreach (Product product in products)
                                {
                                    Console.WriteLine(product.Display());
                                }
                                Console.WriteLine("========================================");

                            }catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);                    
                            }
                            break;

                        case 3:
                            Console.WriteLine("Please enter the name of the product you want to edit:") ;
                            String searchName= Console.ReadLine();
                            Console.Write("Enter a new name if you want to change the name, otherwise press enter: ");
                            String? newName = Console.ReadLine();
                            Console.Write("Enter a new price if you want to change the price, otherwise press enter: ");
                            String? newPrice = Console.ReadLine();
                            Console.Write("Enter a new quantity if you want to change the quantity, otherwise press enter: ");
                            String? newQuantity = Console.ReadLine();

                            try
                            {
                                inventory.EditItem(searchName, newName, newPrice, newQuantity);
                                Console.WriteLine("Product details updated successfully ");

                            }catch(Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }

                            break;

                        case 4:
                            Console.WriteLine("Please enter the name of the product you want to delete:");
                            String deleteSearchName = Console.ReadLine();

                            try
                            {
                                inventory.RemoveItem(deleteSearchName);
                                Console.WriteLine("Product remove successfully");

                            }catch( Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            break;

                        case 5:
                            Console.WriteLine("Please enter the name of the product you want to search for:");
                            String searchProductName= Console.ReadLine();

                            try
                            {
                                Product product = inventory.SearchProduct(searchProductName);
                                Console.WriteLine("============================");
                                Console.WriteLine(product.Display());
                                Console.WriteLine("============================");

                            }catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            
                            break;

                        case 6:
                            exit = true;
                            break;

                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                }

            } while (!exit);
        }
    }
}
