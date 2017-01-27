using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppendLists
{
    public class AppendLists
    {
        public static void Main()
        {
            List<string> inputList = Console.ReadLine().Split('|').ToList();
            inputList.Reverse();
            List<string> result = new List<string>();

            foreach (string input in inputList)
            {
                List<string> nums = input.Split().ToList();

                foreach (string num in nums)
                {
                    if (num != "")
                    {
                        result.Add(num);
                    }
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
