using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _02._05_EventsWPF.Data
{
    internal class NotificationServiceLog : IDisposable
    {
        private List<Order> _orders = new();

        public event EventHandler<OrderEventArgs>? UpdateData;
        protected virtual void onUpdateDate(OrderEventArgs e)
        {
            UpdateData?.Invoke(this, e);
        }

        public void AddOrder(params Order[] order)
        {
            foreach (var o in order) 
            {
                
            o.Purchased += OrderPaid;
            _orders.Add(o);
            }
        }
        private void CleanPublishers()
        {
            foreach (var o in _orders)
                o.Purchased -= OrderPaid;

            _orders = null;
        }

        public void OrderPaid(object send, OrderEventArgs e)
        {
            if (send is Order)
            {
                var order = (Order)send;
                string orderInfo = $"оплата от заказчика {order.Client} по заказу номер {order.Id} на сумму {e.Summ}";
                
                string fileString =  $"\n{e.TimeStamp}\t{orderInfo}";
                

                onUpdateDate(new OrderEventArgs($"оплата от заказчика { order.Client }", e.Summ));
            }


        }

        public void Dispose()
        {
            CleanPublishers();
        }
    }
}
