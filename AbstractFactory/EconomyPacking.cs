namespace AbstractFactory
{
    internal class EconomyPacking : IPacking
    {
        public string Name { get; } = "Картонная коробка";

        public decimal GetPackCost()
        {
            return 500m; 
        }

        public bool IsEcological()
        {
            return true; 
        }
    }
}