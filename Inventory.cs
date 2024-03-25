namespace Inventory_Management_System
{
    internal class Inventory
    {
        private List<Product> products;

        internal Inventory()
        {
            products = new List<Product>();
        }

        internal void AddItem(Product product)
        {
            products.Add(product);
        }

        internal List<Product> DisplayAllProducts()
        {
            if (products.Count == 0)
            {
                throw new Exception("No products to display");

            }

            return products;
        }

        internal void EditItem (string productName, string newName, string newPrice, string newQuantity )
        {
            var product = products.Find(p => p.Name.Equals(productName, StringComparison.OrdinalIgnoreCase));

            if (product == null )
            {
                throw new Exception($"Product {productName} not found.");
            }

            if (newName != String.Empty)
            {
                Console.WriteLine(newName);
                product.Name = newName;
            }

            if (newPrice != String.Empty)
            {
                decimal price;
                decimal.TryParse(newPrice, out price);
                product.Price = price;
            }

            if (newQuantity != String.Empty)
            {
                int quantity;
                int.TryParse(newQuantity, out quantity);
                product.Quantity = quantity;
            }

        }

        internal void RemoveItem(String productName)
        {
            var product = products.Find(p => p.Name.Equals(productName, StringComparison.OrdinalIgnoreCase));

            if(product == null)
            {
                throw new Exception($"Product {productName} not found.");
            }

            products.Remove(product);

        }

        internal Product SearchProduct(String productName)
        {
            var product = products.Find(p => p.Name.Equals(productName, StringComparison.OrdinalIgnoreCase)); 

            if(product == null)
            {
                throw new Exception($"Product {productName} not found");
            }

            return product;
        }
    }
}
