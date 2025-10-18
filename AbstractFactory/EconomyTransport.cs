using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class EconomyTransport : ITransport
    {
        public string Type { get; } = "Велосипед";

        public decimal GetTransportCost(double distance)
        {
            return (decimal)(distance * 25); 
        }

        public TimeSpan GetTransportTime(double distance)
        {
            var hours = distance / 70; 
            return TimeSpan.FromHours(Math.Max(hours, 24)); 
        }
    }
}
