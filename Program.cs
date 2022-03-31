using System;
using System.Text.RegularExpressions;

namespace UC_3_emailAddresss
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter your Email Address: ");

            while (true)
            {
                string input = Console.ReadLine();
                Regex r = new Regex(@"^[a-z]{3}(\.[a-z]{3})[@]bl.(|co|in)$");
                if (r.IsMatch(input))
                {
                    Console.WriteLine("Your Email ID is " + true);
                }
                else
                {
                    Console.WriteLine("Your Email Id is " + false);
                }

            }
        }
    }
}
