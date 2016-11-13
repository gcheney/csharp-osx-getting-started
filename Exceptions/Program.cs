using System;
using System.Collections.Generic;

namespace Exceptions
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try 
            {
                string nullStr = null;
                GetAccessPermissions(nullStr);
            }
            catch (MyMissingTokenException ex) 
            {
                Console.WriteLine(ex.Message);
            }

            try 
            {
                GetAccessPermissions("qweqwe");
            }
            catch (MyInvalidTokenException ex) 
            {
                Console.WriteLine(ex.Message);
            }

            List<string> perms = GetAccessPermissions("qwdqwdqwdqdwqwd");
            Console.WriteLine(perms);
        }

        public static List<string> GetAccessPermissions(string token)
        {
            // check token validity here and throw exceptions as needed.
            if (string.IsNullOrEmpty(token))
            {
                throw new MyMissingTokenException("The token is null or empty");
            }

            if (token.Length < 10)
            {
                throw new MyInvalidTokenException("The token length is too short");
            }

            return new List<string>{ "ReadLessons", "ReviewLessons" };
        }
    }
}
