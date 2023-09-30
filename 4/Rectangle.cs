using System;

namespace _4
{
    // Объявление класса Rectangle, который реализует интерфейс IDrawable.
    internal class Rectangle : IDrawable
    {
        // Приватные поля для хранения ширины и высоты прямоугольника.
        private double width;
        private double height;

        // Конструктор класса, который принимает ширину и высоту прямоугольника и инициализирует поля.
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        // Реализация метода Draw из интерфейса IDrawable.
        // Этот метод выводит информацию о прямоугольнике (его ширине и высоте) на консоль.
        public void Draw()
        {
            Console.WriteLine($"Рисуем прямоугольник с шириной {width} и высотой {height}");
        }
    }
}
