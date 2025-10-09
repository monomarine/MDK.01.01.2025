using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public bool IsIssued { get; set; }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
            IsIssued = false;
        }

        public override string ToString()
        {
            string status = IsIssued ? "Выдана" : "В наличии";
            return $"«{Title}», автор: {Author} – {status}";
        }
    }
}
