using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternTraining2
{
    public class Book : IProduct
    {
        private string name;
        private int price;
        public Book(string name, int price)
        {
            this.name = name;
            this.price = price;
        }
        public string GetName()
        {
            return name;
        }

        public int GetPrice()
        {
            return price;
        }
    }
}
