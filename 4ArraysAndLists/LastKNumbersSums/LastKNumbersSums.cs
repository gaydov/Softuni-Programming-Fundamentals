using System;

namespace LastKNumbersSums
{
    public class LastKNumbersSums
    {
        public static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            long k = long.Parse(Console.ReadLine());

            long[] arrInt = new long[n];
            arrInt[0] = 1;

            for (int i = 1; i < arrInt.Length; i++)
            {
                long sum = 0;
                int currentIndex = i;
                for (int j = 1; j <= k; j++)
                {
                    if (currentIndex - k < 0)
                    {
                        currentIndex++;
                        continue;
                    }

                    sum += arrInt[currentIndex - k];
                    currentIndex++;
                }
                arrInt[i] = sum;
            }
            Console.WriteLine(string.Join(" ", arrInt));
        }
    }
}
