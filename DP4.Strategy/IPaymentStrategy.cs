﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP4.Strategy
{
    public interface IPaymentStrategy
    {
        void Pay(int amount);
    }
}
