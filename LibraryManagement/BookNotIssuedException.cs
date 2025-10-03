using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class BookNotIssuedException : ApplicationException
    {
        private string _message;
        public override string Message => _message;
        public DateTime ExceptionTime { get; }
        public BookNotIssuedException(string message)
        {
            _message = message; 
            ExceptionTime = DateTime.Now;
        }
    }
}
