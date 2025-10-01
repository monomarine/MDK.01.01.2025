using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._02.Interfaces
{
    public class Account
    {
        private int id = 0;
        private double balance = 0;
        private static double annualInterestRate = 0;
        private readonly DateTime dateCreated;

        public Account()
        {
            dateCreated = DateTime.Now;
        }

        public Account(int id, double balance)
        {
            this.id = id;
            this.balance = balance;
            dateCreated = DateTime.Now;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public static double AnnualInterestRate
        {
            get { return annualInterestRate; }
            set { annualInterestRate = value; }
        }

        public DateTime DateCreated
        {
            get { return dateCreated; }
        }

        public double GetMonthlyInterest()
        {
            double monthlyInterestRate = annualInterestRate / 12 / 100;
            return balance * monthlyInterestRate;
        }

        public void Withdraw(double amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
            }
            else
            {
                throw new InvalidOperationException("Недостаточно средств на счете.");
            }
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
            }
            else
            {
                throw new ArgumentException("Сумма пополнения должна быть положительной.");
            }
        }
    }
}