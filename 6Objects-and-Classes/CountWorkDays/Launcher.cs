using System;
using System.Linq;

namespace CountWorkDays
{
    public class Launcher
    {
        public static void Main()
        {
            string start = Console.ReadLine();
            string end = Console.ReadLine();
            DateTime startDate = DateTime.ParseExact(start, "dd-MM-yyyy", null);
            DateTime endDate = DateTime.ParseExact(end, "dd-MM-yyyy", null);

            // We choose a leap year:
            DateTime[] holidays = new DateTime[]
            {
                new DateTime(2016, 01, 01),
                new DateTime(2016, 03, 03),
                new DateTime(2016, 05, 01),
                new DateTime(2016, 05, 06),
                new DateTime(2016, 05, 24),
                new DateTime(2016, 09, 06),
                new DateTime(2016, 09, 22),
                new DateTime(2016, 11, 01),
                new DateTime(2016, 12, 24),
                new DateTime(2016, 12, 25),
                new DateTime(2016, 12, 26),
            };

            int counter = 0;

            for (DateTime currentDate = startDate; currentDate <= endDate; currentDate = currentDate.AddDays(1))
            {
                // Creating temporary variable in order to check if the current date is from the holidays already defined above:
                DateTime possibleHoliday = new DateTime(2016, currentDate.Month, currentDate.Day);

                if (!holidays.Contains(possibleHoliday) && currentDate.DayOfWeek != DayOfWeek.Saturday && currentDate.DayOfWeek != DayOfWeek.Sunday)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
