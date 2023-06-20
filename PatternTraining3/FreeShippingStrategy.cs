using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternTraining3
{
    public class FreeShippingStrategy : IShippingStrategy
    {
        public decimal CalculateShippingCost(Product product)
        {
            return 0;
        }
    }
}
