using System;

namespace Dates
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DateTime birthday = new DateTime(1989, 1, 10); 
            DateTime currentTime = DateTime.Now;

            TimeSpan daysSinceBirth = currentTime - birthday;
            double ageInDays = Math.Floor(daysSinceBirth.TotalDays);
            Console.WriteLine($"You are { ageInDays } days old!");

            double daysToNextAnniversary = 10000 - (ageInDays % 10000);
            Console.WriteLine($"Your next 10,000 day anniversary will be in { daysToNextAnniversary } days");
        }
    }
}
