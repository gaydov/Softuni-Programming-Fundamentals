using System;

namespace HelloName
{
    public class HelloName
    {
        public static void Main()
        {
            string inputName = Console.ReadLine();
            HelloGreeting(inputName);
        }

        public static void HelloGreeting(string name)
        {
            Console.WriteLine("Hello, {0}!", name);
        }
    }
}
