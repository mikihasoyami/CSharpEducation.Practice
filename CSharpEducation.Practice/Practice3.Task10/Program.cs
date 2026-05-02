using static Practice3.Task10.Car;

namespace Practice3.Task10
{
    internal class Program
    {
        internal static string GetCarMark(Car CarInfo)
        {
            return CarInfo.CarMark;
        }

        static void Main(string[] args)
        {
            Car CarInfo = new Car();
            Console.WriteLine($"Ваша марка автомобиля: {GetCarMark(CarInfo)}");
        }
    }
}
