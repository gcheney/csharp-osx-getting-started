namespace DesignPatterns
{
    public class StripeProvider
    {
        private string _merchantKey;

        public StripeProvider(string merchantKey)
        {
            _merchantKey = merchantKey;
        }

        // returns false if payment is rejected
        public bool Pay(string cardNumber, string expiration, decimal amount)
        {
            return false;
        }
    }
}