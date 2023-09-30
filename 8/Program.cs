using System;

namespace _8
{
    class Program
    {
        static void Main()
        {
            int length;

            // Запросите у пользователя длину массивов и убедитесь, что введены корректные данные
            while (true)
            {
                Console.Write("Введите длину массивов строк: ");
                if (int.TryParse(Console.ReadLine(), out length) && length > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Пожалуйста, введите положительное целое число для длины массивов.");
                }
            }

            // Создайте два массива строк фиксированной длины
            FixedLengthStringArray array1 = new FixedLengthStringArray(length);
            FixedLengthStringArray array2 = new FixedLengthStringArray(length);

            // Заполните массивы данными, введенными пользователем, и убедитесь в корректности ввода
            Console.WriteLine("Заполните первый массив:");
            for (int i = 0; i < length; i++)
            {
                Console.Write($"Элемент {i + 1}: ");
                string input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input))
                {
                    array1[i] = input;
                }
                else
                {
                    Console.WriteLine("Элемент не может быть пустым. Пожалуйста, введите элемент снова.");
                    i--;
                }
            }

            Console.WriteLine("\nЗаполните второй массив:");
            for (int i = 0; i < length; i++)
            {
                Console.Write($"Элемент {i + 1}: ");
                string input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input))
                {
                    array2[i] = input;
                }
                else
                {
                    Console.WriteLine("Элемент не может быть пустым. Пожалуйста, введите элемент снова.");
                    i--;
                }
            }

            // Выполните операции с массивами
            FixedLengthStringArray concatenatedArray = array1.Concatenate(array2);
            FixedLengthStringArray mergedArray = array1.MergeWithNoDuplicates(array2);

            // Выведите результаты на экран
            Console.WriteLine("\nРезультат операции поэлементного сцепления:");
            concatenatedArray.DisplayArray();

            Console.WriteLine("\nРезультат операции слияния с исключением повторяющихся элементов:");
            mergedArray.DisplayArray();

            // Запросите у пользователя индекс элемента для вывода и убедитесь в корректности ввода
            int index;
            while (true)
            {
                Console.Write("\nВведите индекс элемента для вывода: ");
                if (int.TryParse(Console.ReadLine(), out index) && index >= 0 && index < length)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Пожалуйста, введите корректный индекс.");
                }
            }

            // Выведите элемент массива по индексу
            array1.DisplayElement(index);
        }
    }
}
