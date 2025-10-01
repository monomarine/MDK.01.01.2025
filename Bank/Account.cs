using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using _02._02.Interfaces;

namespace Bank
{
    internal class Account : ISave
    {
        private int _id { get; }
        private int _summ { get; set; } = 0;
        private static double _annualInterestRate { get; set; }
        private DateTime _dateCreated { get; }
        private static int _count = 0;
        private static List<int> _ids = new List<int>();
        private bool _isLocked = true;

        public int Id
        {
            get { return _id; }
        }

        public static double AnnualInterestRate
        {
            get { return _annualInterestRate; }
            set { _annualInterestRate = value; }
        }

        public DateTime DateCreated
        {
            get { return _dateCreated; }
        }

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
            while (_ids.Contains(_count))
            {
                _count++;
            }
            _id = _count;
            _ids.Add(_id);
            _dateCreated = DateTime.Now;
        }


        public Account(int id, int balance)
        {
            if (!_ids.Contains(id))
            {

                _id = id;
                _ids.Add(_id);
                _summ = balance;
                _dateCreated = DateTime.Now;
                Console.WriteLine("Успешное создание");

            }
            else
            {
                Console.WriteLine("Ошибка, указанный счет уже имеется!");
            }
        }

        public double GetMonthlyInterest()
        {
            double monthlyInsertRate = _annualInterestRate / 12;
            double monthlyProcent = _summ * monthlyInsertRate / 100;
            return monthlyProcent;
        }

        public void AddMoney(int ammount)
        {
            if (_isLocked)
                throw new InvalidOperationException("Оперции по счету заблокированы");
            else if (0 >= ammount)
                throw new AggregateException("Сумма пополнения не может быть отрицательной или равной нулю");
            else
                _summ += ammount;
        }

        public int DecMoney(int ammount)
        {
            if (_isLocked)
                throw new InvalidOperationException("Операции по счету заблокированы");
            else if (0 >= ammount)
                throw new AggregateException("Сумма снятия не может быть отрицательной или равной нулю");
            else if (_summ >= ammount)
                return _summ -= ammount;
            return -1;
        }

        public override string ToString()
        {
            string result = $"id => {_id} \nBalance => {_summ} \nAnnualInterestRate => {AnnualInterestRate} \nDateCreated => {_dateCreated} \nЗаблокирован => {_isLocked}"; 
            Console.WriteLine("================");
            Console.WriteLine(result);
            Console.WriteLine("================");
            return result;
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
