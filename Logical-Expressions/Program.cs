using System;

namespace Logical_Expressions
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var currentTime = DateTime.Now;
            var greeting = "";

            if (currentTime.Hour >= 5 && currentTime.Hour < 12) {
                greeting = "Good Morning";
            }

            if (currentTime.Hour >= 12 && currentTime.Hour < 18) {
                greeting = "Good Afternoon";
            }

            if (currentTime.Hour >= 18 && currentTime.Hour < 22) {
                greeting = "Good Evening";
            }

            if (currentTime.Hour >=  22 || currentTime.Hour < 5) {
                greeting = "Good Night";
            }

            Console.WriteLine(greeting);
        }
    }
}
