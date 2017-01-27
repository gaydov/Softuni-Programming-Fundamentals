using System;
using System.Text.RegularExpressions;

namespace ReplaceATag
{
    public class ReplaceATag
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            while(!text.Equals("end"))
            {
                string pattern = @"<a.*?href.*?=(.*?)>(.*?)<\/a>";
                string replacement = @"[URL href=$1]$2[/URL]";
                string replaced = Regex.Replace(text, pattern, replacement);

                Console.WriteLine(replaced);

                text = Console.ReadLine();
            }
        }
    }
}
