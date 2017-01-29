using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace RageQuit
{
    public class RageQuit
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string delimitingPattern = @"[\D]+[0-9]+";
            string numPattern = @"[\d]+";
            string messagePattern = @"[\D]+";

            MatchCollection messageWithRepCount = Regex.Matches(input, delimitingPattern);
            StringBuilder outputMessage = new StringBuilder();

            foreach (Match message in messageWithRepCount)
            {
                Match repetition = Regex.Match(message.ToString(), numPattern);
                int repetitions = int.Parse(repetition.ToString());

                Match messageText = Regex.Match(message.ToString(), messagePattern);
                string dummyMessage = messageText.ToString();

                for (int i = 0; i < repetitions; i++)
                {
                    outputMessage.Append(dummyMessage);
                }
            }

            string output = outputMessage.ToString().ToUpper();
            int uniqueSymbolsCount = output.Distinct().Count();

            Console.WriteLine($"Unique symbols used: {uniqueSymbolsCount}");
            Console.WriteLine(output);
        }
    }
}
