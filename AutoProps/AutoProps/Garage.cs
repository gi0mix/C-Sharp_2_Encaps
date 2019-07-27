using System;
using System.Collections.Generic;
using System.Text;

namespace AutoProps
{
    class Garage
    {
        public int NumberOfCars { get; set; } = 1;      //Default value for int is 0                   now is 1
        public Car MyAuto { get; set; } = new Car();    //Default value of class type is NULL!!!!      now has a new Car on Spawn

        public Garage()
        {/*
            MyAuto = new Car(); //Doing so, I never catch a NULL reference error in runtime
            NumberOfCars = 1;   //Obv cause at least 1 car is created when a garage is Invoked
        */
        }

        public Garage(Car car, int number)
        {
            MyAuto = car;
            NumberOfCars = number;
        }
    }
}
