namespace Practice3.Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book BookInfo = new Book();
            Book BookInfo2 = new Book("Война и Мир", "Л.Н.Толстой");
            Console.WriteLine($"Информация по умолчанию: {BookInfo.BookName} {BookInfo.BookAuthor}");
            Console.WriteLine($"Информация по переданным данным: {BookInfo2.BookName} {BookInfo2.BookAuthor}");
        }
    }
}
