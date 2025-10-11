namespace _02._05_Events
{
	public enum OrderStatus { New, Paid }
	internal class Order
	{
		public event EventHandler<OrderEventArgs>? Purchased;
		protected virtual void OnPurchase(OrderEventArgs e) => Purchased?.Invoke(this, e);
		public int Id { get; set; }
		public OrderStatus Status { get; private set; }
		public string Client { get; }

		public Order(int id, string client) : this(id, client, OrderStatus.New) { }

		public Order(int id, string client, OrderStatus status)
		{
			this.Id = id;
			this.Client = client;
			this.Status = status;
		}

		public void PaidOrder(decimal sum)
		{
			this.Status = OrderStatus.Paid;
			OnPurchase(new OrderEventArgs("Заказ был оплачен", sum));
		}
	}
}
