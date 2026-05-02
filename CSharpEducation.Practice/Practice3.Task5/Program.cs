namespace Practice3.Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book BookInfo = new Book();
            Book BookInfo2 = new Book("Война и Мир", "Л.Н.Толстой");
            Book BookInfo3 = new Book("Война и Мир", "Л.Н.Толстой", 1869);
            Console.WriteLine($"Информация: {BookInfo.BookName} {BookInfo.BookAuthor}, год издания {BookInfo.ProductionYear}");
            Console.WriteLine($"Информация: {BookInfo2.BookName} {BookInfo2.BookAuthor}, год издания {BookInfo2.ProductionYear}");
            Console.WriteLine($"Информация: {BookInfo3.BookName} {BookInfo3.BookAuthor}, год издания {BookInfo3.ProductionYear}");
        }
    }
}
