using System;

namespace SimpleClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Setting Up a car");

            Car myCar = new Car();
            myCar.petName = "Henry";
            myCar.currSpeed = 10;

            for(int i = 0; i <= 10; i++)
            {
                myCar.SpeedUp(3);
                myCar.PrintState();
            }

            Motorcycle c = new Motorcycle(5);
            c.SetDriverName("Tiny");
            c.PopAWheelie();

            Console.WriteLine($"Driver name: {c.name}");

        }
    }
}
