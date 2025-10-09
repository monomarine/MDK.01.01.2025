using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Exceptions.CustomExceptions;

namespace Exceptions
{
    internal class Library
    {
        private List<Book> books;

        public Library()
        {
            books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            if (books.Any(b => b.Title.Equals(book.Title, StringComparison.OrdinalIgnoreCase)))
            {
                throw new BookAlreadyExistsException($"Книга с названием «{book.Title}» уже есть в библиотеке");
            }

            books.Add(book);
            Console.WriteLine($"Книга «{book.Title}» добавлена в библиотеку!");
        }

        public void IssueBook(string title)
        {
            Book book = FindBook(title);

            if (book == null)
            {
                throw new BookNotFoundException($"Книга «{title}» не найдена в библиотеке");
            }

            if (book.IsIssued)
            {
                throw new BookAlreadyExistsException($"Книга «{title}» уже была выдана");
            }

            book.IsIssued = true;
            Console.WriteLine($"Книга «{title}» выдана");
        }

        public void ReturnBook(string title)
        {
            Book book = FindBook(title);

            if (book == null)
            {
                throw new BookNotFoundException($"Книга «{title}» не найдена");
            }

            if (!book.IsIssued)
            {
                throw new BookNotIssuedException($"Книга «{title}» и так не была выдана, поэтому её нельзя вернуть");
            }

            book.IsIssued = false;
            Console.WriteLine($"Книга «{title}» успешно возвращена в библиотеку");
        }

        private Book FindBook(string title)
        {
            return books.FirstOrDefault(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
        }

        public void DisplayAllBooks()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("Библиотека пуста");
                return;
            }

            Console.WriteLine("\nСписок всех книг в библиотеке:");
            foreach (var book in books)
            {
                Console.WriteLine($"• {book}");
            }
        }

        public int GetBookCount()
        {
            return books.Count;
        }
    }
}
