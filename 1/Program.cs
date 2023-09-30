using _1; // Импортируем пространство имен, где определен класс Person
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Запрашиваем у пользователя количество персон и проверяем ввод
        Console.WriteLine("Введите количество персон:");
        int a = 0;
        while (!int.TryParse(Console.ReadLine(), out a) || a <= 0)
        {
            Console.WriteLine("Пожалуйста, введите положительное целое число.");
        }

        // Создаем массив для хранения объектов Person
        Person[] persons = new Person[a];

        // Заполняем массив данными о каждой персоне
        for (int i = 0; i < persons.Length; i++)
        {
            persons[i] = new Person(); // Создаем новый объект Person

            Console.WriteLine($"Введите информацию о персоне {i + 1}:");

            // Ввод и проверка имени
            Console.Write("Имя: ");
            string name = Console.ReadLine();
            while (string.IsNullOrEmpty(name) || !name.All(char.IsLetter))
            {
                Console.WriteLine("Имя должно состоять только из букв и не может быть пустым. Пожалуйста, введите имя.");
                name = Console.ReadLine();
            }
            persons[i].SetName(name);

            // Ввод и проверка возраста
            Console.Write("Возраст: ");
            int age;
            while (!int.TryParse(Console.ReadLine(), out age) || age <= 0)
            {
                Console.WriteLine("Пожалуйста, введите корректный возраст (положительное целое число).");
            }
            persons[i].SetAge(age);

            // Ввод и проверка адреса
            Console.Write("Адрес: ");
            string address = Console.ReadLine();
            while (string.IsNullOrEmpty(address))
            {
                Console.WriteLine("Адрес не может быть пустым. Пожалуйста, введите адрес.");
                address = Console.ReadLine();
            }
            persons[i].SetAddress(address);

            Console.WriteLine(); // Пустая строка для разделения информации о персонах
        }

        // Очищаем консоль и выводим информацию о персонах
        Console.Clear();
        for (int i = 0; i < persons.Length; i++)
        {
            Console.WriteLine($"Персона {i + 1}");
            Console.WriteLine($"Имя: {persons[i].GetName()}");
            Console.WriteLine($"Возраст: {persons[i].GetAge()}");
            Console.WriteLine($"Адрес: {persons[i].GetAddress()}");
            Console.WriteLine();
        }
    }
}
