using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
	internal class BookNotFoundException: ApplicationException
	{
		private string messageDetails = "";
		public DateTime ErrorTimeStamp { get; set; }
		public string CauseOfError { get; set; }
		public BookNotFoundException() { }

		public BookNotFoundException(string cause, DateTime time): this(cause, time, string.Empty) { }

		public BookNotFoundException(string cause, DateTime time, string message) : this(cause, time, string.Empty, null) { }
		public BookNotFoundException(string cause, DateTime time, string message, System.Exception inner) : base(message, inner)
		{
			CauseOfError = cause;
			ErrorTimeStamp = time;
		}
	}
}
