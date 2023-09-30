using System;

namespace _4
{
    // Объявление класса Triangle, который реализует интерфейс IDrawable.
    internal class Triangle : IDrawable
    {
        // Приватные поля для хранения длин сторон треугольника.
        private double side1;
        private double side2;
        private double side3;

        // Конструктор класса, который принимает длины сторон треугольника и инициализирует поля.
        public Triangle(double side1, double side2, double side3)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

        // Реализация метода Draw из интерфейса IDrawable.
        // Этот метод выводит информацию о треугольнике на консоль.
        public void Draw()
        {
            Console.WriteLine($"Рисуем треугольник со сторонами {side1}, {side2} и {side3}");
        }
    }
}
