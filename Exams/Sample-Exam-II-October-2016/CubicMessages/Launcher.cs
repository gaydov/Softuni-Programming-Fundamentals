using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace CubicMessages
{
    public class Launcher
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            while (!input.Equals("Over!"))
            {
                int messageLength = int.Parse(Console.ReadLine());
                Regex regex = new Regex($@"^([0-9]+)([a-zA-Z]{{{messageLength}}})([^a-zA-Z]*)$");

                Match match = regex.Match(input);

                if (match.Success)
                {
                    string message = match.Groups[2].ToString();
                    char[] digitsBefore = match.Groups[1].ToString().ToCharArray();

                    Regex regexDigitsAfter = new Regex(@"([a-zA-Z]+)(\d+)");
                    Match matchDigitsAfter = regexDigitsAfter.Match(input);
                    char[] digitsAfter = matchDigitsAfter.Groups[2].ToString().ToCharArray();

                    List<int> indexes = new List<int>();

                    GetIndexes(digitsBefore, indexes);
                    GetIndexes(digitsAfter, indexes);

                    StringBuilder verificationCode = new StringBuilder();

                    foreach (int index in indexes)
                    {
                        if (index >= 0 && index < message.Length)
                        {
                            verificationCode.Append(message[index]);
                        }
                        else
                        {
                            verificationCode.Append(" ");
                        }
                    }

                    string code = verificationCode.ToString();

                    Console.WriteLine($"{message} == {code}");
                }
                else
                {
                    input = Console.ReadLine();
                    continue;
                }

                input = Console.ReadLine();
            }
        }

        public static void GetIndexes(char[] digits, List<int> indexes)
        {
            foreach (char digit in digits)
            {
                indexes.Add(int.Parse(digit.ToString()));
            }
        }
    }
}
