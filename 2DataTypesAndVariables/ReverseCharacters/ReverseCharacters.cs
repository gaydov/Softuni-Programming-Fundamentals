using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseCharacters
{
    class ReverseCharacters
    {
        static void Main(string[] args)
        {
            char letter1 = char.Parse(Console.ReadLine());
            char letter2 = char.Parse(Console.ReadLine());
            char letter3 = char.Parse(Console.ReadLine());

            char temp = letter3;
            letter3 = letter1;
            letter1 = temp;

            Console.WriteLine("{0}{1}{2}", letter1, letter2, letter3);
        }
    }
}
