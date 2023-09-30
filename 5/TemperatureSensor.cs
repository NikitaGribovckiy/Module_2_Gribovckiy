using System;

namespace _5
{
    internal class TemperatureSensor
    {
        // Приватное поле для хранения текущей температуры.
        private double currentTemperature;

        // Событие TemperatureChanged, которое будет вызываться при изменении температуры.
        public event EventHandler<TemperatureChangedEventArgs> TemperatureChanged;

        // Свойство CurrentTemperature для получения и установки текущей температуры.
        public double CurrentTemperature
        {
            get { return currentTemperature; }
            set
            {
                // Проверяем, если новое значение температуры отличается от текущего,
                // то обновляем текущую температуру и генерируем событие TemperatureChanged.
                if (currentTemperature != value)
                {
                    currentTemperature = value;

                    // Генерируем событие TemperatureChanged при изменении температуры.
                    OnTemperatureChanged(new TemperatureChangedEventArgs(value));
                }
            }
        }

        // Метод, вызывающий событие TemperatureChanged.
        protected virtual void OnTemperatureChanged(TemperatureChangedEventArgs e)
        {
            // Проверяем, что событие имеет подписчиков, и вызываем его.
            TemperatureChanged?.Invoke(this, e);
        }
    }
}
