using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace ObjectsAndClasses
{
    class Program
    {

        static void Main(string[] args)
        {
            int numberOfPoints = int.Parse(Console.ReadLine());
            var allPoints = new List<Point>();

            double minDistance = double.MaxValue;
            Point firstMinPoint = null;
            Point secondMinPoint = null;

            for (int i = 0; i < numberOfPoints; i++)
            {
                Point currentPoint = ReadPoint();
                allPoints.Add(currentPoint);
            }
            for (int i = 0; i < numberOfPoints; i++)
            {
                for (int j = i + 1; j < numberOfPoints; j++)
                {
                    var firstPoint = allPoints[i];
                    var secondPoint = allPoints[j];
                    var currentDistance = DistanceBetweenTwoPoints(firstPoint, secondPoint);

                    if (currentDistance < minDistance)
                    {
                        minDistance = currentDistance;
                        firstMinPoint = firstPoint;
                        secondMinPoint = secondPoint;
                    }
                }
            }
            Console.WriteLine($"{minDistance:f3}");
            Console.WriteLine(firstMinPoint.Displayed());
            Console.WriteLine(secondMinPoint.Displayed());
        }

        static double DistanceBetweenTwoPoints(Point first, Point second)
        {
            var xDiff = first.X - second.X;
            var xPow = xDiff * xDiff;
            var yDiff = first.Y - second.Y;
            var yPow = yDiff * yDiff;
            return Math.Sqrt(xPow + yPow);
        }

        static Point ReadPoint()
        {
            var pointData = Console.ReadLine().
                Split(" ");

            var point = new Point()
            {
                X = int.Parse(pointData[0]),
                Y = int.Parse(pointData[1])
            };
            return point;
        }
    }
}
