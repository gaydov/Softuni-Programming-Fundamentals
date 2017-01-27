using System;

namespace DayofWeek
{
    public class DayofWeek
    {
        public static void Main()
        {
            int dayNumber = int.Parse(Console.ReadLine());
            string[] weekDays = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            if (dayNumber >= 1 && dayNumber <= 7)
            {
                Console.WriteLine(weekDays[dayNumber - 1]);
            }
            else
            {
                Console.WriteLine("Invalid Day!");
            }
        }
    }
}
