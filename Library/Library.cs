using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
	internal class Library
	{
		private List<Book> books;

		public Library()
		{
			books = new();
		}

		public Library(List<Book> books)
		{
			this.books = books;
		}

		public void AddBook(Book book)
		{
			if (books.Contains(book))
				throw new BookAlreadyExistsException();
			books.Add(book);
		}

		public void IssueBook(string title)
		{
			Book? book = books.Where(u => u.Title == title).FirstOrDefault();
			if (book != null)
			{
				book.IsIssued = true;
				books.Remove(book);
			}	
			else
				throw new BookNotFoundException();
		}

		public void ReturnBook(string title)
		{
			Book? book = books.Where(u => u.Title == title).FirstOrDefault();
			if (book != null && book.IsIssued)
			{
				book.IsIssued = false;
				books.Add(book);
			}
			else if (book == null)
				throw new BookNotFoundException();
			else
				throw new BookNotIssuedException();
		}
	}
}
