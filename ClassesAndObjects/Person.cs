namespace ClassesAndObjects
{
    public class Person : IShippable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address ShippingAddress { get; set; }
    }
}
