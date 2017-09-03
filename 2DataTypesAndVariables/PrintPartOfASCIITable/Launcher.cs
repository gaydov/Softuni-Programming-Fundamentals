using System;

namespace PrintPartOfASCIITable
{
    public class Launcher
    {
        public static void Main()
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());

            for (int decNum = startNum; decNum <= endNum; decNum++)
            {
                Console.Write("{0} ", Convert.ToChar(decNum));
            }

            Console.WriteLine();
        }
    }
}
