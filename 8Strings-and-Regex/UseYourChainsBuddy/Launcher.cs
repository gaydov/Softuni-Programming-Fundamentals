using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace UseYourChainsBuddy
{
    public class Launcher
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string removeTagsPattern = @"<p>(.+?)<\/p>";
            string notSmallLettersAndNums = @"[^a-z0-9]";
            MatchCollection matches = Regex.Matches(input, removeTagsPattern);
            string withoutTags = string.Empty;

            foreach (Match match in matches)
            {
                withoutTags += match.Groups[1];
            }

            string onlySmallLettersAndNums = Regex.Replace(withoutTags, notSmallLettersAndNums, " ");

            Dictionary<char, char> lettersAtoM = new Dictionary<char, char>();
            for (char i = 'a'; i <= 'm'; i++)
            {
                lettersAtoM[i] = (char)(i + 13);
            }

            Dictionary<char, char> lettersNtoZ = new Dictionary<char, char>();
            int incrementer = 0;
            for (char i = 'n'; i <= 'z'; i++)
            {
                lettersNtoZ[i] = (char)('a' + incrementer);
                incrementer++;
            }

            string result = string.Empty;

            foreach (char item in onlySmallLettersAndNums)
            {
                char letter = ' ';

                if (lettersAtoM.ContainsKey(item))
                {
                    letter = lettersAtoM[item];
                    result += letter;
                }
                else if (lettersNtoZ.ContainsKey(item))
                {
                    letter = lettersNtoZ[item];
                    result += letter;
                }
                else
                {
                    result += item;
                }
            }

            result = Regex.Replace(result, @"\s+", " ");
            Console.WriteLine(result);
        }
    }
}
