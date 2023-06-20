namespace PatternTraining1
{
    internal class Program
    {
        static ProductFactory productFactory;
        static List<Product> allProducts = new List<Product>();
        static void Main(string[] args)
        {
            productFactory = new BookFactory();
            Product book = productFactory.CreateProduct();
            productFactory = new PhoneFactory();
            Product phone = productFactory.CreateProduct();
            allProducts.Add(book);
            allProducts.Add(phone);
            foreach(var product in allProducts)
            {
                Console.WriteLine($"Product: {product.GetName()}, Price: {product.GetPrice()}$");
            }
            Console.ReadLine();
        }
    }
}