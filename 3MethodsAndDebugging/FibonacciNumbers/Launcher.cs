using System;

namespace FibonacciNumbers
{
    public class Launcher
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Fib(n);
        }

        public static void Fib(int n)
        {
            if (n == 0 || n == 1)
            {
                Console.WriteLine(1);
            }
            else
            {
                int firstNum = 1;
                int secondNum = 1;
                int currentNum = 0;

                for (int i = 2; i <= n; i++)
                {
                    currentNum = firstNum + secondNum;
                    firstNum = secondNum;
                    secondNum = currentNum;
                }

                Console.WriteLine(currentNum);
            }
        }
    }
}
