using System;

namespace _5
{
    class Program
    {
        static void Main()
        {
            TemperatureSensor sensor = new TemperatureSensor();
            Thermostat thermostat = new Thermostat();

            // Подписываем термостат на событие TemperatureChanged
            sensor.TemperatureChanged += thermostat.StartHeating;
            sensor.TemperatureChanged += thermostat.StopHeating;

            // Моделируем изменение температуры и генерацию событий
            sensor.CurrentTemperature = 18; // Температура слишком низкая, включаем отопление
            sensor.CurrentTemperature = 22; // Температура нормализовалась, выключаем отопление
        }
    }
}