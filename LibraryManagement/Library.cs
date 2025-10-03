using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    internal class Library
    {
        private List<Book> _books;

         public List<Book> Books => _books;

        public Library()
        {
            _books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            if (book == null) 
                throw new ArgumentNullException(nameof(book), "Book cannot be null.");
            if (_books.Contains(book)) 
                throw new BookAlreadyExistsException($"The book '{book.Title}' by {book.Author} already exists in the library.");
            else
                _books.Add(book);
        }

        public void IssueBook(Book book)
        {
            if (book == null)
                throw new ArgumentNullException(nameof(book), "Book cannot be null.");
            if (!_books.Contains(book))
                throw new BookNotFoundException($"The book '{book.Title}' by {book.Author} is not found in the library.");
            else
                book.Issue();
        }

        public void ReturnBook(Book book)
        {
            if (book == null)
                throw new ArgumentNullException(nameof(book), "Book cannot be null.");
            if (!_books.Contains(book))
                throw new BookNotFoundException($"The book '{book.Title}' by {book.Author} is not found in the library.");
            else
                book.Return();
        }
    }
}
