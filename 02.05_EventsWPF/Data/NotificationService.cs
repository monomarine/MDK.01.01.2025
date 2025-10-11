using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace _02._05_EventsWPF.Data
{
    public class NotificationService : IDisposable
    {
        private List<Order> _orders = new();
        private readonly OrderHandler _logService = new OrderHandler();

        public event EventHandler<OrderEventArgs>? UpdateData;
        protected virtual void OnUpdateData(OrderEventArgs e)
        {
            UpdateData?.Invoke(this, e);
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

        public void OrderPaid(object? send, OrderEventArgs e)
        {
            if (send is Order order)
            {
                OnUpdateData(new OrderEventArgs($"оплата от заказчика {order.Client}", e.Summ));
                _logService.LogOrderPayment(order, e);
            }
        }


        public void Dispose()
        {
            CleanPublishers();
        }
    }
}

