using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class ExpressDeliveryFactory : IDeliveryFactory
    {
        public IPacking GetPacking() => new ExpressPacking();

        public ITracking GetTracking() => new ExpressTracking();

        public ITransport GetTransport() => new ExpressTransport();
    }
}
