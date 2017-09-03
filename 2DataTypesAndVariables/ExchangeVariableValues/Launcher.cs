using System;

namespace ExchangeVariableValues
{
    public class Launcher
    {
        public static void Main(string[] args)
        {
            int aBefore = 5;
            int bBefore = 10;
            int temp = aBefore;
            int aAfter = bBefore;
            int bAfter = temp;

            Console.WriteLine("Before:\na = {0}\nb = {1}\nAfter:\na = {2}\nb = {3}", aBefore, bBefore, aAfter, bAfter);
        }
    }
}
