using System;
using System.Text.RegularExpressions;

namespace ExtractEmails
{
    public class Launcher
    {
        public static void Main()
        {
            string pattern = @"(?:^|\s)([a-zA-Z0-9][\-\._a-zA-Z0-9]*)@[a-zA-Z\-]+(\.[a-z]+)+\b";
            Regex regex = new Regex(pattern);

            string inputText = Console.ReadLine();

            MatchCollection matches = regex.Matches(inputText);

            foreach (Match match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
