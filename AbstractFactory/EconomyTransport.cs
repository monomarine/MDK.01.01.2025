using System;

namespace AbstractFactory
{
    internal class EconomyTransport : ITransport
    {
        public string Type { get; } = "Грузовик";

        public decimal GetTransportCost(double distance)
        {
            return (decimal)(distance * 20); // дешевле, чем вертолёт
        }

        public TimeSpan GetTransportTime(double distance)
        {
            var hours = distance / 60; // медленнее (60 км/ч)
            return TimeSpan.FromHours(Math.Max(hours, 1));
        }
    }
}
