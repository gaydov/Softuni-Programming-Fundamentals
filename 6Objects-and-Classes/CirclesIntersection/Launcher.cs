using System;
using System.Linq;

namespace CirclesIntersection
{
    public class Launcher
    {
        public static void Main()
        {
            double[] firstCircleArgs = Console.ReadLine().Split().Select(double.Parse).ToArray();
            Circle firstCircle = new Circle();
            firstCircle.Center.X = firstCircleArgs[0];
            firstCircle.Center.Y = firstCircleArgs[1];
            firstCircle.Radius = firstCircleArgs[2];

            double[] secondCircleArgs = Console.ReadLine().Split().Select(double.Parse).ToArray();
            Circle secondCircle = new Circle();
            secondCircle.Center.X = secondCircleArgs[0];
            secondCircle.Center.Y = secondCircleArgs[1];
            secondCircle.Radius = secondCircleArgs[2];

            if (DoIntersect(firstCircle, secondCircle))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        public static bool DoIntersect(Circle c1, Circle c2)
        {
            double distance = CalcDistance(c1.Center, c2.Center);

            if (distance <= c1.Radius + c2.Radius)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static double CalcDistance(Circle.Point c1Center, Circle.Point c2Center)
        {
            double distance = Math.Sqrt(Math.Pow(c1Center.X - c2Center.X, 2) + Math.Pow(c1Center.Y - c2Center.Y, 2));
            return distance;
        }
    }

    public class Circle
    {
        private Point center = new Point();
        private double radius;

        public Point Center
        {
            get { return this.center; }
        }

        public double Radius
        {
            get { return this.radius; }
            set { this.radius = value; }
        }

        public class Point
        {
            public double X { get; set; }

            public double Y { get; set; }
        }
    }
}
