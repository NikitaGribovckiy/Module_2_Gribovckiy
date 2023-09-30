using System;
using _6; // Подразумевается, что _6 - это пространство имен, где определен класс BankAccount.

class Program
{
    static void Main()
    {
        // Создаем объекты класса BankAccount
        BankAccount account1 = new BankAccount("12345", "Иван Иванов", 1000.0);
        BankAccount account2 = new BankAccount("54321", "Петр Петров", 500.0);

        // Выводим информацию о счетах
        Console.WriteLine($"Счет {account1.GetAccountNumber()} принадлежит {account1.GetOwner()} и имеет баланс {account1.GetBalance()} рублей.");
        Console.WriteLine($"Счет {account2.GetAccountNumber()} принадлежит {account2.GetOwner()} и имеет баланс {account2.GetBalance()} рублей.");

        // Пополняем и снимаем средства со счетов
        account1.Deposit(500.0);
        account2.Withdraw(200.0);

        // Выводим обновленную информацию о счетах
        Console.WriteLine($"Новый баланс счета {account1.GetAccountNumber()}: {account1.GetBalance()} рублей.");
        Console.WriteLine($"Новый баланс счета {account2.GetAccountNumber()}: {account2.GetBalance()} рублей.");
    }
}
