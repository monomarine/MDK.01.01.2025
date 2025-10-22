using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class EconomPacking : IPacking
    {
        public string Name { get; } = "пластиковый пакет";

        public decimal GetPackCost()
        {
            return 20m;
        }

        public bool IsEcological()
        {
            return false;
        }
    }
}
