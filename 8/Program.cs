using System;

namespace _8
{
    class Program
    {
        static void Main()
        {
            // Создаем два массива строк фиксированной длины
            FixedLengthStringArray array1 = new FixedLengthStringArray(3);
            array1[0] = "Привет, ";
            array1[1] = "мир!";
            array1[2] = "Программирование ";

            FixedLengthStringArray array2 = new FixedLengthStringArray(3);
            array2[0] = "C#";
            array2[1] = " - это";
            array2[2] = "весело!";

            // Выполняем операции с массивами
            FixedLengthStringArray concatenatedArray = array1.Concatenate(array2);
            FixedLengthStringArray mergedArray = array1.MergeWithNoDuplicates(array2);

            // Выводим результаты
            Console.WriteLine("Результат операции поэлементного сцепления:");
            concatenatedArray.DisplayArray();

            Console.WriteLine("\nРезультат операции слияния с исключением повторяющихся элементов:");
            mergedArray.DisplayArray();

            // Выводим элемент массива по индексу
            array1.DisplayElement(1);
        }
    }
}
