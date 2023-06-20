using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternTraining3
{
    public class WeightShippingStrategy : IShippingStrategy
    {
        private decimal ratePerKg;
        public WeightShippingStrategy(decimal ratePerKg)
        {
            this.ratePerKg = ratePerKg;
        }
        public decimal CalculateShippingCost(Product product)
        {
            return product.Weight * ratePerKg;
        }
    }
}
