using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class EconomTracking : ITracking
    {
        public string GenerateTrackNumber()
        {
            return Guid.NewGuid().ToString();
        }

        public string GetTrackLinq(string trackNumber)
        {
            return $"https://economdelivery.ru/track/{trackNumber}";
        }

        public bool IsSMSnotification()
        {
            return false; 
        }
    }
}
