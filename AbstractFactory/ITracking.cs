using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    //абстракция сервиса отслеживания
    internal interface ITracking //абстракция отслеживания
    {
        string GenerateTrackNumber();
        string GetTrackLinq(string trackNumber);
        bool IsSMSnotification();
    }
    internal interface IPacking //абстракция упаковки
    {
        string Name { get; }
        decimal GetPackCost();
        bool IsEcological();
    }
    internal interface ITransport //абстракция пермещения
    {
        decimal GetTransportCost(double distance);
        string Type { get; }
        TimeSpan GetTransportTime(double distance);
    }
}
