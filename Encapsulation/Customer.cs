using System.Collections.Generic;

namespace Encapsulation
{
    public class Customer
    {
        public string Name { get; set; }

        // return copy of collection data
        private List<Order> _orders = new List<Order>();
        public List<Order> Orders 
        { 
            get
            {
                return new List<Order>(_orders);
            }
        }
    }
}