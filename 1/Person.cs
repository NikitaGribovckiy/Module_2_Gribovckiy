using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Person
    {
        // Приватные поля для хранения информации о человеке
        private string name;    // Имя
        private int age;        // Возраст
        private string address; // Адрес

        // Методы для установки значений полей

        // Метод для установки имени
        public void SetName(string name)
        {
            this.name = name;
        }

        // Метод для получения имени
        public string GetName()
        {
            return name;
        }

        // Метод для установки возраста
        public void SetAge(int age)
        {
            this.age = age;
        }

        // Метод для получения возраста
        public int GetAge()
        {
            return age;
        }

        // Метод для установки адреса
        public void SetAddress(string address)
        {
            this.address = address;
        }

        // Метод для получения адреса
        public string GetAddress()
        {
            return address;
        }
    }
}
