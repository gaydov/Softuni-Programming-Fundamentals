using System;
using System.Collections.Generic;

namespace AMinerTask
{
    public class Launcher
    {
        public static void Main()
        {
            Dictionary<string, int> resources = new Dictionary<string, int>();
            string product = Console.ReadLine();

            while (!product.Equals("stop"))
            {
                int quantity = int.Parse(Console.ReadLine());

                if (resources.ContainsKey(product))
                {
                    resources[product] += quantity;
                }
                else
                {
                    resources[product] = quantity;
                }

                product = Console.ReadLine();
            }

            foreach (string entry in resources.Keys)
            {
                Console.WriteLine($"{entry} -> {resources[entry]}");
            }
        }
    }
}
