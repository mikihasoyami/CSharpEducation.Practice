using System;
using System.Collections.Generic;
using System.Text;

namespace Practice4.Task1
{
    public class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string TName, double TSalary)
        {
            Name = TName;
            Salary = TSalary;
        }

        public virtual double CalculateBonus()
        {
            return Salary * 0.10;
        }
    }
}
