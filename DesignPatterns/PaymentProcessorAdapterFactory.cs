namespace DesignPatterns
{
    public class PaymentProcessorAdapterFactory : IPaymentProcessorAdapterFactory
    {
        public IPaymentProcessorAdapter Create(string providerName)
        {
            IPaymentProcessorAdapter adapter;

            if (providerName == "Stwipe")
            {
                adapter = new StripeAdapter();
            }
            else if (providerName == "PaySal")
            {
                adapter = new PayPalAdapter();
            } 
            else
            {
                throw new InvalidPaymentProviderException(providerName);
            }

            return adapter;
        }
    }
}