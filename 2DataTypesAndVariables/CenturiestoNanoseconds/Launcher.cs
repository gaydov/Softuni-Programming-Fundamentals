using System;
using System.Numerics;

namespace CenturiestoNanoseconds
{
    public class Launcher
    {
        public static void Main(string[] args)
        {
            byte centuries = byte.Parse(Console.ReadLine());
            ushort years = (ushort)(centuries * 100);
            uint days = (uint)(years * 365.242);
            uint hours = days * 24;
            ulong minutes = hours * 60;
            ulong seconds = minutes * 60;
            ulong miliseconds = seconds * 1000;
            ulong microseconds = miliseconds * 1000;
            BigInteger nanoseconds = BigInteger.Multiply(microseconds, 1000);

            Console.WriteLine("{0:f0} centuries = {1:f0} years = {2:f0} days = {3:f0} hours = {4:f0} minutes = {5:f0} seconds = {6:f0} milliseconds = {7:f0} microseconds = {8:f0} nanoseconds",
                centuries, years, days, hours, minutes, seconds, miliseconds, microseconds, nanoseconds);
        }
    }
}
