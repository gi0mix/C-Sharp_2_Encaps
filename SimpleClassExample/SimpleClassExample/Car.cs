using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleClassExample
{
    class Car
    {
        //The car 'state'
        public string petName;
        public int currSpeed;

        public void PrintState() 
            => Console.WriteLine($"{petName} is going at {currSpeed} Km/h\n");

        public void SpeedUp(int delta) => currSpeed += delta;
    }
}
