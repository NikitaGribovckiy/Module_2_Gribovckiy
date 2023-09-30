using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Rectangle : Shape
    {
        private double width;
        private double height;

        // Конструктор класса Rectangle, который принимает ширину и высоту прямоугольника.
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        // Переопределение метода Area() для прямоугольника.
        public override double Area()
        {
            return width * height; // Вычисление площади прямоугольника (ширина * высота).
        }

        // Переопределение метода Perimeter() для прямоугольника.
        public override double Perimeter()
        {
            return 2 * (width + height); // Вычисление периметра прямоугольника (2 * (ширина + высота)).
        }
    }
}
