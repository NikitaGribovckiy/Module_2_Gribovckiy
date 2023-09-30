using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    class FixedLengthStringArray
    {
        private string[] array;

        // Конструктор для инициализации массива заданной длины
        public FixedLengthStringArray(int length)
        {
            if (length <= 0)
            {
                throw new ArgumentException("Длина массива должна быть положительным числом.");
            }

            array = new string[length];
        }

        // Метод для получения длины массива
        public int Length
        {
            get { return array.Length; }
        }

        // Индексатор для доступа к элементам массива по индексу
        public string this[int index]
        {
            get
            {
                if (index < 0 || index >= array.Length)
                {
                    throw new IndexOutOfRangeException("Индекс выходит за пределы массива.");
                }

                return array[index];
            }
            set
            {
                if (index < 0 || index >= array.Length)
                {
                    throw new IndexOutOfRangeException("Индекс выходит за пределы массива.");
                }

                array[index] = value;
            }
        }

        // Метод для выполнения операции поэлементного сцепления двух массивов
        public FixedLengthStringArray Concatenate(FixedLengthStringArray otherArray)
        {
            if (otherArray.Length != Length)
            {
                throw new ArgumentException("Длины массивов должны совпадать для выполнения сцепления.");
            }

            FixedLengthStringArray result = new FixedLengthStringArray(Length);
            for (int i = 0; i < Length; i++)
            {
                result[i] = array[i] + otherArray[i];
            }

            return result;
        }

        // Метод для слияния двух массивов с исключением повторяющихся элементов
        public FixedLengthStringArray MergeWithNoDuplicates(FixedLengthStringArray otherArray)
        {
            if (otherArray.Length != Length)
            {
                throw new ArgumentException("Длины массивов должны совпадать для выполнения слияния.");
            }

            FixedLengthStringArray result = new FixedLengthStringArray(Length);
            for (int i = 0; i < Length; i++)
            {
                string mergedValue = array[i];
                if (array[i] != otherArray[i])
                {
                    mergedValue += otherArray[i];
                }

                result[i] = mergedValue;
            }

            return result;
        }

        // Метод для вывода элемента массива по заданному индексу
        public void DisplayElement(int index)
        {
            if (index < 0 || index >= array.Length)
            {
                throw new IndexOutOfRangeException("Индекс выходит за пределы массива.");
            }

            Console.WriteLine($"Элемент массива с индексом {index}: {array[index]}");
        }

        // Метод для вывода всего массива
        public void DisplayArray()
        {
            Console.WriteLine("Элементы массива:");
            for (int i = 0; i < Length; i++)
            {
                Console.WriteLine($"[{i}]: {array[i]}");
            }
        }
    }
}
