using System;
using System.Linq;

namespace RectanglePosition
{
    public class RectanglePosition
    {
        public static void Main()
        {
            int[] r1Arguments = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] r2Arguments = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Rectangle rect1 = GenRectangle(r1Arguments);
            Rectangle rect2 = GenRectangle(r2Arguments);

            bool isInside = IsR1InsideR2(rect1, rect2);

            if (isInside)
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Not inside");
            }
        }

        public static Rectangle GenRectangle(int[] args)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Left = args[0];
            rectangle.Top = args[1];
            rectangle.Width = args[2];
            rectangle.Height = args[3];

            return rectangle;
        }

        public static bool IsR1InsideR2(Rectangle r1, Rectangle r2)
        {
            bool isInside = (r2.Left <= r1.Left && r2.Right >= r1.Right && r2.Top <= r1.Top && r2.Bottom >= r1.Bottom);
            return isInside;
        }
    }

    public class Rectangle
    {
        public int Top { get; set; }
        public int Left { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public int Right
        {
            get
            {
                return Left + Width;
            }
        }
        public int Bottom
        {
            get
            {
                return Top + Height;
            }
        }
    }
}
