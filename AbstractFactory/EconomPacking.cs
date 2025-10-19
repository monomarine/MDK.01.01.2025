using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class EconomPacking : IPacking
    {
        public string Name { get; } = "пупырчатая пленка";

        public decimal GetPackCost()
        {
            return 500m;
        }

        public bool IsEcological()
        {
            return false;
        }
    }
}
