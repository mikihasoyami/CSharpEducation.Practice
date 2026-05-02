using System.Dynamic;

namespace Practice3.Task11
{
    internal class Program
    {
        internal static string GetBookInfo(Book BookInfo)
        { 
            return BookInfo.BookAuthor + " " +
                BookInfo.BookName;
        }

        static void Main(string[] args)
        {
            Book BookInfo = new Book();
            Console.WriteLine($"Ваша книга: {GetBookInfo(BookInfo)}");
        }
    }
}
