using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternTraining3
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Weight { get; set; }
        public IShippingStrategy ShippingStrategy { get; set; }
        public decimal CalculateShippingCost()
        {
            if (ShippingStrategy != null)
                return ShippingStrategy.CalculateShippingCost(this);
            else
                throw new NullReferenceException("Не выбран способ доставки для расчёта");
        }
    }
}
