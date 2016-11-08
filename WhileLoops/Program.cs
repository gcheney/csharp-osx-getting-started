using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WhileLoops
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Factors: ");

            while (number > 1) 
            {
                int candidateFactor = 2;
                while (candidateFactor <= number) // convert this to while
                {
                    if (number % candidateFactor == 0) // found a factor
                    {
                        Console.Write($"{candidateFactor} ");
                        number = number/candidateFactor;
                    }
                    candidateFactor++;
                }
            }
            Console.WriteLine();
        }
    }
}
