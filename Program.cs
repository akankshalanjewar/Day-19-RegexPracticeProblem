using System;
using System.Text.RegularExpressions;

namespace UC_1_UserFirstName
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter your First Name ");

            while (true)
            {
                string input = Console.ReadLine();
                Regex r = new Regex("^[A-Z][a-z]{2,}$");
                if (r.IsMatch(input))
                {
                    Console.WriteLine("your First name is " + true);
                }
                else
                {
                    Console.WriteLine("Your First Name is " + false);
                    Console.WriteLine("First Name Should Contain Only Four Character");
                }
            }
        }
    }
}
