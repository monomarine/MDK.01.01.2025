using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    internal class BookNotFoundException : ApplicationException
    {
        private string _message;
        public override string Message => _message;
        public DateTime ExceptionTime { get; }

        public BookNotFoundException(string message)
        {
            _message = message;
            ExceptionTime = DateTime.Now;
        }
    }
}
