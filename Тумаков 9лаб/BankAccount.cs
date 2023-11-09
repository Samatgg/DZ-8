using System.Collections.Generic;
using System;

namespace Тумаков_9лаб
{
    enum BankType
    {
        Сберегательный,
        Общий,
        Зарплатный,
    }

    internal class BankAccount
    {

        private static uint id_counter = 1;
        private uint id;
        private decimal balance;
        private BankType type;
        private Queue<BankTransaction> transactions = new Queue<BankTransaction>();
        private bool dispose = false;

        /// <summary>
        /// Получает айди (уникальный)
        /// </summary>
        public void MakeUniqeID()
        {
            id_counter++;
        }
        public BankAccount()
        {
            MakeUniqeID();
            id = id_counter;
        }
        /// <summary>
        /// Конструктор,создающий банк.счет
        /// </summary>
        /// <param name="type"></param>
        public BankAccount(BankType type)
        {
            MakeUniqeID();
            id = id_counter;
            this.type = type;
        }

        public BankAccount(decimal balance)
        {
            MakeUniqeID();
            id = id_counter;
            this.balance = balance;
        }

        public BankAccount(BankType type,decimal balance)
        {
            MakeUniqeID();
            id = id_counter;
            this.balance = balance;
            this.type = type;
        }


        /// <summary>
        /// Вносит деньги на счёт
        /// </summary>
        /// <param name="money"></param>
        public void DepositMoney(decimal money)
        {
            if (money > 0)
            {
                BankTransaction transaction = new BankTransaction(money);
                transactions.Enqueue(transaction);
                balance += money;
                Console.WriteLine($"Счёт пополнен на {money} рублей, текущий баланс {balance}\n");
            }
            else
            {
                Console.WriteLine("Сумма должна быть положительной\n");
            }
        }

        /// <summary>
        /// Снимает деньги со счёта
        /// </summary>
        /// <param name="money"></param>
        public void WithdrawMoney(decimal money)
        {
            if (money <= balance)
            {
                BankTransaction transaction = new BankTransaction(money);
                transactions.Enqueue(transaction);
                balance -= money;
                Console.WriteLine($"Со счёта снято {money} рублей, текущий баланс {balance}\n");
            }
            else
            {
                Console.WriteLine("На счёте недостаточно средств\n");
            }
        }

        public void Balance()
        {
            Console.WriteLine($"Ваш баланс {balance}\n");
        }

        /// <summary>
        /// Выводит информацию о счёте
        /// </summary>
        public void Print()
        {
            Console.WriteLine($"Номер вашего счёта: {id}\nБаланс: {balance}\nТип: {type}\n");
        }

        /// <summary>
        /// Переводит деньги на другой счёт
        /// </summary>
        /// <param name="account1"></param>
        /// <param name="money"></param>
        public void TransferMoney(BankAccount account1, decimal money)
        {
            if (balance < money)
            {
                Console.WriteLine("На счете недостаточно средств\n");
            }
            else
            {
                BankTransaction transaction = new BankTransaction(money);
                transactions.Enqueue(transaction);
                balance -= money;
                account1.balance += money;
                Console.WriteLine($"Вы перевели {money} рублей на счет {account1.id}, ваш баланс {balance}");
            }
        }

        public void Dispose()
        {
            if (!dispose)
            {
                foreach (BankTransaction trans in transactions)
                {     
                    
                }
                dispose = true;

                GC.SuppressFinalize(this);
            }
        }
    }
}
