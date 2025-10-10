using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._02.Interfaces
{
    internal class Save : ISave
    {
        private bool isLocked = true;
        private int summ = 0;
        public bool IsLocked => isLocked;

        public int Summ
        {
            get => summ;
            set => summ = value;
        }

        public void AddMoney(int amount)
        {
            if (amount > 0 && !IsLocked)
                Summ += amount;
            else if (IsLocked)
                throw new ArgumentException("Нельзя пополнить счет");
        }

        public int DecMoney(int amount)
        {
            if (Summ > amount && !IsLocked)
                return Summ -= amount;
            else if (IsLocked) throw new ArgumentException("Нельзя снять деньги");
            else
                throw new ArgumentException("Недостаточно средств");
        }

        public void Lock()
        {
            if(!isLocked) isLocked = true;
        }

        public void Unlock()
        {
            if(isLocked) isLocked = false;
        }

        public override string ToString()
        {
            string state = IsLocked ? "заблокирован" : "разблокирован";
            return $"на счету {summ} рублей. счет {state}";
        }
    }
}
