using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class BookNotIssuedException : ApplicationException
    {
        public string Ex { get; set; }
        public BookNotIssuedException(string ex) :base(ex) { Ex = ex; }
        
    }
}
