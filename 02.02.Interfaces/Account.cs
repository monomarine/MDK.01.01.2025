using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace _02._02.Interfaces
{
    internal class Account : ISave
    {
        private int id;
        private static int id_now =1 ;
        private int balance = 0;
        private double annualInterestRate = 0;
        private DateTime dateCreated;
        private bool isLocked = true;
        public bool IsLocked => isLocked;

        public Account() 
        {
            this.id = id_now++;
            this.balance = 0;
            this.dateCreated = DateTime.Now;

        }

        public Account(int _id, int _balance)
        {
            this.id = _id;
            if (_id >= id_now)
            {
                id_now = _id + 1;
            }
            this.balance = _balance;
            this.dateCreated = DateTime.Now;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int Summ
        {
            get { return balance; }
            set { balance = value; }  
        }

        public double AnnualInterestRate
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
            return balance * (annualInterestRate / 100) / 12;
        }

        public int DecMoney(int amount)
        {
            if (amount > 0 && amount <= balance && !IsLocked)
            {
                balance -= amount;
                return balance;
            }
            else if (IsLocked) throw new ArgumentException("Нельзя снять деньги");
            else
                throw new ArgumentException("Недостаточно средств");
        }

        public void AddMoney(int amount)
        {
            if (amount > 0 && !IsLocked) 
                balance += amount;
            else if (IsLocked)
                throw new ArgumentException("Нельзя пополнить счет");
        }

        public void Lock()
        {
            if (!isLocked) isLocked = true;
        }

        public void Unlock()
        {
            if (isLocked) isLocked = false;
        }

        public override string ToString()
        {
            string state = IsLocked ? "заблокирован" : "разблокирован";
            return $"на счету {balance} рублей. счет {state}, id клиента {id}, врем создания клиента {DateCreated:dd.MM.yyyy HH:mm:ss}";
        }
    }
}
