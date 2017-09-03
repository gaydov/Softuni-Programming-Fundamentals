using System;

namespace CubeProperties
{
    public class Launcher
    {
        public static void Main()
        {
            double side = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();
            PrintCubeProperty(side, parameter);        
        }

        public static void PrintCubeProperty(double cubeSide, string property)
        {
            double result = 0;

            switch (property)
            {
                case "face":
                    result = Math.Sqrt(2 * Math.Pow(cubeSide, 2));
                    break;
                case "space":
                    result = Math.Sqrt(3 * Math.Pow(cubeSide, 2));
                    break;
                case "volume":
                    result = Math.Pow(cubeSide, 3);
                    break;
                case "area":
                    result = 6 * Math.Pow(cubeSide, 2);
                    break;
                default:
                    break;
            }

            Console.WriteLine("{0:F2}", result);
        }
    }
}
