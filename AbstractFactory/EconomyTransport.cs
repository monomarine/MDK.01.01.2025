namespace AbstractFactory
{
    internal class EconomyTransport : ITransport
    {
        public string Type { get; } = "Газель";

        public decimal GetTransportCost(double distance)
        {
            return (decimal)(distance * 25); 
        }

        public TimeSpan GetTransportTime(double distance)
        {
            var hours = distance / 80; 
            return TimeSpan.FromHours(Math.Max(hours, 24)); 
        }
    }
}