using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternTraining1
{
    public class Book : Product
    {
        public override string GetName()
        {
            return "Book";
        }

        public override int GetPrice()
        {
            return 500;
        }
    }
}
