using System;
using System.Collections;
using System.Collections.Generic;

namespace Тумаков_9лаб
{
    public class BankTransaction
    {
        public DateTime TransactionDateTime { get; }
        public decimal Amount { get; }

        public BankTransaction(decimal amount)
        {
            TransactionDateTime = DateTime.Now;
            Amount = amount;
        }
    }

    public class BankAccount1
    {
        private decimal balance;
        private Queue<BankTransaction> transactionQueue;
        public decimal Balance { get { return balance; } }
        public BankAccount1()
        {
            balance = 0;
            transactionQueue = new Queue<BankTransaction>();
        }

        public void Deposit(decimal amount)
        {
            balance += amount;
            BankTransaction transaction = new BankTransaction(amount);
            transactionQueue.Enqueue(transaction);
        }
        public void Withdraw(decimal amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
                BankTransaction transaction = new BankTransaction(-amount);
                transactionQueue.Enqueue(transaction);
            }
            else
            {
                throw new InvalidOperationException("Недостаточно средств");
            }
        }
        public IEnumerable history()
        {
            return transactionQueue.ToArray();
        }
    }
}
