using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP4.Strategy
{
    // Lớp sử dụng chiến lược
    public class ShoppingCart
    {
        private IPaymentStrategy paymentStrategy;

        public void SetPaymentStrategy(IPaymentStrategy paymentStrategy)
        {
            this.paymentStrategy = paymentStrategy;
        }

        public void Pay(int amount)
        {
            paymentStrategy.Pay(amount);
        }
    }

}
