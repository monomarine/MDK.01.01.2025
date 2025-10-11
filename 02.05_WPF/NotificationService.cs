namespace _02._05_Events
{
#pragma warning disable
	internal class NotificationService: IDisposable
	{
		private List<Order> _orders = new();
		private string _logFile = "log.txt";

		public void AddOrder(Order order)
		{
			order.Purchased += OrderPaid;
			_orders.Add(order);
		}

		public void Dispose()
		{
			CleanPublishers();
		}

		private void CleanPublishers()
		{
			foreach (Order order in _orders)
			{
				order.Purchased -= OrderPaid;
			}
			_orders.Clear();
		}

		public void OrderPaid(object sender, OrderEventArgs e)
		{
            if (sender is Order)
            {
				var order = (Order)sender;
				string orderInfo = $"оплата от заказчика {order.Client} по заказу номер {order.Id} на сумму {e.Sum}";
            }
            string message = $"[{e.TimeStamp}] {e.Message} - {e.Sum} Рублей";
			Console.WriteLine(message);
			File.AppendAllText(_logFile, message + "\n");
		}
	}
}
