using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class EconomyPacking : IPacking
    {
        public string Name { get; } = "картонная коробка";

        public decimal GetPackCost()
        {
            return 500m;
        }

        public bool IsEcological()
        {
            return true;
        }
    }
}
