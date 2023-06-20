using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternTraining1
{
    public class Phone : Product
    {
        public override string GetName()
        {
            return "Phone";
        }
        public override int GetPrice()
        {
            return 2000;
        }
    }
}
