namespace FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LoggerFactory factory = new FileLoggerFactory();

            factory.Log("testmessage");
        }
    }
}
