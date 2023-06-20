using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternTraining2
{
    public class DiscountProductDecorator : ProductDecorator 
    {
        private double discount;
        public DiscountProductDecorator(IProduct decoratedProduct, double discount) : base(decoratedProduct)
        {
            this.discount = discount;
        }
        public override int GetPrice()
        {
            int origPrice = decoratedProduct.GetPrice();
            double discountedPrice = origPrice - (origPrice * discount);
            return (int)discountedPrice;
        }
    }
}
