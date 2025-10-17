using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    //абстрактная фабрика создания объекта доставки
    internal interface IDeliveryFactory
    {
        ITransport GetTransport();
        IPacking GetPacking();
        ITracking GetTracking();
    }
}
