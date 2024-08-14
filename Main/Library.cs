using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public class Library
    {
        public Library(List<Book> books = null)
        {
            Books = new List<Book>();
        }

        public List<Book> Books { get; set; }

        public string AddBook(Book book)
        {
            Books.Add(book);
            return $"Book added: {book.Title} by {book.Author} With ISBN : {book.ISBN}";
        }

        //public Book SearchBook(string search)
        //{
        //    foreach (var book in Books)
        //    {
        //        if (book.Title.Contains(search) || book.Author.Contains(search))
        //        {
        //            return book;
        //        }
        //    }
        //    return null;
        //}

        public string BorrowBook(string search)
        {
            //Book book = SearchBook(search);
            Book book = Books.Find((e) => e.Title.Contains(search) || e.Author.Contains(search));

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
            //Book books = SearchBook(search);
            Book book = Books.Find((e) => e.Title.Contains(search) || e.Author.Contains(search));

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
