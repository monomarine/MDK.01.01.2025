using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class EconomyPacking : IPacking
    {
        public string Name { get; } = "картон";

        public decimal GetPackCost()
        {
            return 2000m;
        }

        public bool IsEcological()
        {
            return true; 
        }
    }
}
