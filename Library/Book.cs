using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Book
    {
        private string _title;
        private string _author;
        private bool _isIssued;

        public string Title { get =>  _title; set { _title = value; } }
        public string Author { get =>  _author; set { _author = value; } }
        public bool IsIssued { get => _isIssued; set { _isIssued = value; } }
        public Book(string title, string author, bool isIssued = false)
        {
            Title = title;
            Author = author;
            IsIssued = isIssued;
        }
    }
}
