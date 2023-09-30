using System;

namespace _6
{
    class BankAccount
    {
        // Приватные поля класса
        private string accountNumber;
        private string owner;
        private double balance;

        // Конструктор класса, инициализирующий поля при создании объекта
        public BankAccount(string accountNumber, string owner, double balance)
        {
            this.accountNumber = accountNumber;
            this.owner = owner;
            this.balance = balance;
        }

        // Метод для получения номера счета
        public string GetAccountNumber()
        {
            return accountNumber;
        }

        // Метод для установки номера счета
        public void SetAccountNumber(string accountNumber)
        {
            this.accountNumber = accountNumber;
        }

        // Метод для получения владельца счета
        public string GetOwner()
        {
            return owner;
        }

        // Метод для установки владельца счета
        public void SetOwner(string owner)
        {
            this.owner = owner;
        }

        // Метод для получения баланса счета
        public double GetBalance()
        {
            return balance;
        }

        // Метод для пополнения счета
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Пополнение на {amount} рублей успешно. Новый баланс: {balance} рублей.");
            }
            else
            {
                Console.WriteLine("Некорректная сумма для пополнения.");
            }
        }

        // Метод для снятия средств со счета
        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Снятие {amount} рублей успешно. Новый баланс: {balance} рублей.");
            }
            else
            {
                Console.WriteLine("Некорректная сумма для снятия или недостаточно средств.");
            }
        }
    }
}
