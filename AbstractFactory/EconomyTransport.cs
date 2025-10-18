using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class EconomyTransport : ITransport
    {
        public string Type { get; } = "Грузовик (эконом)";

        public decimal GetTransportCost(double distance)
        {
            return (decimal)(distance * 10);
        }

        public TimeSpan GetTransportTime(double distance)
        {
            var hours = distance / 60.0;
            return TimeSpan.FromHours(Math.Max(hours, 1));
        }
    }
}
