using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeApp
{
    
partial class Employee
    {
        private string empName;
        private int empID;
        private float currPay;
        private int empAge;
        private string empSSN;
        //BUILDER  -  chained builders with the ":" operator
        public Employee() { }
        public Employee(string name, int id, float pay) : this(name, 0, id, pay, "") { }

        //USING THE PROPERTIES of C#, evitiamo di creare i metodi Get Set classic, e mi affido a quelli nuovi indicati
        public Employee(string name, int age, int id, float pay, string ssn)
        {
            if (name.Length > 15)
                Console.WriteLine("Name too long, can set it");
            else
                Name = name;
            Age = age;
            ID = id;
            Pay = pay;
            empSSN = ssn;
        }      
    }
}
