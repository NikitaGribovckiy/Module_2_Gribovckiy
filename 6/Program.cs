using System;
using System.Collections.Generic;
using _6; // Подразумевается, что _6 - это пространство имен, где определен класс BankAccount.

class Program
{
    static void Main()
    {
        List<BankAccount> accounts = new List<BankAccount>();

        while (true)
        {
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1. Создать новый счет");
            Console.WriteLine("2. Показать информацию о счетах");
            Console.WriteLine("3. Пополнить счет");
            Console.WriteLine("4. Снять средства со счета");
            Console.WriteLine("5. Выход");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    // Создание нового счета
                    Console.Write("Введите номер счета: ");
                    string accountNumber = Console.ReadLine();
                    Console.Write("Введите имя владельца счета: ");
                    string owner = Console.ReadLine();
                    Console.Write("Введите начальный баланс счета: ");
                    double balance;
                    if (!double.TryParse(Console.ReadLine(), out balance))
                    {
                        Console.WriteLine("Некорректный ввод для начального баланса счета.");
                        break;
                    }

                    BankAccount newAccount = new BankAccount(accountNumber, owner, balance);
                    accounts.Add(newAccount);
                    Console.WriteLine("Новый счет создан успешно.");
                    break;

                case "2":
                    // Вывод информации о всех счетах
                    Console.WriteLine("Информация о счетах:");
                    foreach (var account in accounts)
                    {
                        Console.WriteLine($"Счет {account.GetAccountNumber()} принадлежит {account.GetOwner()} и имеет баланс {account.GetBalance()} рублей.");
                    }
                    break;

                case "3":
                    // Пополнение счета
                    Console.Write("Введите номер счета для пополнения: ");
                    string depositAccountNumber = Console.ReadLine();
                    Console.Write("Введите сумму для пополнения: ");
                    double depositAmount;
                    if (double.TryParse(Console.ReadLine(), out depositAmount))
                    {
                        // Найти счет с указанным номером и выполнить операцию пополнения
                        BankAccount depositAccount = accounts.Find(account => account.GetAccountNumber() == depositAccountNumber);
                        if (depositAccount != null)
                        {
                            depositAccount.Deposit(depositAmount);
                        }
                        else
                        {
                            Console.WriteLine("Счет с указанным номером не найден.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Некорректная сумма для пополнения.");
                    }
                    break;

                case "4":
                    // Снятие средств
                    Console.Write("Введите номер счета для снятия средств: ");
                    string withdrawAccountNumber = Console.ReadLine();
                    Console.Write("Введите сумму для снятия: ");
                    double withdrawAmount;
                    if (double.TryParse(Console.ReadLine(), out withdrawAmount))
                    {
                        // Найти счет с указанным номером и выполнить операцию снятия
                        BankAccount withdrawAccount = accounts.Find(account => account.GetAccountNumber() == withdrawAccountNumber);
                        if (withdrawAccount != null)
                        {
                            withdrawAccount.Withdraw(withdrawAmount);
                        }
                        else
                        {
                            Console.WriteLine("Счет с указанным номером не найден.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Некорректная сумма для снятия.");
                    }
                    break;

                case "5":
                    // Выход из программы
                    Console.WriteLine("Выход из программы.");
                    return;

                default:
                    Console.WriteLine("Некорректный выбор. Пожалуйста, выберите действие из списка.");
                    break;
            }
        }
    }
}
