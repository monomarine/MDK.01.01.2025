using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._05_Events
{
#pragma warning disable
    internal class NotificationService : IDisposable
	{
		private List<Order> _orders = new();

		public void AddOrder(Order order)
		{
			order.Purchased += OrderPaid;
			_orders.Add(order);
		}
		{
		}

		{
			{
			}
		}

            {
		}
	}
}
