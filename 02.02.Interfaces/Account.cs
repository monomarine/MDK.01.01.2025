using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._02.Interfaces
{
	internal class Account: ISave
	{
		private static double annualInterestRate = 0;
		private static int instances = 0;

		private int id;
		private double balance;
		private DateTime dateCreated;

		private bool isLocked = true;

		public DateTime DateCreated { get => dateCreated; }
		public int Id { get => id; set => id = value; }
		public static double AnnualInterestRate { get => annualInterestRate; set => annualInterestRate = value; }

		public bool IsLocked => isLocked;

		public int Summ { get => (int)Math.Round(balance); set => balance = value; }

		public Account()
		{
			id = ++instances;
			balance = 0;
			dateCreated = DateTime.Now;
		}

		public Account(int id, double balance)
		{
			this.id = id;
			this.balance = balance;
			dateCreated = DateTime.Now;
		}

		public double GetMonthlyInterest()
		{
			double monthlyInterestRate = annualInterestRate / 12;
			return balance * monthlyInterestRate;
		}

		public void Lock()
		{
			if (!isLocked) isLocked = true;
		}

		public void Unlock()
		{
			if (isLocked) isLocked = false;
		}

		public void AddMoney(int amount)
		{
			if (amount >= 0)
				balance += amount;
			else
				throw new ArgumentException("Нельзя внести отрицательную сумму");
		}

		public int DecMoney(int amount)
		{
			if (amount < 0)
				throw new ArgumentException("Нельзя снять отрицательную сумму");
			if (amount <= balance)
			{
				balance -= amount;
				return Summ;
			}
			return Summ;
		}

		public override string ToString()
		{
			string lockedText = IsLocked ? "заблокирован" : "разблокирован";
			return $"На счету {balance} рублей, счет {lockedText}";
		}


	}
}
