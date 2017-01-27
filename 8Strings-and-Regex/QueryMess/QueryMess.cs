using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace QueryMess
{
    public class QueryMess
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string pattern = @"[^&?=]+=[^&?=]+";
            string plusSignPattern = @"(%20|\+)+";
            Dictionary<string, List<string>> results = new Dictionary<string, List<string>>();

            while (!input.Equals("END"))
            {
                MatchCollection pairs = Regex.Matches(input, pattern);

                foreach (Match pair in pairs)
                {
                    string[] args = pair.ToString().Split('=');
                    string databaseKey = args[0];
                    databaseKey = Regex.Replace(databaseKey, plusSignPattern, " ").Trim();
                    string databaseValue = args[1];
                    databaseValue = Regex.Replace(databaseValue, plusSignPattern, " ").Trim();

                    if (!results.ContainsKey(databaseKey))
                    {
                        results.Add(databaseKey, new List<string>());
                        results[databaseKey].Add(databaseValue);
                    }
                    else
                    {
                        results[databaseKey].Add(databaseValue);
                    }
                }

                foreach (KeyValuePair<string, List<string>> entry in results)
                {
                    Console.Write($"{entry.Key}=[{string.Join(", ", entry.Value)}]");
                }

                results = new Dictionary<string, List<string>>();
                Console.WriteLine();

                input = Console.ReadLine();
            }
        }
    }
}
