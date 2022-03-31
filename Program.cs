using System;
using System.Text.RegularExpressions;

namespace UC_5_UserPassward
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter your Password : ");

            while (true)
            {
                string input = Console.ReadLine();
                Regex r = new Regex("^[A-Za-z0-9]{8}$");
                if (r.IsMatch(input))
                {
                    Console.WriteLine("Your Password Is :" + true);
                }
                else
                {
                    Console.WriteLine("Your Password is " + false);
                }
            }
        }
    }
}

        
    

