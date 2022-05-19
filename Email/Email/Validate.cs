using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Email
{
    public class Validate
    {
        public static string Regex_Email = "^[0-9a-zA-Z]+[+.-]?[0-9a-zA-Z]+[@][a-zA-Z0-9]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}$";
        public bool ValidateEmail(string email)
        {
            if (Regex.IsMatch(email, Regex_Email))
            {
                Console.WriteLine("Valid");

            }
            else
            {
                Console.WriteLine("Invalid");
            }
            return Regex.IsMatch(email, Regex_Email);
        }
    }
}
