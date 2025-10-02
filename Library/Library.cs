using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Library
    {
        private static List<Book> _books;

        public static List<Book> Books { get { return _books; } set => _books = value; } 

        public Library() {
            Books = new List<Book>();
        }

        public void IssueBook(string title) // выдать книгу
        {
            bool isFound = false;
            foreach (var book in Books)
            {
                if (book.Title == title)
                {
                    isFound = true;
                    book.IsIssued = true;
                    break;
                }
            }
            if (!isFound) throw new BookNotFoundException($"Книга {title} не найдена");
        }

        public void AddBook(Book b) // добавить в библиотеку
        {
            if (!Books.Contains(b)) Books.Add(b);
            else throw new BookAlreadyExistsException($"Книга {b.Title} уже существует");
            
        }
        public void ReturnBook(string title) // вернуть книгу в библу
        {
            bool isFound = false;
            foreach (Book b in Books)
            {
                if (b.Title == title)
                {
                    if (!b.IsIssued) throw new BookNotIssuedException($"Книга {b.Title} не была выдана");
                    b.IsIssued = false;
                    isFound = true;
                    break;
                }
                
            }
            if (!isFound) throw new BookNotFoundException($"Книга {title} не найдена");
        }
        /// <summary>
        /// Метод для получения всех книг библиотеки
        /// </summary>
        /// <returns>строка-список книг</returns>
        public override string ToString()
        {
            string s = "Все книги\n-------------\n";
            foreach (var b in Books) s += $"{b.Title}\n";
            return s;
        }
        /// <summary>
        /// Метод для получения доступных к выдаче книг
        /// </summary>
        /// <returns>строка-список книг</returns>
        public string GetFreeBooks()
        {
            string s = "Доступные книги\n-------------\n";
            foreach (var b in Books) if (!b.IsIssued) s += $"{b.Title}\n";
            return s;
        }
    }
}
