using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndObjects
{
    class StringsAndObjects
    {
        static void Main(string[] args)
        {
            string firstVar = "Hello";
            string secondVar = "World";
            object concatenated = firstVar + ' ' + secondVar;
            string thirdVar = (string) concatenated;
            Console.WriteLine(thirdVar);
        }
    }
}
