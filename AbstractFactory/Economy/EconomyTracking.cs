using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Economy
{
    internal class EconomyTracking : ITracking
    {
        public string GenerateTrackNumber() => new Guid().ToString();

        public string GetTrackLinq(string trackNumber) => $"https://greatDelivery/track/{trackNumber}";

        public bool IsSMSnotification() => false;
    }
}
