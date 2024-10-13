using static Main.Library;

namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            Console.WriteLine("======================== To Add Book ============================\n");

            library.BooksAdded += Library_BooksAdded;

            library.AddBook(new Book("The Great Gatsby", "F. Scott Fitzgerald", "9780743273565"));
            library.AddBook(new Book("To Kill a Mockingbird", "Harper Lee", "9780061120084"));
            library.AddBook(new Book("1984", "George Orwell", "9780451524935"));

            Console.WriteLine("\n======================== Select Book By Index ============================\n");

            Console.WriteLine(library[2]);
            Console.WriteLine(library["198"]);

            Console.WriteLine("\n======================== To Borrow Book ============================\n");

            library.BooksBorrowedAndReturned += Library_BooksBorrowed;

            library.FindBook("Gatsby");
            library.FindBook("1984");
            library.FindBook("Harry Potter"); // Sorry We Don't Have This Book In Our Library...

            Console.WriteLine("\n======================== To Return Book ============================");

            library.BooksBorrowedAndReturned -= Library_BooksBorrowed;
            library.BooksBorrowedAndReturned += Library_BooksReturned1;
            
            library.FindBook("Gatsby");
            library.FindBook("Harry Potter"); // Sorry We Don't Have This Book In Our Library...

            Console.ReadLine();
        }

        private static void Library_BooksReturned1(Book book, string search)
        {
            if (book != null && !book.Availability)
            {                
                book.Availability = true;
                Console.WriteLine($"Thank You For Returned \"{book.Title}\" Book");
            }            
            else
            {
                Console.WriteLine("Sorry We Don't Have This Book In Our Library...");
            }
        }
        private static void Library_BooksBorrowed(Book book, string search)
        {
            if (book != null)
            {
                if (book.Availability)
                {
                    book.Availability = false;
                    Console.WriteLine($"Ok You Can Borrow: \"{book.Title}\" Book...");
                }
                else
                {
                    Console.WriteLine($"Sorry The \"{book.Title}\" Book Already Borrowed...");
                }                
            }
            else
            {
                Console.WriteLine("Sorry We Don't Have This Book In Our Library...");
            }

        }
        private static void Library_BooksAdded(Book book)
        {
            Console.WriteLine($"Book added: {book.Title} by {book.Author} With ISBN : {book.ISBN}");
        }
    }
}
