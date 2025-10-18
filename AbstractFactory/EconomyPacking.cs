using System;

namespace AbstractFactory
{
    internal class EconomyPacking : IPacking
    {
        public string Name { get; } = "картонная коробка";

        public decimal GetPackCost()
        {
            return 500m; // дешёвая упаковка
        }

        public bool IsEcological()
        {
            return true; // экологичная упаковка
        }
    }
}
