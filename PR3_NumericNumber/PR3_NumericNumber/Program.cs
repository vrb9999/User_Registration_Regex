using System;

namespace PR3_NumericNumber
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
