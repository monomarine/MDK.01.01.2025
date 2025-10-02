namespace Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book("Война и мир", "Толстой");
            Book b2 = new Book("Преступление и наказание", "Достоевский");
            Book b3 = new Book("Горе от ума", "Грибоедов");

            Library lib = new Library();
            lib.AddBook(b1);
            lib.AddBook(b2);
            // lib.AddBook(b1); // вызов ошибки BookAlreadyExists 

            //lib.IssueBook("Горе от ума");
            //lib.ReturnBook("Горе от ума");
            //// вызов ошибки BookNotFound 

            // lib.ReturnBook("Преступление и наказание"); // вызов ошибки BookNotIssued

            lib.IssueBook("Война и мир");
            Console.WriteLine(lib);
            Console.WriteLine(lib.GetFreeBooks());
            lib.ReturnBook("Война и мир");
            Console.WriteLine(lib);
            Console.WriteLine(lib.GetFreeBooks());
        }
    }
}
