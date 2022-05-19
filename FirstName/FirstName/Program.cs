using System;

namespace FirstName
{
    class Program
    {
        static void Main(string[] args)
        {
            Validate userRegistration = new Validate();
            Console.WriteLine("Enter a First Name");
            string FirstName = Console.ReadLine();
            userRegistration.validfirstname(FirstName);
        }
    }
}
