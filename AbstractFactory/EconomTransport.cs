using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class EconomTransport : ITransport
    {
        public string Type { get; } = "Велосипед";

        public decimal GetTransportCost(double distance)
        {
            return (decimal)(distance * 15);
        }

        public TimeSpan GetTransportTime(double distance)
        {
            var hours = distance / 15; //15 км/ч
            return TimeSpan.FromHours(Math.Max(hours, 1));
        }
    }
}
