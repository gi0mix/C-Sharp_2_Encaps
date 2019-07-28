using System;

namespace ObjectInitializers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Ways to Initialize Objects in C#");

            Point P1 = new Point();
            P1.X = 10;
            P1.Y = 10;

            Point P2 = new Point(12, 12);

            Point P3 = new Point { X = 16, Y = 16 }; // == Point P3 = new Point() { X = 16, Y = 16 }

            Point P4 = new Point(PointColor.Gold) { X = 90, Y = 20 };

            P1.DisplayStats();
            P2.DisplayStats();
            P3.DisplayStats();
            P4.DisplayStats();

            Rectangle myRect = new Rectangle    //New Schoold C# approach to Object Initialization
            {
                TopLeft = new Point { X = 10, Y = 10 },
                BottomRight = new Point { X = 200, Y = 200}
            };

            myRect.DisplayStats();
        }
    }
}
