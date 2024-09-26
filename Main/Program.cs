using static Main.Library;

namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            BorrowAndReturnBooks ToBoorowBook = library.BorrowBook;
            BorrowAndReturnBooks ToReturnBook = library.ReturnBook;

            // Adding books to the library
            Console.WriteLine("======================== To Add Book ============================\n");

            Console.WriteLine(library.AddBook(new Book("The Great Gatsby", "F. Scott Fitzgerald", "9780743273565")));
            Console.WriteLine(library.AddBook(new Book("To Kill a Mockingbird", "Harper Lee", "9780061120084")));
            Console.WriteLine(library.AddBook(new Book("1984", "George Orwell", "9780451524935")));

            Console.WriteLine("\n======================== Select Book By Index ============================\n");

            Console.WriteLine(library[2]);

            // Searching and borrowing books
            Console.WriteLine("\n======================== To Borrow Book ============================\n");

            Console.WriteLine("Searching and borrowing books...");            
            Console.WriteLine(ToBoorowBook("Gatsby"));
            Console.WriteLine(ToBoorowBook("1984"));
            Console.WriteLine(ToBoorowBook("Harry Potter")); // This book is not in the library

            // Returning books
            Console.WriteLine("\n======================== To Return Book ============================");

            Console.WriteLine("\nReturning books...");
            Console.WriteLine(ToReturnBook.Invoke("Gatsby"));
            Console.WriteLine(ToReturnBook.Invoke("Harry Potter")); // This book is not borrowed

            Console.ReadLine();
        }
    }
}
