using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP4.Strategy
{
    // Lớp chiến lược thanh toán bằng thẻ tín dụng
    public class CreditCardPaymentStrategy : IPaymentStrategy
    {
        private string cardNumber;
        private string cvv;
        private string dateOfExpiry;

        public CreditCardPaymentStrategy(string cardNumber, string cvv, string dateOfExpiry)
        {
            this.cardNumber = cardNumber;
            this.cvv = cvv;
            this.dateOfExpiry = dateOfExpiry;
        }

        public void Pay(int amount)
        {
            Console.WriteLine(amount + " paid with credit/debit card");
        }
    }

    // Lớp chiến lược thanh toán bằng Paypal
    public class PaypalPaymentStrategy : IPaymentStrategy
    {
        private string email;
        private string password;

        public PaypalPaymentStrategy(string email, string password)
        {
            this.email = email;
            this.password = password;
        }

        public void Pay(int amount)
        {
            Console.WriteLine(amount + " paid using Paypal");
        }
    }

}
