using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScopeAccessibility
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var students = new List<Student>() 
            {
                new Student("John", "Doe", new DateTime(1990, 1, 18)),
                new Student("Jack", "James", new DateTime(1998, 2, 19)),
                new Student("Jill", "Avery", new DateTime(2000, 2, 19))
            };

            var course = new Course("Intersectional programming", students);
            PrintAdultStudentNames(course);
        }

        public static void PrintAdultStudentNames(Course course) 
        {
            foreach (string studentName in course.GetAdultStudentNames())
            {
                Console.WriteLine(studentName);
            }
        }
    }
}
