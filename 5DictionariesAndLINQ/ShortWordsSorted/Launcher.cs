using System;
using System.Linq;

namespace ShortWordsSorted
{
    public class Launcher
    {
        public static void Main()
        {
            char[] separators = { '.', ',', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' };
            string[] input = Console.ReadLine().ToLower().Split(separators);

            string[] result = input.Distinct().Where(word => word.Length < 5).Where(word => word != string.Empty).OrderBy(word => word).ToArray();
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
