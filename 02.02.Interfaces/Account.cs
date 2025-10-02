using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._02.Interfaces
{
    internal class Account : ISave
    {
        private bool isLocked = true;
        private int balance = 0;

        public string AccountNumber { get; }
        public bool IsLocked => isLocked;

        public int Summ
        {
            get => balance;
            set => balance = value;
        }

        public Account(string accountNumber)
        {
            AccountNumber = accountNumber;
        }

        public void AddMoney(int amount)
        {
            if (IsLocked)
                throw new InvalidOperationException("Счет заблокирован. Пополнение невозможно.");

            if (amount <= 0)
                throw new ArgumentException("Сумма должна быть больше нуля.");

            balance += amount;
        }

        public int DecMoney(int amount)
        {
            if (IsLocked)
                throw new InvalidOperationException("Счет заблокирован. Снятие невозможно.");

            if (amount <= 0)
                throw new ArgumentException("Сумма должна быть больше нуля.");

            if (balance < amount)
                throw new InvalidOperationException("Недостаточно средств на счете.");

            return balance -= amount;
        }

        public void Lock() => isLocked = true;

        public void Unlock() => isLocked = false;

        public override string ToString()
        {
            string state = IsLocked ? "заблокирован" : "разблокирован";
            return $"Счет №{AccountNumber}: баланс {balance} руб., статус: {state}.";
        }
    }


}