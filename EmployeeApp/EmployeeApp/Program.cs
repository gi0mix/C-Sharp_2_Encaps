using System;

namespace EmployeeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Encapsulation Samples ****");
            Employee emp = new Employee("Marvin", 456, 30_000);
            emp.GiveBonus(1000);
            emp.DisplayStats();
            /* Classic Method Get / Set
            emp.setName("Marv");
            Console.WriteLine("Emp name, has been changed now he is: {0}", emp.GetName());
            */
            emp.Name = "Marv"; //SET in C#
            Console.WriteLine("Marvin name has changed in {0}", emp.Name);

            //New get / set methods allows me to use easiest operation
            Employee joe = new Employee("Joe", 457, 25_000);
            joe.Age++;

            joe.DisplayStats();
        }
    }
}
