using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace HornetComm
{
    public class Launcher
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            string onlyDigitsPattern = @"^[\d]+$";
            string digitsAndOrLettersPattern = @"^[\d|a-zA-Z]+$";
            string anythingButDigits = @"^\D+$";

            Dictionary<string, List<string>> messages = new Dictionary<string, List<string>>();
            Dictionary<string, string> broadcasts = new Dictionary<string, string>();

            while (!input.Equals("Hornet is Green"))
            {
                string[] queries = new string[2];
                string firstQuery;
                string secondQuery;

                // Checking if the input is in the correct format and ignoring the line if it is not:
                try
                {
                    queries = input.Split(new string[] { " <-> " }, StringSplitOptions.None);
                    firstQuery = queries[0];
                    secondQuery = queries[1];
                }
                catch
                {
                    input = Console.ReadLine();
                    continue;
                }

                if (Regex.IsMatch(firstQuery, onlyDigitsPattern) && Regex.IsMatch(secondQuery, digitsAndOrLettersPattern))
                {
                    char[] codeCharArr = firstQuery.Reverse().ToArray();
                    string code = new string(codeCharArr);
                    string message = secondQuery;

                    if (!messages.ContainsKey(code))
                    {
                        messages.Add(code, new List<string>());
                        messages[code].Add(message);
                    }
                    else
                    {
                        messages[code].Add(message);
                    }
                }
                else if (Regex.IsMatch(firstQuery, anythingButDigits) && Regex.IsMatch(secondQuery, digitsAndOrLettersPattern))
                {
                    string broadcastMessage = firstQuery;
                    char[] freqCharArr = secondQuery.ToCharArray();

                    StringBuilder frequencyStrBld = new StringBuilder();

                    for (int i = 0; i < freqCharArr.Length; i++)
                    {
                        if (char.IsLower(freqCharArr[i]))
                        {
                            freqCharArr[i] = char.ToUpper(freqCharArr[i]);
                        }
                        else if (char.IsUpper(freqCharArr[i]))
                        {
                            freqCharArr[i] = char.ToLower(freqCharArr[i]);
                        }

                        frequencyStrBld.Append(freqCharArr[i]);
                    }

                    string frequency = frequencyStrBld.ToString();
                    broadcasts.Add(frequency, broadcastMessage);
                }
                else 
                {
                    // If the message is not in the correct format for decryption
                    input = Console.ReadLine();
                    continue;
                }

                input = Console.ReadLine();
            }

            if (broadcasts.Count == 0)
            {
                Console.WriteLine("Broadcasts:");
                Console.WriteLine("None");
            }
            else
            {
                Console.WriteLine("Broadcasts:");

                foreach (KeyValuePair<string, string> broadcast in broadcasts)
                {
                    Console.WriteLine($"{broadcast.Key} -> {broadcast.Value}");
                }
            }

            if (messages.Count == 0)
            {
                Console.WriteLine("Messages:");
                Console.WriteLine("None");
            }
            else
            {
                Console.WriteLine("Messages:");

                foreach (KeyValuePair<string, List<string>> codeWithMessage in messages)
                {
                    foreach (string message in codeWithMessage.Value)
                    {
                        Console.WriteLine($"{codeWithMessage.Key} -> {message}");
                    }
                }
            }
        }
    }
}
