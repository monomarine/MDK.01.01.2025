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
        public event EventHandler<OrderEventArgs>? UpdateData;
        private List<Order> _orders = new();

        public void AddOrder(params Order[] orders)
        {
            foreach (var order in orders)
            {
				order.Purchased += OrderPaid;
				_orders.Add(order);
			}
        }

		protected virtual void OnUpdateData(OrderEventArgs e)
		{
			UpdateData?.Invoke(this, e);
		}

		private void CleanPublishers()
        {
            foreach (var o in _orders)
                o.Purchased -= OrderPaid;

            _orders.Clear() ;
        }

		public void OrderPaid(object? send, OrderEventArgs e)
		{
			if (send is Order)
			{
				var order = (Order)send;
				string orderInfo = $"[{e.TimeStamp}] оплата от заказчика {order.Client} по заказу номер {order.Id} на сумму {e.Summ}";
				OnUpdateData(new OrderEventArgs(orderInfo, e.Summ));
			}
		}

		public void Dispose()
        {
            CleanPublishers();
        }
    }
}
