using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _02._05_EventsWPF
{
    internal class OrderHandler
    {
        private readonly string _logFile = "logs.txt";


        public void LogOrderPayment(Order order, OrderEventArgs e)
        {
            string orderInfo = $"оплата от заказчика {order.Client} по заказу номер {order.Id} на сумму {e.Summ}";
            File.AppendAllText(_logFile, $"\n{e.TimeStamp}\t{orderInfo}");
        }
    }
}

