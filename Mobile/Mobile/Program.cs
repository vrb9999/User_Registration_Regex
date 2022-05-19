using System;

namespace Mobile
{
    class Program
    {
        static void Main(string[] args)
        {
            Validate userRegistration = new Validate();
            Console.WriteLine("Enter Mobile number :");
            string mobile = Console.ReadLine();
            userRegistration.validmobile(mobile);
        }
    }
}
