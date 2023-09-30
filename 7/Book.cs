using System;

namespace _7
{
    class Book
    {
        // Свойство для названия книги
        public string Title { get; set; }

        // Свойство для имени автора
        public string Author { get; set; }

        // Свойство для года издания
        public int Year { get; set; }

        // Конструктор класса для инициализации свойств книги
        public Book(string title, string author, int year)
        {
            Title = title;
            Author = author;
            Year = year;
        }
    }
}
