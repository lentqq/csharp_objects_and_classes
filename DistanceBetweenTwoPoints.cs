using System;

namespace _04.DistanceBetweenTwoPoints
{
    class DistanceBetweenTwoPoints
    {
        static void Main(string[] args)
        {
            var firstPoint = ReadPoint();
            var secondPoint = ReadPoint();
     
            var result = CalculateDistance(firstPoint, secondPoint);
            Console.WriteLine($"{result:F3}");
        }
        static double CalculateDistance(Point first,Point second)
        {
            var xDiff = first.X - second.X;
            var xPow = Math.Pow(xDiff, 2);
            var yDiff = first.Y - second.Y;
            var yPow = Math.Pow(yDiff, 2);
            return Math.Sqrt(xPow + yPow);
        }
        static Point ReadPoint()
        {
            var pointDate = Console.ReadLine()
                .Split(' ');
            var point = new Point
            {
                X = int.Parse(pointDate[0]),
                Y = int.Parse(pointDate[1])
            };
            return point;
        }
    }
}

