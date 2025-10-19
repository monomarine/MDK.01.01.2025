using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class EconomTransport : ITransport
    {
        public string Type { get; } = "Грузовик";

        public decimal GetTransportCost(double distance)
        {
            return (decimal)(distance * 20);
        }

        public TimeSpan GetTransportTime(double distance)
        {
            var hours = distance / 60;
            return TimeSpan.FromHours(Math.Max(hours, 5));
        }
    }
}
