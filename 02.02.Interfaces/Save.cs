using System;

namespace _02._02.Interfaces
{
    internal class Save : IPurse
    {
        public int Summ { get; private set; }
        public bool IsLocked { get; private set; }

        public Save()
        {
            Summ = 0;
            IsLocked = true;
        }

        public void AddMoney(int amount)
        {
            if (IsLocked)
                throw new InvalidOperationException("Счет заблокирован. Пополнение невозможно.");

            if (amount <= 0)
                throw new ArgumentException("Сумма пополнения должна быть больше нуля.");

            Summ += amount;
        }

        public int DecMoney(int amount)
        {
            if (IsLocked)
                throw new InvalidOperationException("Счет заблокирован. Снятие невозможно.");

            if (amount <= 0)
                throw new ArgumentException("Сумма снятия должна быть больше нуля.");

            if (amount > Summ)
                throw new InvalidOperationException("Недостаточно средств на счете.");

            Summ -= amount;
            return amount;
        }

        public void Lock() => IsLocked = true;
        public void Unlock() => IsLocked = false;

        // явная реализация интерфейса
        int IPurse.Summ
        {
            get => Summ;
            set => Summ = value;
        }

        public override string ToString()
        {
            return $"Баланс: {Summ} руб. | {(IsLocked ? "Заблокирован" : "Активен")}";
        }
    }
}
