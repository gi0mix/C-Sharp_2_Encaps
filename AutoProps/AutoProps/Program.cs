using System;

namespace AutoProps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Testing Auto properties ***");

            Car c = new Car();
            c.PetName = "Frank";
            c.Speed = 45;
            c.Color = "Blue";

            Console.WriteLine("Your car is named {0}", c.PetName);
            c.DisplayStats();

            //Put car in the garage
            Garage g = new Garage();
            g.MyAuto = c;
            Console.WriteLine("NofCars inside: {0}", g.NumberOfCars);
            Console.WriteLine("Ur car is: {0}", g.MyAuto.PetName);
        }
    }
}
