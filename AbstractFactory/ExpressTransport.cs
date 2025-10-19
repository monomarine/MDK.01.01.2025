using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class ExpressTransport : ITransport
    {
        public string Type { get; } = "Вертолет";

        public decimal GetTransportCost(double distance)
        {
            return (decimal)(distance * 100);
        }

        public TimeSpan GetTransportTime(double distance)
        {
            var hours = distance / 200; //200 км/ч
            return TimeSpan.FromHours(Math.Max(hours, 1));
        }
    }
}
