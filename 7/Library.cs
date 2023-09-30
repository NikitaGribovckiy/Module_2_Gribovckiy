using System;
using System.Collections.Generic;
using System.Linq;

namespace _7
{
    class Library
    {
        private List<Book> books = new List<Book>();

        // Добавление книги в библиотеку
        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine($"Книга \"{book.Title}\" успешно добавлена в библиотеку.");
        }

        // Удаление книги из библиотеки по названию
        public void RemoveBook(string title)
        {
            Book bookToRemove = books.FirstOrDefault(b => b.Title == title);
            if (bookToRemove != null)
            {
                books.Remove(bookToRemove);
                Console.WriteLine($"Книга \"{title}\" успешно удалена из библиотеки.");
            }
            else
            {
                Console.WriteLine($"Книга \"{title}\" не найдена в библиотеке.");
            }
        }

        // Поиск книг по автору и возврат списка найденных книг
        public List<Book> FindBooksByAuthor(string author)
        {
            return books.Where(b => b.Author == author).ToList();
        }

        // Поиск книг по году издания и возврат списка найденных книг
        public List<Book> FindBooksByYear(int year)
        {
            return books.Where(b => b.Year == year).ToList();
        }

        // Сортировка книг по названию
        public void SortBooksByTitle()
        {
            books.Sort((book1, book2) => book1.Title.CompareTo(book2.Title));
        }

        // Сортировка книг по автору
        public void SortBooksByAuthor()
        {
            books.Sort((book1, book2) => book1.Author.CompareTo(book2.Author));
        }

        // Вывод списка всех книг в библиотеке
        public void DisplayBooks()
        {
            Console.WriteLine("Список книг в библиотеке:");
            foreach (Book book in books)
            {
                Console.WriteLine($"{book.Title} ({book.Author}, {book.Year})");
            }
        }

        // Перегруженный метод для вывода списка книг по заданному списку
        public void DisplayBooks(List<Book> bookList)
        {
            Console.WriteLine("Список книг:");
            foreach (Book book in bookList)
            {
                Console.WriteLine($"{book.Title} ({book.Author}, {book.Year})");
            }
        }
    }
}
