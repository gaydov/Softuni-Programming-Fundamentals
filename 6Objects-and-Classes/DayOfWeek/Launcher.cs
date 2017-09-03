using System;
using System.Globalization;

namespace DayOfWeek
{
    public class Launcher
    {
        public static void Main()
        {
            string inputDate = Console.ReadLine();
            DateTime date = DateTime.ParseExact(inputDate, "d-M-yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(date.DayOfWeek);
        }
    }
}
