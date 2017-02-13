using System;

namespace GeometryCalculator
{
    public class GeometryCalculator
    {
        public static void Main()
        {
            string figureType = Console.ReadLine();
            AreaFigure(figureType);
        }

        public static void AreaFigure(string figure)
        {
            double area = 0;

            switch (figure)
            {
                case "triangle":
                    double triagnleSide = double.Parse(Console.ReadLine());
                    double triangleHeight = double.Parse(Console.ReadLine());
                    area = (triagnleSide * triangleHeight) / 2;
                    break;
                case "square":
                    double squareSide = double.Parse(Console.ReadLine());
                    area = squareSide * squareSide;
                    break;
                case "rectangle":
                    double rectangleWidth = double.Parse(Console.ReadLine());
                    double rectangleHeight = double.Parse(Console.ReadLine());
                    area = rectangleWidth * rectangleHeight;
                    break;
                case "circle":
                    double circleRadius = double.Parse(Console.ReadLine());
                    area = Math.PI * circleRadius * circleRadius;
                    break;
            }

            Console.WriteLine("{0:F2}", area);
        }
    }
}
