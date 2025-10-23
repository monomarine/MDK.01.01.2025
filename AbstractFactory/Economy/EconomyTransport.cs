using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Economy
{
    internal class EconomyTransport : ITransport
    {
        public string Type => "развозка";

        public decimal GetTransportCost(double distance) => (decimal)(distance * 15);

        public TimeSpan GetTransportTime(double distance)
        {
            var hours = distance / 30; 
            return TimeSpan.FromHours(Math.Max(hours, 3));
        }
    }
}
