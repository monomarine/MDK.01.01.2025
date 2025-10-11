using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace _02._05_EventsWPF.Data
{
	internal class Logger: IDisposable
	{
		private string _logFile = "logs.txt";
		private List<Order> _orders = new();

		public void OrderPaid(object sender, OrderEventArgs e)
		{
			if (sender is Order)
			{
				var order = (Order)sender;
				string orderInfo = $"оплата от заказчика {order.Client} по заказу номер {order.Id} на сумму {e.Summ}";
				File.AppendAllText(_logFile, $"[{e.TimeStamp}]\t{orderInfo}\n");
			}
		}

		public void AddOrder(params Order[] orders)
		{
			foreach (var order in orders)
			{
				order.Purchased += OrderPaid;
				_orders.Add(order);
			}
		}
		private void CleanPublishers()
		{
			foreach (var o in _orders)
				o.Purchased -= OrderPaid;

			_orders = null;
		}
		public void Dispose()
		{
			CleanPublishers();
		}

	}
}
