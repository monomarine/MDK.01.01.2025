using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class ConsoleLogger : ILogger
    {
        public void WrileLog(string message)
        {
            Console.WriteLine(message);
        }
    }
}
