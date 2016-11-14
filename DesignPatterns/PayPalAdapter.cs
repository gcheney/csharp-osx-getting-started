namespace DesignPatterns
{
    public class PayPalAdapter : IPaymentProcessorAdapter
    {
        public bool ProcessPayment(string merchantId, 
            string cardNumber, string expiration, 
            decimal amount)
        {
            var provider = new PayPalProvider();
            try
            {
                var cardInfo = new CreditCardDetails(cardNumber, expiration);
                provider.ProcessPayment(merchantId, cardInfo, amount);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}