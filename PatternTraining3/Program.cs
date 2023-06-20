using Microsoft.Win32.SafeHandles;
using System.Security.Cryptography.X509Certificates;

namespace PatternTraining3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product book = new Product();
            book.Name = "Разработка на C# 9";
            book.Price = 100;
            book.Weight = 10;
            book.ShippingStrategy = new FreeShippingStrategy();
            decimal shippingCost = book.CalculateShippingCost();
            Console.WriteLine($"{book.Name}, Цена: {book.Price}, Вес: {book.Weight}, Доставка {shippingCost} при бесплатной доставке.");
            book.ShippingStrategy = new WeightShippingStrategy(5); //за каждый кг 5 рублей
            shippingCost = book.CalculateShippingCost();
            Console.WriteLine($"{book.Name}, Цена: {book.Price}, Вес: {book.Weight}, Доставка {shippingCost} при платной доставке.");
        }
    }
}