using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public class Library
    {
        public delegate string BorrowAndReturnBooks(string search);
        public List<Book> Books { get; set; } = new List<Book>();

        public string this[int book]
        {
            get
            {
                return $"Book Title: {Books[book].Title}, Book Author: {Books[book].Author}";
            }
        }
        public string AddBook(Book book)
        {
            Books.Add(book);
            return $"Book added: {book.Title} by {book.Author} With ISBN : {book.ISBN}";
        }
        public string BorrowBook(string search)
        {
            Book? book = Books.Find((e) => e.Title.Contains(search) || e.Author.Contains(search));

            if (book != null && book.Availability)
            {
                book.Availability = false;
                return  $"Ok You Can Borrow: \"{book.Title}\" Book...";
            }
            else if (book != null && !book.Availability)
            {
                return  $"Sorry The \"{book.Title}\" Book Already Borrowed...";
            }
            else
            {
                return "Sorry We Don't Have This Book In Our Library...";
            }
        }
        public string ReturnBook(string search)
        {
            Book? book = Books.Find((e) => e.Title.Contains(search) || e.Author.Contains(search));

            if (book != null && !book.Availability)
            {
                book.Availability = true;
                return $"Thank You For Returned \"{book.Title}\" Book";
            }
            else if (book != null && book.Availability)
            {
                return $"Book Wasn't Borrowed: {book.Title}";
            }
            else
            {
                return "This book is not borrowed.";
            }
        }
    }
}
