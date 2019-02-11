using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectsAndClasses
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public string Displayed()
        {
            return $"({X}, {Y})";
        }
    }
}
