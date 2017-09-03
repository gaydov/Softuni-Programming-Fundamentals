using System;

namespace VariableinHexFormat
{
    public class Launcher
    {
        public static void Main(string[] args)
        {
            string inputNum = Console.ReadLine();
            int num = Convert.ToInt32(inputNum, 16);
            Console.WriteLine(num);
        }
    }
}
