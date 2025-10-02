using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class BookAlreadyExistsException : ApplicationException
    {
        public BookAlreadyExistsException(string ex) : base(ex) { Ex = ex; }
        public string Ex { get; set; }
        
    }
}
