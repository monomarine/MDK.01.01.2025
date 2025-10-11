using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _02._05_EventsWPF.Data
{
    public class NotificationService : IDisposable
    {
        private List<Order> _orders = new();
        private string _logFile = "logs.txt";

        public event EventHandler<OrderEventArgs>? UpdateData;
        public event EventHandler<OrderEventArgs>? LogToFile;
        protected virtual void OnUpdateData(OrderEventArgs e)
        {
            UpdateData?.Invoke(this, e);
        }
        protected virtual void OnLogToFile(OrderEventArgs e)
        {
            LogToFile?.Invoke(this, e);
        }

        public void AddOrder(params Order[] orders)
        {
            foreach (var o in orders)
            {
                o.Purchased += OrderPaid;
                _orders.Add(o);
            }
        }
        private void CleanPublishers()
        {
            foreach (var o in _orders)
                o.Purchased -= OrderPaid;

            _orders.Clear();
        }

        public void OrderPaid(object? sender, OrderEventArgs e)
        {
            if (sender is Order order)
            {
                OnUpdateData(new OrderEventArgs($"оплата заказчика {order.Client}", e.Summ));
                OnLogToFile(new OrderEventArgs($"оплата заказчика {order.Client} по заказу номер {order.Id} на сумму {e.Summ}", e.Summ));
            }
        }

        public void WriteToFile(object? sender, OrderEventArgs e)
        {
            string logEntry = $"{e.TimeStamp}\t{e.Message}";
            File.AppendAllText(_logFile, logEntry + Environment.NewLine);
        }
        public void Dispose()
        {
            CleanPublishers();
        }
    }
}
