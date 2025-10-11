namespace _02._05_Events
{
	internal class OrderEventArgs: EventArgs
	{
		public string Message { get;  }
		public DateTime TimeStamp { get; }
		public decimal Sum { get; }

		public OrderEventArgs(string message, decimal sum)
		{
			this.Message = message;
			this.Sum = sum;
			this.TimeStamp = DateTime.Now;
		}
	}
}
