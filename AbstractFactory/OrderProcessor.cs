using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class OrderProcessor
    {
        private ITracking _tracking;
        private IPacking _packing;
        private ITransport _transport;

        public OrderProcessor(IDeliveryFactory factory)
        {
            _tracking = factory.GetTracking();
            _packing = factory.GetPacking();
            _transport = factory.GetTransport();
        }
    }
}
