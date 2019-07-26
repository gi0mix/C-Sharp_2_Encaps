using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleClassExample
{
    class Motorcycle
    {
        public int driverIntensity;
        public string name;

        public Motorcycle() { }
        //Constructor Chaining
        public Motorcycle(int intensity) : this(intensity, "") {} //DELEGANO A Line16 : MAIN BUILDER
        public Motorcycle(string name) : this(0, name) {} //DELEGA A Line16 : MAIN BUILDER
        public Motorcycle(int intensity, string name)
        {
            SetIntensity(intensity);
            SetDriverName(name);
        } // MAIN BUILDER

        //Methods
        public void PopAWheelie()
        {
            for(int i = 0; i<=driverIntensity; i++)
                Console.WriteLine("Yeeeeeeee Haaaaaaaa");
        }

        public void SetDriverName(string name)
        {
            this.name = name;
        }

        public void SetIntensity(int intensity)
        {
            if(intensity > 10) { intensity = 10; }
            driverIntensity = intensity;
        }
    }
}
