using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ValidUsernames
{
    public class Launcher
    {
        public static void Main()
        {
            string[] inputSplit = Console.ReadLine().Split(new char[] { ' ', '/', '\\', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
            string usernames = string.Join(" ", inputSplit);
            string pattern = @"\b[a-zA-z][a-zA-Z0-9_]{2,24}\b";
            MatchCollection validUsernames = Regex.Matches(usernames, pattern);
            List<string> results = new List<string>();

            int sum = 0;

            for (int i = 0; i < validUsernames.Count; i++)
            {
                if (i < validUsernames.Count - 1)
                {
                    string firstUsername = validUsernames[i].ToString();
                    string secondUsername = validUsernames[i + 1].ToString();

                    int currentSum = firstUsername.Length + secondUsername.Length;

                    if (currentSum > sum)
                    {
                        sum = currentSum;
                        results = new List<string> { firstUsername, secondUsername };
                    }
                }
            }

            Console.WriteLine(string.Join("\n", results));
        }
    }
}
