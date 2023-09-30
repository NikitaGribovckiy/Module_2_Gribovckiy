using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Circle : Shape
    {
        private double radius;

        // Конструктор класса Circle, который принимает радиус круга.
        public Circle(double radius)
        {
            this.radius = radius;
        }

        // Переопределение метода Area() для круга.
        public override double Area()
        {
            return Math.PI * radius * radius; // Вычисление площади круга (π * r^2).
        }

        // Переопределение метода Perimeter() для круга.
        public override double Perimeter()
        {
            return 2 * Math.PI * radius; // Вычисление длины окружности круга (2 * π * r).
        }
    }
}
