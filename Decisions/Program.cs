using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Decisions
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int correctNumber = new Random().Next(10) + 1;
            Console.WriteLine("Guess a number between 1 and 10");
            int guessedNumber = int.Parse(Console.ReadLine());

            if (guessedNumber == correctNumber) {
                Console.WriteLine("Good guess!");
            } else if (guessedNumber < correctNumber && guessedNumber > 0) {
                Console.WriteLine($"Too low! The correct guess was {correctNumber}");
            } else if ( guessedNumber > correctNumber && guessedNumber < 11) {
                Console.WriteLine($"Too high! The correct guess was {correctNumber}");
            } else {
                Console.WriteLine("Out of range!");
            }
        }
    }
}
