using System;
using System.Text.RegularExpressions;

namespace UC_9_emailSample
{
    public  class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter your Email Address");
            while (true)
            {
                string input = Console.ReadLine();
                Regex r = new Regex("^[A-Za-z0-9.+-]{1,}[a-zA-Z0-9]@[a-z0-9]{1,}.(co|org|com|in|us|net|au|com.com|com.au)$");

                if (r.IsMatch(input))
                {
                    Console.WriteLine("Email is Valid:");
                }
                else
                {
                    Console.WriteLine("Email is not valid:");
                }
            }
        }
    }
}
