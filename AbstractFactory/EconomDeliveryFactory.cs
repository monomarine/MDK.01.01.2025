using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class EconomDeliveryFactory : IDeliveryFactory
    {
        public IPacking GetPacking() => new EconomPacking();

        public ITracking GetTracking() => new EconomTracking();

        public ITransport GetTransport() => new EconomTransport();
    }
}
