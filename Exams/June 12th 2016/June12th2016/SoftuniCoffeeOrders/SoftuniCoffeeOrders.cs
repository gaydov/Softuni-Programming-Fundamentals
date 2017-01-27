using System;

namespace SoftuniCoffeeOrders
{
    public class SoftuniCoffeeOrders
    {
        public static void Main()
        {
            int ordersCount = int.Parse(Console.ReadLine());
            decimal total = 0;

            for (int i = 0; i < ordersCount; i++)
            {
                decimal capsulePrice = decimal.Parse(Console.ReadLine());
                DateTime date = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", null);
                uint capsulesCount = uint.Parse(Console.ReadLine());

                int daysInMonth = DateTime.DaysInMonth(date.Year, date.Month);
                decimal coffeePrice = daysInMonth * capsulesCount * capsulePrice;
                
                Console.WriteLine($"The price for the coffee is: ${coffeePrice:F2}");
                total += coffeePrice;
            }

            Console.WriteLine($"Total: ${total:F2}");
        }
    }
}
