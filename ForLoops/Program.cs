using System;

namespace ForLoops
{
    public class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++) 
            {
                for (int j = 0; j < 25; j += i) 
                {
                    Console.Write($"{j},");
                }
                Console.WriteLine();
            }
        }
    }
}
