using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите радиус круга: ");
            double radius;

            // В этом цикле происходит ввод радиуса круга. Он продолжается до тех пор,
            // пока пользователь не введет положительное число для радиуса.
            while (!double.TryParse(Console.ReadLine(), out radius) || radius <= 0)
            {
                Console.WriteLine("Неправильный ввод. Пожалуйста, введите положительное число для радиуса круга:");
            }

            Console.WriteLine("Введите ширину прямоугольника: ");
            double width;

            // Аналогично, в этом цикле происходит ввод ширины прямоугольника.
            while (!double.TryParse(Console.ReadLine(), out width) || width <= 0)
            {
                Console.WriteLine("Неправильный ввод. Пожалуйста, введите положительное число для ширины прямоугольника:");
            }

            Console.WriteLine("Введите высоту прямоугольника: ");
            double height;

            // И здесь происходит ввод высоты прямоугольника.
            while (!double.TryParse(Console.ReadLine(), out height) || height <= 0)
            {
                Console.WriteLine("Неправильный ввод. Пожалуйста, введите положительное число для высоты прямоугольника:");
            }

            // Создание объектов круга и прямоугольника с введенными данными.
            Circle circle = new Circle(radius);
            Rectangle rectangle = new Rectangle(width, height);

            // Вычисление площади и периметра круга.
            double circleArea = circle.Area();
            double circlePerimeter = circle.Perimeter();

            // Вычисление площади и периметра прямоугольника.
            double rectangleArea = rectangle.Area();
            double rectanglePerimeter = rectangle.Perimeter();

            // Вывод результатов на экран.
            Console.WriteLine("Круг - Площадь: " + circleArea + ", Периметр: " + circlePerimeter);
            Console.WriteLine("Прямоугольник - Площадь: " + rectangleArea + ", Периметр: " + rectanglePerimeter);
        }
    }
}
