using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._05_EventsWPF.Data
{
    public class FileNotificationService : INotificationService
    {
        private List<Order> _orders = new();
        private string _logFile = "logs.txt";

        public event EventHandler<OrderEventArgs> UpdateData;

        protected virtual void OnUpdateData(OrderEventArgs e)
        {
            UpdateData?.Invoke(this, e);
        }

        public void AddOrder(params Order[] orders)
        {
            foreach (var o in orders)
            {
                o.Purchased += HandleOrderPaid;
                _orders.Add(o);
            }
        }

        public void HandleOrderPaid(object sender, OrderEventArgs e)
        {
            if (sender is Order order)
            {
                string orderInfo = $"ФАЙЛ: оплата от заказчика {order.Client} по заказу номер {order.Id} на сумму {e.Summ}";

                File.AppendAllText(_logFile, $"\n{e.TimeStamp}\t{orderInfo}");

                OnUpdateData(new OrderEventArgs(orderInfo, e.Summ));
            }
        }

        private void CleanPublishers()
        {
            foreach (var o in _orders)
                o.Purchased -= HandleOrderPaid;

            _orders.Clear();
        }

        public void Dispose()
        {
            CleanPublishers();
        }
    }
}
