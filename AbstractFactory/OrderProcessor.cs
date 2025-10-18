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
        private string _trackNumber;

        public OrderProcessor(IDeliveryFactory factory)
        {
            _tracking = factory.GetTracking();
            _packing = factory.GetPacking();
            _transport = factory.GetTransport();
            _trackNumber = _tracking.GenerateTrackNumber();
        }

        public string OrderProcess(double distance)
        {
            var transportCost = _transport.GetTransportCost(distance);
            var deliveryTime = _transport.GetTransportTime(distance);
            var pakingCostr = _packing.GetPackCost();

            string result = $"\n--------Информация по заказу----------" +
                $"\nстоимость транспортировки: {transportCost}" +
                $"\nстоимость упаковки: {pakingCostr}" +
                $"\nтип транспорта {_transport.Type}" +
                $"\nвид упаковки {_packing.Name}" +
                $"\nпримерное время доставки {deliveryTime}" +
                $"\n-----------------" +
                $"\nобщая стоимость {transportCost + pakingCostr}" +
                $"\nотследить: {_tracking.GetTrackLinq(_trackNumber)}";

            return result;
        }
    }
}
