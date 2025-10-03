namespace LibraryManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            Book book1 = new Book("1984", "George Orwell");
            Book book2 = new Book("To Kill a Mockingbird", "Harper Lee");
            Book book3 = new Book("The Great Gatsby", "F. Scott Fitzgerald");
            Book book4 = new Book("The Master and Margarita", "Mikhail Bulgakov");

            try
            {
                //library.AddBook(null); // This will throw ArgumentNullException
                library.AddBook(book1);
                library.AddBook(book2);
                library.AddBook(book3);
                //library.AddBook(book1); // This will throw BookAlreadyExistsException

                library.IssueBook(book1);
                library.IssueBook(book2);
                //library.ReturnBook(book4); // This will throw BookNotFoundException

                library.ReturnBook(book1);
                //library.ReturnBook(book3); // This will throw BookNotIssuedException
            }
            catch (BookAlreadyExistsException ex)
            {
                Console.WriteLine($"Error: {ex.Message} (Occurred at: {ex.ExceptionTime})\n");
            }
            catch (BookNotFoundException ex)
            {
                Console.WriteLine($"Error: {ex.Message} (Occurred at: {ex.ExceptionTime})\n");
            }
            catch (BookNotIssuedException ex)
            {
                Console.WriteLine($"Error: {ex.Message} (Occurred at: {ex.ExceptionTime})\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}\n");
            }
            finally
            {
                foreach (var book in library.Books)
                {
                    Console.WriteLine(book);
                }
            }
        }
    }
}
