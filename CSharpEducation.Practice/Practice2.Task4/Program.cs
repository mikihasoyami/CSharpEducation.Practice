namespace Practice2.Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите высоту треугольника");
            int.TryParse(Console.ReadLine(), out int HeightTriangle);
            Console.WriteLine("Введите символ, которым будет выстроена ёлочка");
            char X = Console.ReadLine()[0];

            for (int I = 0; I < HeightTriangle; I++)
            {
                for (int J = 0; J <= I; J++)
                {
                    Console.Write(X);
                }
                Console.WriteLine("");
            }

            Console.WriteLine("");

            for (int I = 0; I < HeightTriangle; I++)
            {
                for (int J = 0; J <= HeightTriangle; J++)
                {
                    if (J < HeightTriangle - I)
                        Console.Write(" ");
                    else
                        Console.Write(X);
                }
                Console.WriteLine("");
            }
        }
    }
}
