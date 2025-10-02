using System;

namespace _02._02.Interfaces
{
    public class Account
    {
        public int Id { get; set; }
        public double Balance { get; private set; }
        public static double AnnualInterestRate { get; set; }
        public DateTime DateCreated { get; }

        public Account() : this(0, 0) { }

        public Account(int id, double balance)
        {
            Id = id;
            Balance = balance;
            DateCreated = DateTime.Now;
        }

        public double GetMonthlyInterest()
        {
            double monthlyRate = AnnualInterestRate / 12 / 100;
            return Balance * monthlyRate;
        }

        public void Deposit(double amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Пополнение должно быть положительным.");

            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Сумма снятия должна быть положительной.");

            if (amount > Balance)
                throw new InvalidOperationException("Недостаточно средств.");

            Balance -= amount;
        }

        public override string ToString()
        {
            return $"Счет №{Id}: баланс {Balance:F2} руб., создан {DateCreated}";
        }
    }
}
