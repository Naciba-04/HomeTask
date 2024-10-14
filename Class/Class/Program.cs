namespace Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product canta = new Product("Canta", "Michael Kors", 400);
            Product ayaqqabi = new Product("Ayaqqabi", "Nike", 200);
            Product parfum = new Product("Parfum", "Libre", 350);
            Product masin = new Product("Masin", "Porsche", 93500);
            Product[] products = new Product[] { canta, ayaqqabi, parfum, masin };
            double minPrice = 100;
            double maxPrice = 100000;
            PrintProductsInRange(products, minPrice, maxPrice);
        }
        public static void PrintProductsInRange(Product[] products, double minPrice, double maxPrice)
        {
            Console.WriteLine($"Mehsullarin qiymet araligi: {minPrice} - {maxPrice}");
            foreach (var product in products)
            {
                if (product.Price >= minPrice && product.Price <= maxPrice)
                    Console.WriteLine($"{product.Name} - {product.BrandName}: {product.Price} AZN");
            }
        }
    }
}
