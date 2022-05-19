using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace PR4_SpecialCharacter
{
    class Validate
    {
        public static string RegexRules = "^(?=.{8,})(?=.*[0-9])(?=.*[A-Z])[a-zA-Z0-9]*[#!@$^&-][a-zA-Z0-9]*$";
        public Regex PasswordRegex = new Regex(RegexRules);
        public void validpassword(string Password)
        {
            if (Regex.IsMatch(Password, RegexRules))
            {
                Console.WriteLine("Valid");

            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
