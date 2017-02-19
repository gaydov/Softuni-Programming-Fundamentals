using System;

namespace SweetDessert
{
    public class SweetDessert
    {
        public static void Main()
        {
            decimal cash = decimal.Parse(Console.ReadLine());
            int guests = int.Parse(Console.ReadLine());
            decimal bananaPrice = decimal.Parse(Console.ReadLine());
            decimal eggPrice = decimal.Parse(Console.ReadLine());
            decimal berriesKiloPrice = decimal.Parse(Console.ReadLine());

            double sets = Math.Ceiling(guests / 6.0);

            decimal productsCost = ((decimal)sets * 2 * bananaPrice) + ((decimal)sets * 4 * eggPrice) + ((decimal)(sets * 0.2) * berriesKiloPrice);

            if(cash >= productsCost)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {productsCost:F2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {productsCost - cash:F2}lv more.");
            }
        }
    }
}
