using System;
using System.Collections.Generic;
using System.Text;

namespace Practice3.Task2
{
    public class Student
    {
        public string StudentName = "Иванов";
        public int StudentAge = 19;
        float AvgBallLocal = 3;

        public float AvgBall
        {
            get
            {
                return AvgBallLocal;
            }
            set
            {
                if (AvgBallLocal >= 0 || AvgBallLocal <= 5)
                    AvgBallLocal = value;
                else
                    Console.WriteLine("Средний балл некорректен, передайте другое значение");
            }
        }
    }
}
