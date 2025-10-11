using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
	internal class BookAlreadyExistsException: ApplicationException
	{
		private string messageDetails = "";
		public DateTime ErrorTimeStamp { get; set; }
		public string CauseOfError { get; set; }
		public BookAlreadyExistsException() { }

		public BookAlreadyExistsException(string cause, DateTime time): this(cause, time, string.Empty) { }

		public BookAlreadyExistsException(string cause, DateTime time, string message) : this(cause, time, string.Empty, null) { }
		public BookAlreadyExistsException(string cause, DateTime time, string message, System.Exception inner) : base(message, inner)
		{
			CauseOfError = cause;
			ErrorTimeStamp = time;
		}
	}
}
