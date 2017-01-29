using System;

namespace SoftuniCoffeeOrders
{
    public class SoftuniCoffeeOrders
    {
        public static void Main()
        {
            int ordersCount = int.Parse(Console.ReadLine());
            decimal totalPrice = 0;

            for (int i = 0; i < ordersCount; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                DateTime orderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", null);
                uint capsulesCount = uint.Parse(Console.ReadLine());

                int days = DateTime.DaysInMonth(orderDate.Year, orderDate.Month);
                decimal currentOrderPrice = days * capsulesCount * pricePerCapsule;

                Console.WriteLine($"The price for the coffee is: ${currentOrderPrice:F2}");
                totalPrice += currentOrderPrice;
            }

            Console.WriteLine($"Total: ${totalPrice:F2}");
        }
    }
}
