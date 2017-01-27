using System;

namespace SweetDessert
{
    public class SweetDessert
    {
        public static void Main()
        {
            decimal cash = decimal.Parse(Console.ReadLine());
            int guestsCount = int.Parse(Console.ReadLine());
            decimal bananaPrice = decimal.Parse(Console.ReadLine());
            decimal eggPrice = decimal.Parse(Console.ReadLine());
            decimal berriesPriceKilo = decimal.Parse(Console.ReadLine());

            decimal setsOfPortions = Math.Ceiling((decimal)guestsCount / 6);
            decimal moneyRequired = (setsOfPortions * 2 * bananaPrice) + (setsOfPortions * 4 * eggPrice) + (setsOfPortions * (0.2M * berriesPriceKilo));

            if (cash >= moneyRequired)
            {
                Console.WriteLine("Ivancho has enough money - it would cost {0:F2}lv.", moneyRequired);
            }
            else
            {
                Console.WriteLine("Ivancho will have to withdraw money - he will need {0:F2}lv more.", moneyRequired - cash);
            }
        }
    }
}
