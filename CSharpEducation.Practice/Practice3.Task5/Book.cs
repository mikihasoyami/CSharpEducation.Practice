using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.WebRequestMethods;

namespace Practice3.Task5
{
    public struct Book
    {
        public string BookName;
        public string BookAuthor;
        public int ProductionYear;

        public Book()
        {
            BookName = "Неизвестное название";
            BookAuthor = "Неизвестный автор";
            ProductionYear = 0;
        }

        public Book(string Title, string Author)
        {
            BookName = Title;
            BookAuthor = Author;
            ProductionYear = 0;
        }

        public Book(string Title, string Author, int Year)
        {
            BookName = Title;
            BookAuthor = Author;
            ProductionYear = Year;
        }
    }
}
