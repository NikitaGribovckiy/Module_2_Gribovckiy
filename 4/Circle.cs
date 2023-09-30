using System;

namespace _4
{
    // Объявление класса Circle, который реализует интерфейс IDrawable.
    internal class Circle : IDrawable
    {
        // Приватное поле для хранения радиуса круга.
        private double radius;

        // Конструктор класса, который принимает радиус круга и инициализирует поле.
        public Circle(double radius)
        {
            this.radius = radius;
        }

        // Реализация метода Draw из интерфейса IDrawable.
        // Этот метод выводит информацию о круге (его радиусе) на консоль.
        public void Draw()
        {
            Console.WriteLine($"Рисуем круг с радиусом {radius}");
        }
    }
}
