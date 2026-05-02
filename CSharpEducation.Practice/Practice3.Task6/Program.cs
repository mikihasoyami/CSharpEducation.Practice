namespace Practice3.Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point Point1 = new Point(2,4);
            Point Point2 = new Point(6,8);
            double Distance  = Point.GetDistance(Point1, Point2);
            Console.WriteLine($"Значение расстояния между точками: {Distance:F2}");
        }
    }
}
