using System;
using System.Collections.Generic;
using System.IO;

namespace _02._05_EventsWPF.Data
{
	public class OrderLoggerService : IDisposable
	{
		private List<Order> _orders = new();
		private readonly string _logFilePath;

		public OrderLoggerService(string logFilePath = "logs.txt")
		{
			_logFilePath = logFilePath;
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
				string orderInfo = $"оплата от заказчика {order.Client} по заказу номер {order.Id} на сумму {e.Summ}";
				File.AppendAllText(_logFilePath, $"\n{e.TimeStamp}\t{orderInfo}");
			}
		}

		public void Dispose()
		{
			CleanPublishers();
		}
	}
}


