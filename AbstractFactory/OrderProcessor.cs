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
        private double _distance;

        public OrderProcessor(IDeliveryFactory factory, double distance)
        {
            _tracking = factory.GetTracking();
            _packing = factory.GetPacking();
            _transport = factory.GetTransport();
            _trackNumber = _tracking.GenerateTrackNumber();
            _distance = distance;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"=====Информация по заказу======");
            sb.AppendLine($"Номер: {_trackNumber}");
            sb.AppendLine($"Ссылка для отслеживания: {_tracking.GetTrackLinq(_trackNumber)}");
            sb.AppendLine($"Цена упаковки: {_packing.GetPackCost()}");
            sb.AppendLine($"Цена транспортировки: {_transport.GetTransportCost(_distance)}");
            sb.AppendLine($"Время доставки: {_transport.GetTransportTime(_distance)}");
            return sb.ToString();
        }
    }
}
