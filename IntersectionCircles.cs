using System;
using System.Linq;

namespace _02.IntersectionCircles
{
    class IntersectionCircles
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            Circle circle1 = new Circle();
            circle1.Center = new Point();
            circle1.Center.X = input[0];
            circle1.Center.Y = input[1];
            circle1.Radius = input[2];

            input = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            Circle circle2 = new Circle();
            circle2.Center = new Point();
            circle2.Center.X = input[0];
            circle2.Center.Y = input[1];
            circle2.Radius = input[2];

            double xDiff = Math.Abs(circle1.Center.X - circle2.Center.X);
            double xPow = Math.Pow(xDiff, 2);
            double yDiff = Math.Abs(circle1.Center.Y - circle2.Center.Y);
            double yPow = Math.Pow(yDiff, 2);
            double distance = Math.Sqrt(xPow + yPow);

            if (distance <= circle1.Radius + circle2.Radius)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

    }

    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
    }
    class Circle
    {
        public Point Center { get; set; }
        public double Radius { get; set; }
    }
}
