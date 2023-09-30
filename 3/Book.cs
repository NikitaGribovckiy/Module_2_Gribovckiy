using System;

namespace _3
{
    internal class Book
    {
        // Свойство для хранения названия книги
        public string Title { get; set; }

        // Свойство для хранения года издания книги
        public int Year { get; set; }

        // Свойство для хранения информации об авторе книги
        public Author Author { get; set; }

        // Конструктор класса Book для инициализации полей
        public Book(string title, int year, Author author)
        {
            Title = title;
            Year = year;
            Author = author;
        }
    }
}
