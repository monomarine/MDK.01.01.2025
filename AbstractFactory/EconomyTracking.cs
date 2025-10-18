using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class EconomyTracking : ITracking
    {
        public string GenerateTrackNumber()
        {
            return DateTime.Now.ToString().Substring(5);
        }

        public string GetTrackLinq(string trackNumber) 
        {
            return $"https://economyDelivery/track/{trackNumber}";
        }

        public bool IsSMSnotification()
        {
            return false;
        }
    }
}
