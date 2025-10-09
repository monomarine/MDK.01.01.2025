using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class CustomExceptions
    {
        public class BookAlreadyExistsException : ApplicationException
        {
            public BookAlreadyExistsException(string message) : base(message) { }
        }

        public class BookNotFoundException : ApplicationException
        {
            public BookNotFoundException(string message) : base(message) { }
        }

        public class BookNotIssuedException : ApplicationException
        {
            public BookNotIssuedException(string message) : base(message) { }
        }
    }
}
