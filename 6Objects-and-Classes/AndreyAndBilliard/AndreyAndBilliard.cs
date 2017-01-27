using System;
using System.Collections.Generic;
using System.Linq;

namespace AndreyAndBilliard
{
    public class AndreyAndBilliard
    {
        public static void Main()
        {
            int productsCount = int.Parse(Console.ReadLine());

            Dictionary<string, decimal> inventory = new Dictionary<string, decimal>();
            for (int i = 0; i < productsCount; i++)
            {
                string[] input = Console.ReadLine().Split('-');
                string productName = input[0];
                decimal productPrice = decimal.Parse(input[1]);
                inventory[productName] = productPrice;
            }

            string[] purchase = Console.ReadLine().Split(new char[] { '-', ',' }, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, Customer> results = new Dictionary<string, Customer>();

            while (!(purchase[0].Equals("end of clients")))
            {
                string customerName = purchase[0];
                string orderedProduct = purchase[1];
                int quantity = int.Parse(purchase[2]);
                Customer currentCustomer = new Customer();
                currentCustomer.Name = customerName;

                // If there is no such item in the inventory we skip that line:
                if (!inventory.ContainsKey(orderedProduct))
                {
                    purchase = Console.ReadLine().Split(new char[] { '-', ',' }, StringSplitOptions.RemoveEmptyEntries);
                    continue;
                }

                if (!results.ContainsKey(customerName))
                {
                    results[customerName] = new Customer();
                    results[customerName].ShopList = new Dictionary<string, int>();
                    results[customerName].ShopList.Add(orderedProduct, quantity);
                }
                else
                {
                    if (!results[customerName].ShopList.ContainsKey(orderedProduct))
                    {
                        results[customerName].ShopList.Add(orderedProduct, quantity);
                    }
                    else
                    {
                        results[customerName].ShopList[orderedProduct] += quantity;
                    }
                }

                results[customerName].Bill += quantity * inventory[orderedProduct];
                purchase = Console.ReadLine().Split(new char[] { '-', ',' }, StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (KeyValuePair<string, Customer> customer in results.OrderBy(c => c.Key))
            {
                Console.WriteLine($"{customer.Key}");

                foreach (KeyValuePair<string, int> order in customer.Value.ShopList)
                {
                    Console.WriteLine($"-- {order.Key} - {order.Value}");
                }
                Console.WriteLine($"Bill: {customer.Value.Bill:F2}");
            }

            decimal totalBill = results.Values.Sum(c => c.Bill);
            Console.WriteLine($"Total bill: {totalBill:F2}");
        }
        public class Customer
        {
            public string Name { get; set; }
            public Dictionary<string, int> ShopList { get; set; }
            public decimal Bill { get; set; }
        }
    }
}
