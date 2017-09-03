using System;
using System.Text;

namespace UnicodeCharacters
{
    public class Launcher
    {
        public static void Main()
        {
            char[] input = Console.ReadLine().ToCharArray();
            StringBuilder result = new StringBuilder();

            foreach (char character in input)
            {
                string unicode = "\\u" + ((int)character).ToString("x4");
                result.Append(unicode);
            }
 
            Console.WriteLine(result);
        }
    }
}
