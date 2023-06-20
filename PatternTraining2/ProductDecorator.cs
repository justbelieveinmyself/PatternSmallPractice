using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternTraining2
{
    public class ProductDecorator : IProduct
    {
        protected IProduct decoratedProduct;
        public ProductDecorator(IProduct decoratedProduct)
        {
            this.decoratedProduct = decoratedProduct;
        }
        public virtual string GetName()
        {
            return decoratedProduct.GetName();
        }
        public virtual int GetPrice()
        {
            return decoratedProduct.GetPrice();
        }

    }
}
