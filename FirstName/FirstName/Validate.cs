using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace FirstName
{
    class Validate
    {
        public static string RegexRules = "^[A-Z][a-z]{2,}$";
        public Regex FirstNameRegex = new Regex(RegexRules);
        public void validfirstname(string FirstName)
        {
            if (Regex.IsMatch(FirstName, RegexRules))
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
