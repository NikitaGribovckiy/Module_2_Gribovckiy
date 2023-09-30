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

            while (true)
            {
                Console.WriteLine("Введите текущую температуру (в градусах Цельсия) или 'exit' для выхода:");
                string input = Console.ReadLine();

                if (input.ToLower() == "exit")
                {
                    Console.WriteLine("Программа завершена.");
                    break;
                }

                if (double.TryParse(input, out double temperature))
                {
                    sensor.CurrentTemperature = temperature;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод. Пожалуйста, введите числовое значение температуры.");
                }
            }
        }
    }
}
