namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            // Adding books to the library
            Console.WriteLine("======================== To Add Book ============================\n");

            Console.WriteLine(library.AddBook(new Book("The Great Gatsby", "F. Scott Fitzgerald", "9780743273565")));
            Console.WriteLine(library.AddBook(new Book("To Kill a Mockingbird", "Harper Lee", "9780061120084")));
            Console.WriteLine(library.AddBook(new Book("1984", "George Orwell", "9780451524935")));

            // Searching and borrowing books
            Console.WriteLine("\n======================== To Borrow Book ============================\n");

            Console.WriteLine("Searching and borrowing books...");
            Console.WriteLine(library.BorrowBook("Gatsby"));
            Console.WriteLine(library.BorrowBook("1984"));
            Console.WriteLine(library.BorrowBook("Harry Potter")); // This book is not in the library

            // Returning books
            Console.WriteLine("\n======================== To Return Book ============================");

            Console.WriteLine("\nReturning books...");
            Console.WriteLine(library.ReturnBook("Gatsby"));
            Console.WriteLine(library.ReturnBook("Harry Potter")); // This book is not borrowed

            Console.ReadLine();
        }
    }
}
