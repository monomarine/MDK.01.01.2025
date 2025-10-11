using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._05_EventsWPF.Data
{
    public interface INotificationService : IDisposable
    {
        event EventHandler<OrderEventArgs> UpdateData;
        void AddOrder(params Order[] orders);
        void HandleOrderPaid(object sender, OrderEventArgs e);
    }
}
