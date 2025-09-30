using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02._02.Interfaces;

namespace Bank
{
    internal class Account : ISave
    {
        private int _id = 0;
        private static List<int> _usedIds = new List<int>();
        private int _summ = 0;
        private static double _annualInterestRate = 0;
        private DateTime _dateCreated;
        private bool _isLocked = true;


        public int Id => _id;
        public static double AnnualInterestRate
        {
            get => _annualInterestRate;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Процентная ставка не может быть отрицательной");
                _annualInterestRate = value;
            }
        }
        public DateTime DateCreated => _dateCreated;
        public bool IsLocked => _isLocked;
        public int Summ
        {
            get => _summ;
            set
            {
                if (value >= 0) _summ = value;
            }
        }

        public Account()
        {
            while (_usedIds.Contains(++_id)) ; //Чтобы не было повторяющихся id, проверяем, что id не используется
            _usedIds.Add(_id);
            _dateCreated = DateTime.Now;
        }

        public Account(int id, int initialBalance)
        {
            if (_usedIds.Contains(id))
                throw new ArgumentException("ID уже используется");

            _usedIds.Add(id);
            _id = id;
            _summ = initialBalance;
            _dateCreated = DateTime.Now;
        }

        public void AddMoney(int amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Сумма пополнения не может быть 0 или ниже 0");
            else if (_isLocked)
                throw new ArgumentException("Счет заблокирован, пополнить счет нельзя");
            else
                _summ += amount;
        }

        public int DecMoney(int amount)
        {
            if (amount <= 0 || _summ < amount)
                throw new ArgumentException("На баласе недостаточно средств или сумма введена не корректно");
            else if (_isLocked)
                throw new ArgumentException("Счет заблокирован, снять деньги нельзя");
            else
                return _summ -= amount;
        }

        public double GetMonthlyInterest()
        {
            return _summ * (_annualInterestRate / 100) / 12;
        }

        public override string ToString()
        {
            return $"Account ID: {_id}\nBalance: {_summ} rub\nLoked: {_isLocked}\nAnnual Interest Rate: {_annualInterestRate}%\nDate Created: {_dateCreated}";
        }

        public void Lock()
        {
            if (!_isLocked) _isLocked = true;
        }

        public void Unlock()
        {
            if (_isLocked) _isLocked = false;
        }
    }
}
