namespace ClassesAndObjects
{
    public class Company : IShippable
    {
        public string Name { get; set; }
        public Address ShippingAddress { get; set; }
    }
}
