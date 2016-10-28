using System;

namespace Strings
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var name = "Glen";                  
            var greeting = "Hello";          
            Greeting(greeting, name, "loud");   
            Greeting(greeting, name, "quiet"); 
            string volume = String.Empty; // empty string
            Greeting(greeting, name, volume);           
            Greeting(greeting, name, "medium");       
        }

        public static void Greeting(string greeting, string name, string volume) 
        {
            if (String.IsNullOrEmpty(volume)) {
                Console.WriteLine($"{greeting} {name}!");
            } else {
                if (volume.Equals("loud")) {
                    var loud = $"{greeting} {name}!".ToUpper();
                    Console.WriteLine(loud);
                } else if (volume.Equals("quiet")) {
                    var quiet = $"{greeting} {name}!".ToLower();
                    Console.WriteLine(quiet);
                } else {
                    Console.WriteLine("Invalid input supplied for volume");
                }
            }
        }
    }
}
