using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class EconomPacking : IPacking
    {
        public string Name { get; } = "Целлофановая упаковка";

        public decimal GetPackCost()
        {
            return 250m;
        }

        public bool IsEcological()
        {
            return true;
        }
    }
}
