using System;

namespace BlankReceipt
{
    public class Launcher
    {
        public static void Main()
        {
            PrintHeader();
            PrintBody();
            PrintFooter();
        }

        public static void PrintHeader()
        {
            Console.WriteLine("CASH RECEIPT\n------------------------------");
        }

        public static void PrintBody()
        {
            Console.WriteLine("Charged to____________________\nReceived by___________________");
        }

        public static void PrintFooter()
        {
            Console.WriteLine("------------------------------\n\u00A9 SoftUni");
        }
    }
}
