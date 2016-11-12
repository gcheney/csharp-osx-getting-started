using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LINQ
{
    public class Program
    {
         public static void Main()
        {
            var people = GenerateListOfPeople();

            //Where - There will be two Persons in this variable: the "Steve" Person and the "Jane" Person
            var peopleOverTheAgeOf30 = people.Where(x => x.Age > 30);

            //Skip - Will ignore Eric and Steve in the list of people
            IEnumerable<Person> afterTwo = people.Skip(2);

            //Take - Will only return Eric and Steve from the list of people
            IEnumerable<Person> takeTwo = people.Take(2); 

            // Select - only get first names
            IEnumerable<string> allFirstNames = people.Select(x => x.FirstName);

            var firstThirtyYearOld1 = people.FirstOrDefault(x => x.Age == 30);
            var firstThirtyYearOld2 = people.Where(x => x.Age == 30).FirstOrDefault();
            Console.WriteLine(firstThirtyYearOld1.FirstName); //Will output "Brendan"
            Console.WriteLine(firstThirtyYearOld2.FirstName); //Will also output "Brendan"

            // include Func without Where
            Person isNull = people.FirstOrDefault(x => x.FirstName == "John");  //No John - default of null used

            Person lastThirtyYearOld = people.LastOrDefault(x => x.Age == 30);
            Console.WriteLine(lastThirtyYearOld.FirstName); //Will output "Brendan"

            // can only be one instance in collection
            Person single = people.SingleOrDefault(x => x.FirstName == "Eric"); //Will return the Eric Person obejct

            // Count
            int peopleOverTwentyFive = people.Count(x => x.Age > 25); //Will return 3

            // Any
            bool thereArePeople = people.Any(); //This will return true

            if (people.Count() > 0) //This works
            {
                //perform some action(s)
            }
            if (people.Any()) //This is better
            {
                //perform some action(s)
            }

            bool allDevs = people.All(x => x.Occupation == "Dev"); //Will return false

            bool everyoneAtLeastTwentyFour = people.All(x => x.Age >= 24); //Will return true

            //This will return a List<Person>
            List<Person> listOfDevs = people.Where(x => x.Occupation == "Dev").ToList(); 

            //This will return a Person[] array
            Person[] arrayOfDevs = people.Where(x => x.Occupation == "Dev").ToArray(); 
        }

        public static List<Person> GenerateListOfPeople()
        {
            var people = new List<Person>();

            people.Add(new Person { FirstName = "Eric", LastName = "Fleming", Occupation = "Dev", Age = 24 });
            people.Add(new Person { FirstName = "Steve", LastName = "Smith", Occupation = "Manager", Age = 40 });
            people.Add(new Person { FirstName = "Brendan", LastName = "Enrick", Occupation = "Dev", Age = 30 });
            people.Add(new Person { FirstName = "Jane", LastName = "Doe", Occupation = "Dev", Age = 35 });
            people.Add(new Person { FirstName = "Samantha", LastName = "Jones", Occupation = "Dev", Age = 24 });

            return people;
        }
    }
}
