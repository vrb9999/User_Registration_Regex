using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace PR1_Min8Char
{
    class Validate
    {
        public static string RegexRules = "[a-zA-Z0-9]{8,}$";
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
