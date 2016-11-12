using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Order 
    {
        public Order(string orderNumber)
        {
            OrderNumber = orderNumber;
        }
        public string OrderNumber {get; set;}
    }
}
