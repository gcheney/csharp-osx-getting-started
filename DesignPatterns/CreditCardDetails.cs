namespace DesignPatterns
{
    public class CreditCardDetails
    {
        public CreditCardDetails(string cardNumber, string expiration)
        {
            this.CardNumber = cardNumber;
            this.Expiration = expiration;
        }

        public string CardNumber { get; set; }
        public string Expiration {get; set; }
    }
}