using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main()
        {
            // Создаем массив объектов, реализующих интерфейс IDrawable
            IDrawable[] shapes = new IDrawable[]
            {
                new Circle(5),
                new Rectangle(4, 6),
                new Triangle(3, 4, 5)
            };

            // Вызываем метод Draw() для каждого объекта
            foreach (IDrawable shape in shapes)
            {
                shape.Draw();
            }
        }
    }
}
