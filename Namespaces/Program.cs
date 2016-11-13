using Namespaces.Lesson;
using ModelNamespacePerson = Namespaces.Lesson.Models.Person;

namespace Namespaces
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var person1 = new Person();
            System.Console.WriteLine(person1.SayNamespace());  

            var person2 = new ModelNamespacePerson();
            System.Console.WriteLine(person2.SayNamespace());
        }
    }
}
