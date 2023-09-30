using System;
using System.Collections.Generic;

namespace _7
{
    class Program
    {
        static void Main()
        {
            // Создаем объект библиотеки
            Library library = new Library();

            // Добавляем книги
            library.AddBook(new Book("Книга 1", "Автор 1", 2000));
            library.AddBook(new Book("Книга 2", "Автор 2", 1995));
            library.AddBook(new Book("Книга 3", "Автор 1", 2010));

            // Выводим список книг
            library.DisplayBooks();

            // Ищем книги по автору и году
            List<Book> booksByAuthor = library.FindBooksByAuthor("Автор 1");
            List<Book> booksByYear = library.FindBooksByYear(2000);

            Console.WriteLine("\nКниги по автору 'Автор 1':");
            library.DisplayBooks(booksByAuthor);

            Console.WriteLine("\nКниги по году издания 2000:");
            library.DisplayBooks(booksByYear);

            // Сортируем книги и выводим
            library.SortBooksByTitle();
            Console.WriteLine("\nСортировка книг по названию:");
            library.DisplayBooks();

            library.SortBooksByAuthor();
            Console.WriteLine("\nСортировка книг по автору:");
            library.DisplayBooks();

            // Удаляем книгу и выводим обновленный список
            library.RemoveBook("Книга 2");
            Console.WriteLine("\nКнига 'Книга 2' удалена.");
            library.DisplayBooks();
        }
    }
}
