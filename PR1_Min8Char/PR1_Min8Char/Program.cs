using System;

namespace PR1_Min8Char
{
    class Program
    {
        static void Main(string[] args)
        {
            Validate userRegistration = new Validate();
            Console.WriteLine("Enter a Password");
            string Password = Console.ReadLine();
            userRegistration.validpassword(Password);
        }
    }
}
