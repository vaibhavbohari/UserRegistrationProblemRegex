using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter last name");
            string inStr = Console.ReadLine();

            // Create pattren for Lastname
            string lastName = @"^[A-Z]{1}[a-zA-Z]{2,9}$";

            Regex regex = new Regex(lastName);
            Console.WriteLine(regex.IsMatch(inStr));
        }
    }
}