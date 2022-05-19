using System;

namespace LastName
{
    class Program
    {
        static void Main(string[] args)
        {
            Validate userRegistration = new Validate();
            Console.WriteLine("Enter a Last Name");
            string LastName = Console.ReadLine();
            userRegistration.validlastname(LastName);
        }
    }
}
