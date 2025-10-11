using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
	internal class BookNotIssuedException: ApplicationException
	{
		private string messageDetails = "";
		public DateTime ErrorTimeStamp { get; set; }
		public string CauseOfError { get; set; }
		public BookNotIssuedException() { }

		public BookNotIssuedException(string cause, DateTime time): this(cause, time, string.Empty) { }

		public BookNotIssuedException(string cause, DateTime time, string message) : this(cause, time, string.Empty, null) { }
		public BookNotIssuedException(string cause, DateTime time, string message, System.Exception inner) : base(message, inner)
		{
			CauseOfError = cause;
			ErrorTimeStamp = time;
		}
	}
}
