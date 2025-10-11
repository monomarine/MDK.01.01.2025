using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace _02._05_EventsWPF.Data
{
    public class LogService
    {
        private readonly string _logFile = "logs.txt";


        public void LogOrderPayment(Order order, OrderEventArgs e)
        {
            string orderInfo = $"оплата от заказчика {order.Client} по заказу номер {order.Id} на сумму {e.Summ}";
            File.AppendAllText(_logFile, $"\n{e.TimeStamp}\t{orderInfo}");
        }
    }
}

