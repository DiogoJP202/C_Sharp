namespace ListsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product> { 
                new Product("Apple", 0.8),
                new Product("Banana", 0.30),
                new Product("Cherry", 3.80),
            };

            Console.WriteLine("Available Products: ");

            foreach (Product product in products)
            {
                Console.WriteLine($"Product name: {product.Name} for R${product.Price}");
            }

            // 'Where' comes from Linq Package.
            // The 'Where' method will return an Enumerable, which is another type of list in Collections. 
            List<Product> cheapProducts = products.Where(p => p.Price < 1.0).ToList();

            Console.WriteLine("\nProducts that are less than 1 dollar:");

            foreach (Product product in cheapProducts)
            {
                Console.WriteLine($"Product name: {product.Name} for R${product.Price}");
            }

            Console.ReadKey();
        }
    }
}
