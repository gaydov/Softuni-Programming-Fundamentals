using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniCoffeeSupplies
{
    public class Launcher
    {
        public static void Main()
        {
            string[] delimiters = Console.ReadLine().Split();
            Dictionary<string, string> personDesiredCoffee = new Dictionary<string, string>();
            Dictionary<string, int> coffeTypeQuantity = new Dictionary<string, int>();
            string input = Console.ReadLine();

            EnterCoffeeInformation(delimiters, personDesiredCoffee, coffeTypeQuantity, input);

            foreach (KeyValuePair<string, int> typeWithQuantity in coffeTypeQuantity.Where(p => p.Value == 0))
            {
                Console.WriteLine($"Out of {typeWithQuantity.Key}");
            }

            input = Console.ReadLine();

            EnterConsumptionInfo(personDesiredCoffee, coffeTypeQuantity, input);

            // Weekly report:
            Console.WriteLine("Coffee Left:");

            Dictionary<string, int> coffeeLeft = coffeTypeQuantity.Where(p => p.Value > 0).OrderByDescending(p => p.Value).ToDictionary(x => x.Key, y => y.Value);

            foreach (KeyValuePair<string, int> coffeType in coffeeLeft)
            {
                Console.WriteLine($"{coffeType.Key} {coffeType.Value}");
            }

            Console.WriteLine("For:");

            foreach (string coffeType in coffeeLeft.Keys.OrderBy(t => t))
            {
                foreach (KeyValuePair<string, string> person in personDesiredCoffee.OrderByDescending(p => p.Key))
                {
                    if (coffeType.Equals(person.Value))
                    {
                        Console.WriteLine($"{person.Key} {coffeType}");
                    }
                }
            }
        }

        public static void EnterConsumptionInfo(Dictionary<string, string> personCoffeeDesired, Dictionary<string, int> coffeeAndQuantity, string userInput)
        {
            while (!userInput.Equals("end of week"))
            {
                string[] args = userInput.Split();
                string personName = args[0];
                int coffeesCount = int.Parse(args[1]);

                coffeeAndQuantity[personCoffeeDesired[personName]] -= coffeesCount;
                if (coffeeAndQuantity[personCoffeeDesired[personName]] <= 0)
                {
                    Console.WriteLine($"Out of {personCoffeeDesired[personName]}");
                }

                userInput = Console.ReadLine();
            }
        }

        public static void EnterCoffeeInformation(string[] stringDelimiters, Dictionary<string, string> personCoffeeDesired, Dictionary<string, int> coffeeAndQuantity, string userInput)
        {
            while (!userInput.Equals("end of info"))
            {
                string firstDelimiter = stringDelimiters[0];
                string secondDelimiter = stringDelimiters[1];

                if (userInput.Contains(firstDelimiter))
                {
                    string[] args = userInput.Split(new string[] { firstDelimiter }, StringSplitOptions.RemoveEmptyEntries);
                    string person = args[0];
                    string desiredCoffee = args[1];
                    personCoffeeDesired[person] = desiredCoffee;

                    // If the user forgets to tell a quantity for that coffee type:
                    if (!coffeeAndQuantity.ContainsKey(desiredCoffee))
                    {
                        coffeeAndQuantity.Add(desiredCoffee, 0);
                    }
                }
                else if (userInput.Contains(secondDelimiter))
                {
                    string[] args = userInput.Split(new string[] { secondDelimiter }, StringSplitOptions.RemoveEmptyEntries);
                    string coffeeType = args[0];
                    int quantity = int.Parse(args[1]);

                    if (!coffeeAndQuantity.ContainsKey(coffeeType))
                    {
                        coffeeAndQuantity.Add(coffeeType, quantity);
                    }
                    else
                    {
                        coffeeAndQuantity[coffeeType] += quantity;
                    }
                }

                userInput = Console.ReadLine();
            }
        }
    }
}
