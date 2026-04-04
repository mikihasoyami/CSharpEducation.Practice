namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Radius = 10;
            double SFull = 3.14 * Math.Pow(Radius, 2);
            Console.WriteLine($"Площадь круга равна: {SFull:F2}");
        }
    }
}
