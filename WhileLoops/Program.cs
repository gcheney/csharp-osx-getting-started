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

            Console.WriteLine("Guessing game time!");

            int numberToGuess = new Random().Next(1,11); // a number from 1 to 10
            int currentGuess = 0; 

            while (currentGuess != numberToGuess)
            {
                Console.WriteLine("Guess the number (1 to 10): ");
                currentGuess = int.Parse(Console.ReadLine());
                if(currentGuess < numberToGuess)
                {
                    Console.WriteLine("You guessed too low! Try again!");
                }
                if(currentGuess > numberToGuess)
                {
                    Console.WriteLine("You guessed too high! Try again!");
                }
            }
            Console.WriteLine("You got it! Good job!");
        }
    }
}
