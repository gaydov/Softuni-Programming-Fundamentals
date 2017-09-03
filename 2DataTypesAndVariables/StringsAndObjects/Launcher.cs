using System;

namespace StringsAndObjects
{
    public class Launcher
    {
        public static void Main(string[] args)
        {
            string firstVar = "Hello";
            string secondVar = "World";
            object concatenated = firstVar + ' ' + secondVar;
            string thirdVar = (string)concatenated;
            Console.WriteLine(thirdVar);
        }
    }
}
