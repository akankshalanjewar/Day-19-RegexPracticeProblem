using System;
using System.Text.RegularExpressions;

namespace UC_7_PasswardIn1Numeric
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your passward with 1 Numeric: ");
            while (true)
            {
                string input = Console.ReadLine();
                Regex r = new Regex("^[A-Z][0-9][a-z]{6}$");

                if (r.IsMatch(input))
                {
                    Console.WriteLine("Password is " + true);
                }
                else
                {
                    Console.WriteLine("Passward is " + false);
                }
            }
        }
    }
}
