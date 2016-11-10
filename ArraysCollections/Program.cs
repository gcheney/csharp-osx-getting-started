using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArraysCollections
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // working with arrays 
            string input = "red,blue,yellow,green";
            string[] arrColors = input.Split(','); 
            string output = String.Join(" | ", arrColors);
            Console.WriteLine(output);

            // working with lists removal and insertion
            List<string> colors = new List<string>() { "black", "white", "gray" };
            colors.Remove("black");
            colors.Insert(0, "orange"); 
            colors.RemoveAll(c => c.Contains("t")); 
            colors.RemoveAt(0); 
            int numColors = colors.Count; 
            colors.Clear(); 

            // turn list to array, loop through it, and turn it to a string
            List<string> colors2 = arrColors.ToList();
            colors2.ForEach(Console.WriteLine);
            var colorStr = String.Join(",", colors2);
            Console.WriteLine(colorStr);

            bool active = true;
            while (active) 
            {
                List<string> list = new List<string>();
                Console.WriteLine("Enter command (+ item, - item, "
                    + "or -- to clear. Type anything else to quit)):");
                var action = Console.ReadLine();

                if (action.Substring(2) == "--")
                {
                    list.Clear();
                } 
                else if (action.Substring(0, 2) == "- ")
                {
                    list.RemoveAll(str => str == action.Substring(2));
                }
                else if (action.Substring(0, 2) == "+ ")
                {
                    list.Add(action.Substring(2));
                } 
                else 
                {
                    active = false;
                }

                Console.WriteLine("Items currently in list: ");
                list.ForEach(Console.WriteLine);
            }
        }
    }
}
