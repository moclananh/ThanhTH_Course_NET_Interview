using DP4.Strategy;

class Program
{
    static void Main(string[] args)
    {
        // Tạo một giỏ hàng
        var cart = new ShoppingCart();

        // Sử dụng chiến lược thanh toán bằng thẻ tín dụng
        cart.SetPaymentStrategy(new CreditCardPaymentStrategy("1234 5678 9012 3456", "123", "12/24"));
        cart.Pay(100);

        // Sử dụng chiến lược thanh toán bằng Paypal
        cart.SetPaymentStrategy(new PaypalPaymentStrategy("example@example.com", "password"));
        cart.Pay(200);
    }
}
