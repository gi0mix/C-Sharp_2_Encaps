using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectInitializers
{
    class Rectangle
    {
        private Point topLeft = new Point();
        private Point bottomRight = new Point();

        public Point TopLeft
        {
            get { return topLeft;}
            set { topLeft = value; }
        }
        public Point BottomRight
        {
            get { return bottomRight; }
            set { bottomRight = value; }
        }

        public void DisplayStats()
        {
            Console.WriteLine("\n\n[TopLeft: {0}, {1}, {2} \t\tBottomRight: {3}, {4}, {5}]",
                topLeft.X, topLeft.Y, topLeft.Color, 
                bottomRight.X, bottomRight.Y, bottomRight.Color);
        }
    }
}
