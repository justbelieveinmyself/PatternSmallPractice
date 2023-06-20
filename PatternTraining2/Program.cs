namespace PatternTraining2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IProduct book = new Book("Мастер и Маргарита", 10000);
            IProduct discountedBook = new DiscountProductDecorator(book, 0.2);

            Console.WriteLine("Имя продукта: " + book.GetName());
            Console.WriteLine("Цена: " + book.GetPrice());

            Console.WriteLine();

            Console.WriteLine("Имя продукта со скидкой: " + discountedBook.GetName());
            Console.WriteLine("Его новая цена: " + discountedBook.GetPrice());

        }
    }
}