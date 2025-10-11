using System;
using System.Collections.Generic;

namespace _02._05_EventsWPF
{
    public class LoggerService
    {
        private readonly List<ILogger> _loggers;

        public LoggerService()
        {
            _loggers = new List<ILogger>();
        }

        public void AddLogger(ILogger logger)
        {
            _loggers.Add(logger);
        }

        public void Log(string message)
        {
            foreach (var logger in _loggers)
            {
                logger.Log(message);
            }
        }

        public void LogError(string message)
        {
            foreach (var logger in _loggers)
            {
                logger.LogError(message);
            }
        }

        public void LogWarning(string message)
        {
            foreach (var logger in _loggers)
            {
                logger.LogWarning(message);
            }
        }
    }
}