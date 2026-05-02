using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.WebRequestMethods;

namespace Practice3.Task4
{
    public struct Book
    {
        public string BookName;
        public string BookAuthor;

        public Book()
        {
            BookName = "Неизвестное название";
            BookAuthor = "Неизвестный автор";
        }

        // Конструктор с параметрами
        public Book(string Title, string Author)
        {
            BookName = Title;
            BookAuthor = Author;
        }
    }
}
