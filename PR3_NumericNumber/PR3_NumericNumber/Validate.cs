using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace PR3_NumericNumber
{
    class Validate
    {
        public static string RegexRules = "^(?=.*[A-Z])(?=.*[0-9])[a-zA-Z0-9]{8,}$";
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
