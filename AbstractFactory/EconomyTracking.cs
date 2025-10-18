using System;

namespace AbstractFactory
{
    internal class EconomyTracking : ITracking
    {
        public string GenerateTrackNumber()
        {
            return "ECON-" + Guid.NewGuid().ToString().Substring(0, 8);
        }

        public string GetTrackLinq(string trackNumber)
        {
            return $"http://economdelivery.com/track/{trackNumber}";
        }

        public bool IsSMSnotification()
        {
            return false; // без SMS
        }
    }
}
