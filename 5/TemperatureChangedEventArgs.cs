using System;

namespace _5
{
    internal class TemperatureChangedEventArgs : EventArgs
    {
        // Свойство NewTemperature, которое предоставляет новое значение температуры.
        public double NewTemperature { get; }

        // Конструктор класса, который принимает новое значение температуры и инициализирует свойство.
        public TemperatureChangedEventArgs(double newTemperature)
        {
            NewTemperature = newTemperature;
        }
    }
}
