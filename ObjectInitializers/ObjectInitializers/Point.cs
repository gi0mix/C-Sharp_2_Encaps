﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectInitializers
{
    enum PointColor { LightBlue, BloodRed, Gold}
    class Point
    {
        //Fields
        public int X { get; set; }
        public int Y { get; set; }
        public PointColor Color { get; set; }

        //Builders
        public Point(int xVal, int yVal)
        {
            X = xVal;
            Y = yVal;
            Color = PointColor.Gold;
        }
        public Point(PointColor ptColor)
        {
            Color = ptColor;
        }
        public Point() : this(PointColor.BloodRed) { }
        public void DisplayStats()
        {
            Console.WriteLine("[{0}, {1}]", X, Y);
            Console.WriteLine("Point is {0}", Color);
        }
    }
}
