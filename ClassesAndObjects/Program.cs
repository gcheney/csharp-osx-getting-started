using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var john = new Person 
            {
                FirstName = "John",
                LastName = "Doe",
                ShippingAddress = new Address 
                {
                    StreetAddress = "123 Main Street",
                    City = "Austin",
                    State = "TX",
                    PostalCode = "78748",
                    Country = "US"
                }
            };

            var acme = new Company 
            {
                Name = "ACME, Inc.",
                ShippingAddress = new Address 
                {
                    StreetAddress = "123 Main Street",
                    City = "Austin",
                    State = "TX",
                    PostalCode = "78748",
                    Country = "US"
                }
            };

            var customers = new List<IShippable>(){ john, acme };
            PrintAddresses(customers);
        }

        public static void PrintAddresses(List<IShippable> customers) 
        {
            foreach (IShippable customer in customers) 
            {
                Console.WriteLine(customer.ShippingAddress.StreetAddress);
                Console.WriteLine($"{customer.ShippingAddress.City} {customer.ShippingAddress.State}");
                Console.WriteLine(customer.ShippingAddress.PostalCode);
                Console.WriteLine(customer.ShippingAddress.Country);
            }
        }
    }
}
