using System;
using System.Globalization;
using System.Linq;

namespace _01.DayOfWeek
{
    class DayOfWeek
    {
        static void Main(string[] args)
        {
            //string textDate = Console.ReadLine();
            //DateTime date = DateTime.ParseExact(textDate, "d-M-yyyy", CultureInfo.InvariantCulture);
            //Console.WriteLine(date.DayOfWeek);

            int[] input = Console.ReadLine().Split('-').Select(int.Parse).ToArray();
            DateTime day = new DateTime(input[2], input[1], input[0]);
            Console.WriteLine(day.DayOfWeek);
        }
    }
}
