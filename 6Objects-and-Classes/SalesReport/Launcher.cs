using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesReport
{
    public class Launcher
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            SortedDictionary<string, decimal> salesByTown = new SortedDictionary<string, decimal>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                Sale currentSale = ReadSale(input);

                if (!salesByTown.ContainsKey(currentSale.Town))
                {
                    salesByTown.Add(currentSale.Town, currentSale.Price * currentSale.Quantity);
                }
                else
                {
                    salesByTown[currentSale.Town] += currentSale.Price * currentSale.Quantity;
                }
            }

            foreach (KeyValuePair<string, decimal> entry in salesByTown)
            {
                Console.WriteLine("{0} -> {1:F2}", entry.Key, entry.Value);
            }
        }

        public static Sale ReadSale(string[] inputData)
        {
            Sale sale = new Sale
            {
                Town = inputData[0],
                Product = inputData[1],
                Price = decimal.Parse(inputData[2]),
                Quantity = decimal.Parse(inputData[3])
            };

            return sale;
        }
    }

    public class Sale
    {
        public string Town { get; set; }

        public string Product { get; set; }

        public decimal Price { get; set; }

        public decimal Quantity { get; set; }
    }
}
