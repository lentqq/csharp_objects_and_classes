using System;

namespace _06.RectanglePosition
{
    class RectanglePosition
    {
        static void Main(string[] args)
        {
            var firstRectangle = ReadRectangle();
            var secondRectangle = ReadRectangle();
            var result = firstRectangle.IsInside(secondRectangle);
            if (result)
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Not inside");
            }
        }
        static Rectangle ReadRectangle()
        {
            var rectangleDate = Console.ReadLine()
                .Split(' ');
            return new Rectangle
            {
                Left = int.Parse(rectangleDate[0]),
                Top = int.Parse(rectangleDate[1]),
                Width = int.Parse(rectangleDate[2]),
                Height = int.Parse(rectangleDate[3])
            };
        }
    }
}
