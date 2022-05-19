using System;

namespace Email
{
    class Program
    {
        static void Main(string[] args)
        {
            Validate userRegistration = new Validate();
            Console.WriteLine("Enter a Email :");
            string Email = Console.ReadLine();
            userRegistration.ValidateEmail(Email);
        }
    }
}
