using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableinHexFormat
{
    class VariableinHexFormat
    {
        static void Main(string[] args)
        {
            string inputNum = Console.ReadLine();
            int num = Convert.ToInt32(inputNum, 16);
            Console.WriteLine(num);
        }
    }
}
