using System.Collections.Generic;

namespace Encapsulation
{
    public class Customer
    {
        public string Name { get; set; }
        public List<Order> Orders { get; set;} = new List<Order>();
    }
}