namespace Library
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Book book = new Book("Книга", "Автор", false);
            Library library = new Library();
            library.AddBook(book);
            try
            {
                library.ReturnBook("Неизвестная книга");     
            }
            catch (BookNotFoundException)
            {
                Console.WriteLine("Книга не найдена!");
            }

            try
            {
                library.AddBook(book);
            }
            catch (BookAlreadyExistsException)
            {
                Console.WriteLine("Книга уже есть в библиотеке!");
            }
            
            try
            {
                library.ReturnBook("Книга");
            }
            catch (BookNotIssuedException)
            {
                Console.WriteLine("Книга не была выдана!");
            }
        }
    }
}