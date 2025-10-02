using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._02.Interfaces
{
    internal class BankAccount : ISave
    {
        private bool _isLocked;

        private static int _id = 0;
        private int _id_this;
        private int _summ;
        private double _annualInterestState;
        private DateTime _dateCreated;

        public bool IsLocked { get => _isLocked; set => _isLocked = value; }

        public int Id { get => _id_this; set => _id_this = value; }
        public int Summ { get => _summ; set => _summ = value; }
        public double AnnualInterestState { get => _annualInterestState; set => _annualInterestState = value;}
        public DateTime DateCreated { get => _dateCreated; }
        public BankAccount()
        {
            _id++;
            Id = _id;
            Summ = 0;
            AnnualInterestState = 0;
            _dateCreated = DateTime.Now;
        }
        public BankAccount(int id, int summ, double annualInterestState)
        {
            Id = id;
            Summ = summ;
            AnnualInterestState = annualInterestState;
            _dateCreated = DateTime.Now;
        }

        public void DecMoney(int sum)
        {
            if (!IsLocked)
            {


                if (Summ >= sum) Summ -= sum;
                else Console.WriteLine("Недостаточно средств");
            }
            else Console.WriteLine("Счет заблокирован");
            }

        public void AddMoney(int sum) { if (!IsLocked) Summ += sum;
else Console.WriteLine("Счет заблокирован");
        }
        public double GetMonthlyInterest() { return AnnualInterestState / 1200 * Summ; }
        public void Unlock() { if (IsLocked) IsLocked = false; }
        public void Lock() { if (!IsLocked) IsLocked = true; }
        public override string ToString()
        {
            string s = IsLocked ? "заблокирован" : "разблокирован";
            return $"ID счета: {Id}\n" +
                $"Баланс: {Summ}\n" +
                $"Ежемесячный доход: {GetMonthlyInterest()}\n" +
                $"Дата создания: {DateOnly.FromDateTime(DateCreated)}\n" +
                $"Статус {s}\n";
        }
    }
}
