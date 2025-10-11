using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _02._05_EventsWPF.Data
{
    public class FileLogger
    {
        private string _logFile;

        public FileLogger(string logFile = "logs.txt")
        {
            _logFile = logFile;
        }

        public void LogOrderPayment(object? sender, OrderEventArgs e)
        {
            if (sender is Order order)
            {
                string orderInfo = $"оплата от заказчика {order.Client} по заказу номер {order.Id} на сумму {e.Summ}";
                string logEntry = $"{e.TimeStamp}\t{orderInfo}";

                File.AppendAllText(_logFile, logEntry + Environment.NewLine);
            }
        }
    }
}
