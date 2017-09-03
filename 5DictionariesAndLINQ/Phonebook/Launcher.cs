using System;
using System.Collections.Generic;

namespace Phonebook
{
    public class Launcher
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split();
            Dictionary<string, string> phonebook = new Dictionary<string, string>();
            string command = input[0];

            while (!command.Equals("END"))
            {
                switch (command)
                {
                    case "A":
                        string name = input[1];
                        string phone = input[2];

                        phonebook[name] = phone;
                        break;

                    case "S":

                        name = input[1];

                        if (phonebook.ContainsKey(name))
                        {
                            Console.WriteLine("{0} -> {1}", name, phonebook[name]);
                        }
                        else
                        {
                            Console.WriteLine($"Contact {name} does not exist.");
                        }

                        break;
                }

                input = Console.ReadLine().Split();
                command = input[0];
            }
        }
    }
}
