using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Mobile
{
    class Validate
    {
        public static string RegexRules = "^[0-9]{2}[ ]{1}[0-9]{10}$";
        public Regex MobileRegex = new Regex(RegexRules);
        public void validmobile(string Mobile)
        {
            if (Regex.IsMatch(Mobile, RegexRules))
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
