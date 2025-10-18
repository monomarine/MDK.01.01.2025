using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class EconomyTransport : ITransport
    {
        public string Type { get; } = "фура";

        public decimal GetTransportCost(double distance)
        {
            return (decimal)(distance * 50);
        }

        public TimeSpan GetTransportTime(double distance)
        {
            var hours = distance / 100;
            return TimeSpan.FromHours(Math.Max(hours, 1));
        }
    }
}
