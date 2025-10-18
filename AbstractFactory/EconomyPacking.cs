using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class EconomyPacking : IPacking
    {
        public string Name { get; } = "Картонная коробка (эконом)";

        public decimal GetPackCost()
        {
            return 100m;
        }

        public bool IsEcological()
        {
            return true;
        }
    }
}
