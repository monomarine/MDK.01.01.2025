using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Economy
{
    internal class EconomyPacking : IPacking
    {
        public string Name => "без наполнителя";

        public decimal GetPackCost() => 1000m;

        public bool IsEcological() => false;
    }
}
