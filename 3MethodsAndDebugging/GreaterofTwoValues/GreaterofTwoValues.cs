using System;

namespace GreaterofTwoValues
{
    public class GreaterofTwoValues
    {
        public static void Main()
        {
            string type = Console.ReadLine();

            if (type == "int")
            {
                int firstValue = int.Parse(Console.ReadLine());
                int secondValue = int.Parse(Console.ReadLine());
                int greaterInt = GetGreaterInt(firstValue, secondValue);
                Console.WriteLine(greaterInt);
            }
            else if (type == "char")
            {
                char firstValue = char.Parse(Console.ReadLine());
                char secondValue = char.Parse(Console.ReadLine());
                char greaterChar = GetGreaterChar(firstValue, secondValue);
                Console.WriteLine(greaterChar);
            }
            else if (type == "string")
            {
                string firstValue = Console.ReadLine();
                string secondValue = Console.ReadLine();
                string greaterString = GetGreaterString(firstValue, secondValue);
                Console.WriteLine(greaterString);
            }
        }
        public static string GetGreaterString(string firstValue, string secondValue)
        {
            if (firstValue.CompareTo(secondValue) >= 0)
            {
                return firstValue;
            }
            else
            {
                return secondValue;
            }
        }
        public static char GetGreaterChar(char firstValue, char secondValue)
        {
            if (firstValue >= secondValue)
            {
                return firstValue;
            }
            else
            {
                return secondValue;
            }
        }
        public static int GetGreaterInt(int firstValue, int secondValue)
        {
            if (firstValue >= secondValue)
            {
                return firstValue;
            }
            else
            {
                return secondValue;
            }
        }
    }
}
