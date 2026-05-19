using System;
using System.Collections.Generic;
using System.Text;

namespace Practice4.Task1
{
    public class Manager : Employee
    {
        public int TimeSize { get; set; }
        public Manager(string TName, double TSalary, int TTimeSize) : base(TName, TSalary) 
        {
            TimeSize = TTimeSize;
        }

        public override double CalculateBonus()
        {
            double Bonus = 0.20;
            if (TimeSize > 5)
                Bonus += 0.05;
            return Salary * Bonus;
        }

    }
}
