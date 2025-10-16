using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class FileLogger : ILogger
    {
        private readonly string _lofFiliName = "log.txt";
        public void WrileLog(string message)
        {
            File.AppendAllText(_lofFiliName, message);
        }
    }
}
