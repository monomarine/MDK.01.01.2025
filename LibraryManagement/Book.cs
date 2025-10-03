using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class Book
    {
        public string Title { get; }
        public string Author { get; }
        private bool _isIssued;
        public bool IsIssued => _isIssued;
        public Book(string title, string author)
        {
            Title = title;
            Author = author;
            _isIssued = false;
        }
        public void Issue()
        {
            if (_isIssued)
                throw new InvalidOperationException("Book is already issued.");
            _isIssued = true;
        }

        public void Return()
        {
            if (!_isIssued)
                throw new BookNotIssuedException($"The book '{this.Title}' by {this.Author} is not issued, you cannot reutrn it.");
            _isIssued = false;
        }

        public override string ToString()
        {
            return $"{Title} by {Author} - {(IsIssued ? "Issued" : "Available")}";
        }
    }
}
