using System;

namespace FibonacciNumbers
{
    public class FibonacciNumbers
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Fib(n);
        }

        private static void Fib(int NthNum)
        {
            if (NthNum == 0 || NthNum == 1)
            {
                Console.WriteLine(1);
            }
            else
            {
                int previous1 = 1;
                int previous2 = 1;
                int current = 0;
                for (int i = 2; i <= NthNum; i++)
                {
                    current = previous1 + previous2;
                    previous1 = previous2;
                    previous2 = current;
                }
                Console.WriteLine(current);
            }
        }
    }
}
