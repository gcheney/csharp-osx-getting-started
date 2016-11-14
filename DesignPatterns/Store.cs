namespace DesignPatterns
{
    public class Store
    {
        public string Name { get; set; }
        public string PaymentProvider { get; set; }
        public string MerchantId { get; set; }

        public void ProcessCard(string cardNumber, string expiration, decimal amount)
        {
            IPaymentProcessorAdapter adapter = new PaymentProcessorAdapterFactory().Create(PaymentProvider);
            adapter.ProcessPayment(MerchantId, cardNumber, expiration, amount);
        }
    }       
}