using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class ExpressTracking : ITracking
    {
        public string GenerateTrackNumber()
        {
            return new Guid().ToString();
        }

        public string GetTrackLinq(string trackNumber)
        {
            return $"https://greatDelivery/track/{trackNumber}";
        }

        public bool IsSMSnotification()
        {
            return true;
        }
    }
}
