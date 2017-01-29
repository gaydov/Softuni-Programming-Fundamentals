using System;
using System.Collections.Generic;
using System.Linq;

namespace CommandInterpreter
{
    public class CommandInterpreter
    {
        public static void Main()
        {
            List<string> input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            string[] cmd = Console.ReadLine().Split();

            while (!cmd[0].Equals("end"))
            {
                int start = 0;
                int count = 0;

                switch (cmd[0])
                {
                    case "reverse":

                        start = int.Parse(cmd[2]);
                        count = int.Parse(cmd[4]);

                        if (start < 0 || start >= input.Count || (start + count) > input.Count || count < 0)
                        {
                            Console.WriteLine("Invalid input parameters.");
                            break;
                        }

                        List<string> reversed = input.Skip(start).Take(count).Reverse().ToList();
                        input.RemoveRange(start, count);
                        input.InsertRange(start, reversed);
                        break;

                    case "sort":

                        start = int.Parse(cmd[2]);
                        count = int.Parse(cmd[4]);

                        if (start < 0 || start >= input.Count || (start + count) > input.Count || count < 0)
                        {
                            Console.WriteLine("Invalid input parameters.");
                            break;
                        }

                        List<string> sorted = input.Skip(start).Take(count).OrderBy(e => e).ToList();
                        input.RemoveRange(start, count);
                        input.InsertRange(start, sorted);
                        break;

                    case "rollLeft":

                        count = int.Parse(cmd[1]);

                        if (count < 0)
                        {
                            Console.WriteLine("Invalid input parameters.");
                            break;
                        }

                        for (int i = 0; i < (count % input.Count); i++)
                        {
                            string temp = input[0];

                            for (int j = 0; j < input.Count - 1; j++)
                            {
                                input[j] = input[j + 1];
                            }

                            input[input.Count - 1] = temp;
                        }

                        break;

                    case "rollRight":

                        count = int.Parse(cmd[1]);

                        if (count < 0)
                        {
                            Console.WriteLine("Invalid input parameters.");
                            break;
                        }

                        for (int i = 0; i < (count % input.Count); i++)
                        {
                            string temp = input[input.Count - 1];

                            for (int j = 0; j < input.Count - 1; j++)
                            {
                                input[input.Count - 1 - j] = input[input.Count - 2 - j];
                            }

                            input[0] = temp;
                        }

                        break;
                }

                cmd = Console.ReadLine().Split();
            }

            Console.WriteLine($"[{string.Join(", ", input)}]");
        }
    }
}
