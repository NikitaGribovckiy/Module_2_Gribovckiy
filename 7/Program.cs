using System;
using System.Collections.Generic;

namespace _7
{
    class Program
    {
        static void Main()
        {
            Library library = new Library();

            while (true)
            {
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1. Добавить книгу");
                Console.WriteLine("2. Удалить книгу");
                Console.WriteLine("3. Найти книги по автору");
                Console.WriteLine("4. Найти книги по году издания");
                Console.WriteLine("5. Вывести список всех книг");
                Console.WriteLine("6. Сортировать книги по названию");
                Console.WriteLine("7. Сортировать книги по автору");
                Console.WriteLine("8. Выйти из программы");

                int choice;
                while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 8)
                {
                    Console.WriteLine("Некорректный выбор. Пожалуйста, выберите действие от 1 до 8.");
                }

                switch (choice)
                {
                    case 1:
                        Console.Write("Введите название книги: ");
                        string title = Console.ReadLine();
                        Console.Write("Введите автора книги: ");
                        string author = Console.ReadLine();
                        int year;
                        while (true)
                        {
                            Console.Write("Введите год издания книги: ");
                            if (int.TryParse(Console.ReadLine(), out year))
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Некорректный ввод. Пожалуйста, введите корректный год.");
                            }
                        }
                        library.AddBook(new Book(title, author, year));
                        break;
                    case 2:
                        Console.Write("Введите название книги для удаления: ");
                        string bookToRemove = Console.ReadLine();
                        library.RemoveBook(bookToRemove);
                        break;
                    case 3:
                        Console.Write("Введите имя автора для поиска книг: ");
                        string authorToFind = Console.ReadLine();
                        List<Book> booksByAuthor = library.FindBooksByAuthor(authorToFind);
                        Console.WriteLine($"Найденные книги по автору '{authorToFind}':");
                        library.DisplayBooks(booksByAuthor);
                        break;
                    case 4:
                        while (true)
                        {
                            Console.Write("Введите год издания для поиска книг: ");
                            if (int.TryParse(Console.ReadLine(), out year))
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Некорректный ввод. Пожалуйста, введите корректный год.");
                            }
                        }
                        List<Book> booksByYear = library.FindBooksByYear(year);
                        Console.WriteLine($"Найденные книги по году издания {year}:");
                        library.DisplayBooks(booksByYear);
                        break;
                    case 5:
                        library.DisplayBooks();
                        break;
                    case 6:
                        library.SortBooksByTitle();
                        Console.WriteLine("Книги отсортированы по названию:");
                        library.DisplayBooks();
                        break;
                    case 7:
                        library.SortBooksByAuthor();
                        Console.WriteLine("Книги отсортированы по автору:");
                        library.DisplayBooks();
                        break;
                    case 8:
                        Environment.Exit(0);
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}
