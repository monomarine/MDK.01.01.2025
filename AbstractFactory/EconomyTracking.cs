namespace AbstractFactory
{
    internal class EconomyTracking : ITracking
    {
        public string GenerateTrackNumber()
        {
            return "Эконом" + DateTime.Now.Ticks.ToString("X");
        }

        public string GetTrackLinq(string trackNumber)
        {
            return $"https://economDelivery/track/{trackNumber}";
        }

        public bool IsSMSnotification()
        {
            return false;
        }
    }
}