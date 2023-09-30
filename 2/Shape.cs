using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Shape
    {
        // Виртуальный метод для вычисления площади фигуры.
        // По умолчанию возвращает 0.
        public virtual double Area()
        {
            return 0;
        }

        // Виртуальный метод для вычисления периметра фигуры.
        // По умолчанию возвращает 0.
        public virtual double Perimeter()
        {
            return 0;
        }
    }
}
