using System;
using System.Collections.Generic;
using System.Text;

namespace Practice4.Task1
{
    public class Contractor : Employee
    {
        public double HourlyRate {  get; set; }
        public Contractor(string TName, double THourlyRate) : base(TName, 0)
        {
            HourlyRate = THourlyRate;
        }
     
        public double CalculateBonus(int HoursWorker)
        {
            return HourlyRate * HoursWorker * 0.15;
        }

        public override double CalculateBonus()
        {
            return 0;
        }
    }
}
