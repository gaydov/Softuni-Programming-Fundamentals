using System;

namespace SoftUniAirline
{
    public class Launcher
    {
        public static void Main()
        {
            int flightsCount = int.Parse(Console.ReadLine());
            decimal overallProfit = 0;

            for (int i = 0; i < flightsCount; i++)
            {
                int adultsCount = int.Parse(Console.ReadLine());
                decimal adultTicketPrice = decimal.Parse(Console.ReadLine());
                int youthsCount = int.Parse(Console.ReadLine());
                decimal youthTicketPrice = decimal.Parse(Console.ReadLine());
                decimal fuelPricePerHour = decimal.Parse(Console.ReadLine());
                decimal fuelConsumptionHour = decimal.Parse(Console.ReadLine());
                int flightDuration = int.Parse(Console.ReadLine());

                decimal income = (adultsCount * adultTicketPrice) + (youthsCount * youthTicketPrice);
                decimal expenses = flightDuration * fuelConsumptionHour * fuelPricePerHour;
                decimal profit = income - expenses;
                overallProfit += profit;

                if (income >= expenses)
                {
                    Console.WriteLine("You are ahead with {0:F3}$.", profit);
                }
                else
                {
                    Console.WriteLine("We've got to sell more tickets! We've lost {0:F3}$.", profit);
                }
            }

            decimal avgProfit = overallProfit / flightsCount;

            Console.WriteLine("Overall profit -> {0:F3}$.", overallProfit);
            Console.WriteLine("Average profit -> {0:F3}$.", avgProfit);
        }
    }
}
