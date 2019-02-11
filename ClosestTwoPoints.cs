using System;
using System.Collections.Generic;

namespace _05.ClosestTwoPoints
{
    class ClosestTwoPoints
    {
        static void Main(string[] args)
        {
            int numberOfPoints = int.Parse(Console.ReadLine());
            var allPoints = new List<Point>();

           
            for (int i = 0; i < numberOfPoints; i++)
            {
                var currentPoint = ReadPoint();
                allPoints.Add(ReadPoint());
            }
            var minDistance = double.MaxValue;
            Point firstMinPoint = null;
            Point secondMinPoint = null;

            for (int i = 0; i < numberOfPoints; i++)
            {
                for (int j = i + 1; j < numberOfPoints; j++)
                {
                    var firstPoint = allPoints[i];
                    var secondPoint = allPoints[j];
                    var currentDistance = CalculateDistance(firstPoint, secondPoint);
                    if (currentDistance < minDistance)
                    {
                        minDistance = currentDistance;
                        firstMinPoint = firstPoint;
                        secondMinPoint = secondPoint;
                    }
                }
            }
            Console.WriteLine($"{minDistance:f3}");
            //Console.WriteLine($"({firstMinPoint.X}, {firstMinPoint.Y})");
            //Console.WriteLine($"({secondMinPoint.X}, {secondMinPoint.Y})");
            Console.WriteLine(firstMinPoint.Displayd());
            Console.WriteLine(secondMinPoint.Displayd());
        }
        static double CalculateDistance(Point first,Point second)
        {
            var xDiff = first.X - second.Y;
            var xPow = Math.Pow(xDiff, 2);
            var yDiff = first.Y - second.Y;
            var yPow = Math.Pow(yDiff, 2);
            return Math.Sqrt(xPow + yPow);
        }
        static Point ReadPoint()
        {
            string[] pointDate = Console.ReadLine()
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
