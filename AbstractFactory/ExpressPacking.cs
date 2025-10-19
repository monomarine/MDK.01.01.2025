using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class ExpressPacking : IPacking
    {
        public string Name { get; } = "тонна пупырки";

        public decimal GetPackCost()
        {
            return 5000m;
        }

        public bool IsEcological()
        {
            return false;
        }
    }
}
