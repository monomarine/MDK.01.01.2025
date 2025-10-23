using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Economy
{
    internal class EconomyDeliveryFactory : IDeliveryFactory
    {
        public ITransport GetTransport() => new EconomyTransport();

        public IPacking GetPacking() => new EconomyPacking();

        public ITracking GetTracking() => new EconomyTracking();
    }
}
