namespace DesignPatterns
{
    public interface IPaymentProcessorAdapterFactory
    {
        IPaymentProcessorAdapter Create(string providerName);
    }
}