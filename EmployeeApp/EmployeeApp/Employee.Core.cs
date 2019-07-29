using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeApp
{
    partial class Employee
    {
        //Cores Method
        public string Name
        {
            get => empName;
            set
            {
                if (value.Length > 15)
                    Console.WriteLine("Error! Name Length exceeds 15 characters!");
                else
                    empName = value;
            }
        }

        public int ID
        {
            get => empID;
            set => empID = value;
        }

        public float Pay
        {
            get => currPay;
            set => currPay = value;
        }

        public int Age
        {
            get => empAge;
            set => empAge = value;
        }

        public string SocialSecurityNumber
        {
            get => empSSN;      //This is a ReadOnly parameter, so i avoid to describe a Set;
        }
        //METH
        public void GiveBonus(float amount)
        {
            currPay += amount;
        }

        public void DisplayStats()
        {
            Console.WriteLine($"Name: {empName}; \nAge: {empAge} \nID: {empID}; \nPay: {currPay}");
        }
    }
}
