using System;
using System.Text.RegularExpressions;

namespace UC_4_userMobileNo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Mobile No:");
            while (true)
            {
                string input = Console.ReadLine();
                Regex r = new Regex("^91 [1-9][0-9]{9}$");

                if (r.IsMatch(input))
                {
                    Console.WriteLine(true);
                }
                else
                {
                    Console.WriteLine(false);
                }
            }
        }
    }
}
