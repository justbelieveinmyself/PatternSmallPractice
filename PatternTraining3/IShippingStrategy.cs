﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace PatternTraining3
{
    public interface IShippingStrategy
    {
        decimal CalculateShippingCost(Product product);
    }
}
