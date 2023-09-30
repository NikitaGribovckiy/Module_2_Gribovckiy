using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main()
        {
            // Создание объектов авторов
            Author author1 = new Author("John Doe", 1980);
            Author author2 = new Author("Jane Smith", 1975);

            // Создание объектов книг с указанием авторов
            Book book1 = new Book("Book 1", 2020, author1);
            Book book2 = new Book("Book 2", 2018, author2);

            // Вывод информации о книгах и их авторах
            Console.WriteLine("Книга 1:");
            Console.WriteLine("Название: " + book1.Title);
            Console.WriteLine("Год выпуска: " + book1.Year);
            Console.WriteLine("Автор: " + book1.Author.Name + ", Год рождения автора: " + book1.Author.BirthYear);
            Console.WriteLine();

            Console.WriteLine("Книга 2:");
            Console.WriteLine("Название: " + book2.Title);
            Console.WriteLine("Год выпуска: " + book2.Year);
            Console.WriteLine("Автор: " + book2.Author.Name + ", Год рождения автора: " + book2.Author.BirthYear);
        }
    }
}
