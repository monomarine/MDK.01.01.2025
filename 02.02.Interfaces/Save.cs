using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._02.Interfaces
{
    internal class Save : ISave
    {
        public int Summ { get; set; }
        public bool IsLocked { get; private set; }

        public Save()
        {
            Summ = 0;
            IsLocked = true;
        }

        public void AddMoney(int amount)
        {
            if (IsLocked)
                throw new InvalidOperationException("Счет заблокирован! Нельзя пополнить.");

            if (amount <= 0)
                throw new ArgumentException("Сумма должна быть положительной!");

            Summ += amount;
        }

        public int DecMoney(int amount)
        {
            if (IsLocked)
                throw new InvalidOperationException("Счет заблокирован! Нельзя снять деньги.");

            if (amount <= 0)
                throw new ArgumentException("Сумма должна быть положительной!");

            if (amount > Summ)
                throw new InvalidOperationException("Недостаточно средств!");

            Summ -= amount;
            return amount;
        }

        public void Lock()
        {
            IsLocked = true;
        }

        public void Unlock()
        {
            IsLocked = false;
        }

        public override string ToString()
        {
            return $"Состояние счета: {Summ} руб. (Заблокирован: {IsLocked})";
        }
    }
}
