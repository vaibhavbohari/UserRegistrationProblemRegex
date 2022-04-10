using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter Mobile Number");
            string inStr = Console.ReadLine();

            
            string firstName = @"^[A-Z]{1}[a-zA-Z]{2,9}$";
            string lastName  = @"^[A-Z]{1}[a-zA-Z]{2,9}$";
            string emailId   = @"^[a-zA-Z0-9]+[._+-]{0,1}[a-zA-Z0-9]@[a-zA-Z0-9]{1,10}.[a-zA-Z]{2,10}[.][a-zA-Z]";
            string mobileNum = @"^[0-9]{2}\s+[6-9]{1}[0-9]{9}$";
            //creating pattern for emailid
            Regex regex = new Regex(mobileNum);
            Console.WriteLine(regex.IsMatch(inStr));
        }
    }
}