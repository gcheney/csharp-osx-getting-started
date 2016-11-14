namespace DesignPatterns
{
    public class StripeAdapter : IPaymentProcessorAdapter
    {
        public bool ProcessPayment(string merchantId, string cardNumber, string expiration, 
                            decimal amount)
        {
            var provider = new StripeProvider(merchantId);
            return provider.Pay(cardNumber, expiration, amount);
        }
    }
}