using System;

namespace LongerLine
{
    public class LongerLine
    {
        public static void Main()
        {
            double lineOneX1 = double.Parse(Console.ReadLine());
            double lineOneY1 = double.Parse(Console.ReadLine());
            double lineOneX2 = double.Parse(Console.ReadLine());
            double lineOneY2 = double.Parse(Console.ReadLine());
            double lineTwoX1 = double.Parse(Console.ReadLine());
            double lineTwoY1 = double.Parse(Console.ReadLine());
            double lineTwoX2 = double.Parse(Console.ReadLine());
            double lineTwoY2 = double.Parse(Console.ReadLine());

            PrintLongerLine(lineOneX1, lineOneY1, lineOneX2, lineOneY2, lineTwoX1, lineTwoY1, lineTwoX2, lineTwoY2);
        }

        private static void PrintLongerLine(double line1x1, double line1y1, double line1x2, double line1y2, double line2x1, double line2y1, double line2x2, double line2y2)
        {
            double lineOneLength = Math.Sqrt(Math.Pow((line1x2 - line1x1), 2) + Math.Pow((line1y2 - line1y1), 2));
            double lineTwoLength = Math.Sqrt(Math.Pow((line2x2 - line2x1), 2) + Math.Pow((line2y2 - line2y1), 2));

            if (lineOneLength > lineTwoLength)
            {
                double distancePoint1ToCenter = Math.Sqrt(Math.Pow(line1x1, 2) + Math.Pow(line1y1, 2));
                double distancePoint2ToCenter = Math.Sqrt(Math.Pow(line1x2, 2) + Math.Pow(line1y2, 2));

                if (distancePoint1ToCenter <= distancePoint2ToCenter)
                {
                    Console.WriteLine("({0}, {1})({2}, {3})", line1x1, line1y1, line1x2, line1y2);
                }
                else
                {
                    Console.WriteLine("({0}, {1})({2}, {3})", line1x2, line1y2, line1x1, line1y1);
                }
            }
            else
            {
                double distancePoint1ToCenter = Math.Sqrt(Math.Pow(line2x1, 2) + Math.Pow(line2y1, 2));
                double distancePoint2ToCenter = Math.Sqrt(Math.Pow(line2x2, 2) + Math.Pow(line2y2, 2));

                if (distancePoint1ToCenter <= distancePoint2ToCenter)
                {
                    Console.WriteLine("({0}, {1})({2}, {3})", line2x1, line2y1, line2x2, line2y2);
                }
                else
                {
                    Console.WriteLine("({0}, {1})({2}, {3})", line2x2, line2y2, line2x1, line2y1);
                }
            }
        }
    }
}
