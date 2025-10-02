using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._02.Interfaces
{
    public class Account : ISave
    {
        private int id;
        private double balance;
        private double annualInterestRate;
        private DateTime dateCreated;
        private bool isLocked;
        private int summ;

        public Account()
        {
            id = 0;
            balance = 0;
            annualInterestRate = 0;
            dateCreated = DateTime.Now;
            isLocked = false;
            summ = 0;
        }

        public Account(int id, double balance)
        {
            this.id = id;
            this.balance = balance;
            annualInterestRate = 0;
            dateCreated = DateTime.Now;
            isLocked = false;
            summ = (int)balance;
        }

        public int Id
        {
            get { return id; }
            set
            {
                if (!IsLocked) id = value;
                else throw new InvalidOperationException("Счет заблокирован");
            }
        }

        public double Balance
        {
            get { return balance; }
            set
            {
                if (!IsLocked)
                {
                    balance = value;
                    summ = (int)balance;
                }
                else throw new InvalidOperationException("Счет заблокирован");
            }
        }

        public double AnnualInterestRate
        {
            get { return annualInterestRate; }
            set
            {
                if (!IsLocked) annualInterestRate = value;
                else throw new InvalidOperationException("Счет заблокирован");
            }
        }
        public DateTime DateCreated
        {
            get { return dateCreated; }
        }

        public bool IsLocked
        {
            get { return isLocked; }
        }

        public int Summ
        {
            get { return summ; }
            set
            {
                if (!IsLocked)
                {
                    summ = value;
                    balance = summ;
                }
                else throw new InvalidOperationException("Счет заблокирован");
            }
        }
        public double GetMonthlyInterest()
        {
            if (IsLocked)
                throw new InvalidOperationException("Счет заблокирован");

            double monthlyInterestRate = annualInterestRate / 12 / 100;
            return balance * monthlyInterestRate;
        }

        public void Withdraw(double amount)
        {
            if (IsLocked)
                throw new InvalidOperationException("Счет заблокирован");

            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                summ = (int)balance;
            }
            else
            {
                throw new ArgumentException("Недостаточно средств на счете или неверная сумма");
            }
        }

        public void Deposit(double amount)
        {
            if (IsLocked)
                throw new InvalidOperationException("Счет заблокирован");

            if (amount > 0)
            {
                balance += amount;
                summ = (int)balance;
            }
            else
            {
                throw new ArgumentException("Сумма пополнения должна быть положительной");
            }
        }

        public void AddMoney(int amount)
        {
            if (IsLocked)
                throw new InvalidOperationException("Счет заблокирован");

            if (amount > 0)
            {
                summ += amount;
                balance = summ;
            }
            else
            {
                throw new ArgumentException("Сумма пополнения должна быть положительной");
            }
        }

        public int DecMoney(int amount)
        {
            if (IsLocked)
                throw new InvalidOperationException("Счет заблокирован");

            if (amount > 0 && amount <= summ)
            {
                summ -= amount;
                balance = summ;
                return amount;
            }
            return 0;
        }
        public void Lock()
        {
            isLocked = true;
        }

        public void Unlock()
        {
            isLocked = false;
        }
    }
}
