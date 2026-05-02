namespace Practice3.Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle Rectangle = new Rectangle();
            Console.WriteLine("Введите длину прямоугольника");
            double.TryParse(Console.ReadLine(), out double Length);
            Console.WriteLine("Введите ширину прямоугольника");
            double.TryParse(Console.ReadLine(), out double Width);
            Rectangle.Width = Width;
            Rectangle.Length = Length;
            Console.WriteLine($"Площадь прямоугольника: {Rectangle.RectangleS()}");
        }
    }
}
