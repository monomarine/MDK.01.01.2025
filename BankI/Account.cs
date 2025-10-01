using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankI
{
    class Account : ISafe
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
            set
            {
                if (!IsLocked)
                    balance = value;
                else
                    throw new InvalidOperationException("Счет заблокирован");
            }
        }

        public void AddMoney(int amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Сумма должна быть положительной");

            if (IsLocked)
                throw new InvalidOperationException("Нельзя пополнить счет - счет заблокирован");

            balance += amount;
        }

        public int DecMoney(int amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Сумма должна быть положительной", nameof(amount));

            if (IsLocked)
                throw new InvalidOperationException("Нельзя снять деньги - счет заблокирован");

            if (balance < amount)
                throw new InvalidOperationException($"Недостаточно средств. На счету: {balance}");

            balance -= amount;
            return (int)balance;
        }

        public void Lock()
        {
            if (!isLocked) isLocked = true;
        }

        public void Unlock()
        {
            if (isLocked) isLocked = false;
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
                throw new InvalidOperationException("Нельзя снять деньги - счет заблокирован");

            if (amountd > 0 && balance >= amountd)
            {
                balance -= amountd;
                return balance;
            }
            else
            {
                throw new ArgumentException("Недостаточно средств");
            }
        }
        public double Deposit(double amounts)
        {
            if (amounts > 0)
            {
                balance += amounts;

            }
            return balance;
        }

        

        public void ShowInfo()
        {
            string status = IsLocked ? "Заблокирован" : "Открыт";
            Console.WriteLine($"Счет {Id}: {balance} руб. ({status})");
        }
    }
}
