using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternTraining1
{
    public class PhoneFactory : ProductFactory
    {
        public override Product CreateProduct()
        {
            return new Phone();
        }
    }
}
