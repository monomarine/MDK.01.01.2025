using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal abstract class LoggerFactory
    {
        public abstract ILogger Createlogger(); //фабричный метод. логика инициализации лежит на потомках

        public void Log(string message)
        {
            var logger = Createlogger();
            logger.WrileLog(message);
        }
    }

    internal class FileLoggerFactory : LoggerFactory
    {
        public override ILogger Createlogger() //реализация фабричного метода для создания файлового логгера
        {
            return new FileLogger();
        }
    }

    internal class ConsoleLoggerFactory : LoggerFactory
    {
        public override ILogger Createlogger() //реализация фабричного метода для создания консольного логгера
        {
            return new ConsoleLogger();
        }
    }
}
