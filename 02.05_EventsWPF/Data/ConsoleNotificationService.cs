using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._05_EventsWPF.Data
{
    public class ConsoleNotificationService : INotificationService
    {
        private List<Order> _orders = new();

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
                string message = $"оплата от заказчика {order.Client} по заказу номер {order.Id} на сумму {e.Summ}";
                Console.WriteLine($"{e.TimeStamp}\t{message}");

                OnUpdateData(new OrderEventArgs(message, e.Summ));
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
