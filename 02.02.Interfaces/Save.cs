using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._02.Interfaces
{
    internal class Account : ISave
    {
        internal int Id { get; set; }
        internal double balance { get; set; }
        internal double annualInterestRate { get; set; }
        internal DateTime dateCreated { get; }

        private bool isLocked = false;

        public bool IsLocked => isLocked;

        public int Summ
        {
            get => (int)balance;
            set => balance = value;
        }

        public Account()
        {
            Id = 0;
            balance = 0;
            annualInterestRate = 0;
            dateCreated = DateTime.Now;
        }

        public Account(int Id, double balance)
        {
            this.Id = Id;
            this.balance = balance;
            dateCreated = DateTime.Now;
        }

        public void GetMonthlyInterest()
        {
            double MonthlyProcent = 0;
            double MonthlyProcentS = 0;
            MonthlyProcentS = (annualInterestRate / 12) / 100;
            MonthlyProcent = balance * MonthlyProcentS;
        }

        public double WithDraw(double amountd)
        {
            if (IsLocked)
                throw new ArgumentException("Счет заблокирован. Нельзя снять деньги");

            if (amountd > 0 && balance >= amountd)
            {
                balance -= amountd;
                return balance;
            }
            else
            {
                return 0;
            }
        }

        public double Deposit(double amounts)
        {
            if (IsLocked)
                throw new ArgumentException("Счет заблокирован. Нельзя пополнить счет");

            if (amounts > 0)
            {
                balance += amounts;
            }
            return balance;
        }

        public void AddMoney(int amount)
        {
            if (IsLocked)
                throw new ArgumentException("Счет заблокирован. Нельзя пополнить счет");

            if (amount > 0)
                balance += amount;
        }

        public int DecMoney(int amount)
        {
            if (IsLocked)
                throw new ArgumentException("Счет заблокирован. Нельзя снять деньги");

            if (amount > 0 && balance >= amount)
            {
                balance -= amount;
                return amount;
            }
            else
            {
                throw new ArgumentException("Недостаточно средств");
            }
        }
        public void Lock()
        {
            if (!isLocked)
                isLocked = true;
        }

        public void Unlock()
        {
            if (isLocked)
                isLocked = false;
        }
        public override string ToString()
        {
            string state = IsLocked ? "заблокирован" : "разблокирован";
            return $"Счет №{Id}: на счету {balance} рублей. Счет {state}. Дата создания: {dateCreated:dd.MM.yyyy}";
        }
    }
}
