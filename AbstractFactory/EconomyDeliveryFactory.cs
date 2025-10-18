using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class EconomyDeliveryFactory : IDeliveryFactory
    {
        public IPacking GetPacking() => new EconomyPacking();

        public ITracking GetTracking() => new EconomyTracking();

        public ITransport GetTransport() => new EconomyTransport();
    }
}
