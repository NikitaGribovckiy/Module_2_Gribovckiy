using System;

namespace _3
{
    internal class Author
    {
        // Свойство для хранения имени автора
        public string Name { get; set; }

        // Свойство для хранения года рождения автора
        public int BirthYear { get; set; }

        // Конструктор класса Author для инициализации полей
        public Author(string name, int birthYear)
        {
            Name = name;
            BirthYear = birthYear;
        }
    }
}
