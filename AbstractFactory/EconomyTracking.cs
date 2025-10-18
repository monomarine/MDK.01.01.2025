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
            return Guid.NewGuid().ToString();
        }

        public string GetTrackLinq(string trackNumber)
        {
            return $"{trackNumber}";
        }

        public bool IsSMSnotification()
        {
            return false;
        }
    }
}
