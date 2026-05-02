using System;
using System.Collections.Generic;
using System.Text;

namespace Practice3.Task6
{
    public struct Point
    {
        public int X;
        public int Y;

        public Point(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public static double GetDistance(Point P1, Point P2)
        {
            int Tp1 = P2.X - P1.X;
            int Tp2 = P2.Y - P1.Y;
            return Math.Sqrt(Tp1 * Tp1 + Tp2 * Tp2);
        }
    }
}
