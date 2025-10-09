using static Exceptions.CustomExceptions;

namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            bool running = true;

            while (running)
            {
                DisplayMenu();
                string choice = Console.ReadLine();

                try
                {
                    switch (choice)
                    {
                        case "1":
                            AddBook(library);
                            break;
                        case "2":
                            IssueBook(library);
                            break;
                        case "3":
                            ReturnBook(library);
                            break;
                        case "4":
                            library.DisplayAllBooks();
                            break;
                        case "5":
                            running = false;
                            Console.WriteLine("Завершено. До свидания");
                            break;
                        default:
                            Console.WriteLine("Нужно выбрать действие от 1 до 5");
                            break;
                    }
                }
                catch (BookAlreadyExistsException ex)
                {
                    Console.WriteLine($"{ex.Message}");
                }
                catch (BookNotFoundException ex)
                {
                    Console.WriteLine($"{ex.Message}");
                }
                catch (BookNotIssuedException ex)
                {
                    Console.WriteLine($"{ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}");
                }

                Console.WriteLine();
            }
        }

        static void DisplayMenu()
        {
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1. Добавить книгу");
            Console.WriteLine("2. Выдать книгу");
            Console.WriteLine("3. Вернуть книгу");
            Console.WriteLine("4. Показать все книги");
            Console.WriteLine("5. Завершить");
            Console.Write("Выбор: ");
        }

        static void AddBook(Library library)
        {
            Console.Write("Введите название книги: ");
            string title = Console.ReadLine();

            Console.Write("Введите автора книги: ");
            string author = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(author))
            {
                Console.WriteLine("Название и автор не могут быть пустыми");
                return;
            }

            Book newBook = new Book(title, author);
            library.AddBook(newBook);
        }

        static void IssueBook(Library library)
        {
            if (library.GetBookCount() == 0)
            {
                Console.WriteLine("Библиотека пуста");
                return;
            }

            Console.Write("Введите название книги для выдачи: ");
            string title = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(title))
            {
                Console.WriteLine("Название книги не может быть пустым");
                return;
            }

            library.IssueBook(title);
        }

        static void ReturnBook(Library library)
        {
            if (library.GetBookCount() == 0)
            {
                Console.WriteLine("Нельзя вернуть книгу, так как библиотека пока пустует");
                return;
            }

            Console.Write("Введите название книги для возврата: ");
            string title = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(title))
            {
                Console.WriteLine("Название книги не может быть пустым");
                return;
            }

            library.ReturnBook(title);
        }
    }
}
