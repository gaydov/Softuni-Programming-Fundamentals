using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace NetherRealms
{
    // Creating class "Demon" in order to use its properties for easier data manipulation:
    public class Demon
    {
        public string Name { get; set; }

        public int Health { get; set; }

        public double Damage { get; set; }
    }

    public class Launcher
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Regex healthRegex = new Regex(@"[^\d\.\-\+\*\/]");
            Regex damageRegex = new Regex(@"[-|+]*[0.0-9]+");

            List<Demon> demonsList = new List<Demon>();

            for (int i = 0; i < input.Length; i++)
            {
                Demon currentDemon = new Demon { Name = input[i] };

                MatchCollection healthMatches = healthRegex.Matches(input[i]);

                foreach (Match symbol in healthMatches)
                {
                    char[] matchChar = symbol.ToString().ToCharArray();
                    currentDemon.Health += matchChar[0];
                }

                MatchCollection damageMatches = damageRegex.Matches(input[i]);

                foreach (Match number in damageMatches)
                {
                    currentDemon.Damage += double.Parse(number.ToString());
                }

                // Checking every char of the demon's name if it is '*' or '/':
                char[] nameAsChars = input[i].ToCharArray();

                for (int j = 0; j < nameAsChars.Length; j++)
                {
                    if (nameAsChars[j].Equals('*'))
                    {
                        currentDemon.Damage *= 2;
                    }
                    else if (nameAsChars[j].Equals('/'))
                    {
                        currentDemon.Damage /= 2;
                    }
                }

                demonsList.Add(currentDemon);
            }

            foreach (Demon demon in demonsList.OrderBy(d => d.Name))
            {
                Console.WriteLine($"{demon.Name} - {demon.Health} health, {demon.Damage:F2} damage");
            }
        }
    }
}
