using System;

namespace _5
{
    internal class Thermostat
    {
        // Метод StartHeating, который будет вызываться при необходимости включения отопления.
        public void StartHeating(object sender, TemperatureChangedEventArgs e)
        {
            double temperature = e.NewTemperature;

            // Проверяем, если температура ниже 20°C, то включаем отопление.
            if (temperature < 20)
            {
                Console.WriteLine($"Температура слишком низкая ({temperature}°C). Включаем отопление.");
            }
        }

        // Метод StopHeating, который будет вызываться при необходимости выключения отопления.
        public void StopHeating(object sender, TemperatureChangedEventArgs e)
        {
            double temperature = e.NewTemperature;

            // Проверяем, если температура достигла или превысила 20°C, то выключаем отопление.
            if (temperature >= 20)
            {
                Console.WriteLine($"Температура нормализовалась ({temperature}°C). Выключаем отопление.");
            }
        }
    }
}
