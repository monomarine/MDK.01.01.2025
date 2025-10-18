using System;

namespace AbstractFactory
{
    internal class EconomyDeliveryFactory : IDeliveryFactory
    {
        public IPacking GetPacking() => new EconomyPacking();

        public ITracking GetTracking() => new EconomyTracking();

        public ITransport GetTransport() => new EconomyTransport();
    }
}
