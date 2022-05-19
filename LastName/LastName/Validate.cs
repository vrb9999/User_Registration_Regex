using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace LastName
{
    class Validate
    {
        public static string RegexRules = "^[A-Z][a-z]{2,}$";
        public Regex LastNameRegex = new Regex(RegexRules);
        public void validlastname(string LastName)
        {
            if (Regex.IsMatch(LastName, RegexRules))
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
