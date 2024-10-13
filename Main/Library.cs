namespace Main
{
    public class Library
    {
        public delegate void BorrowAndReturnBooksHandler(Book book, string search);
        public delegate void AddBooksHandler(Book book);

        public event AddBooksHandler? BooksAdded;
        public event BorrowAndReturnBooksHandler? BooksBorrowedAndReturned;
        public List<Book> Books { get; set; } = new List<Book>();

        public string this[int book]
        {
            get
            {
                if (book < Books.Count())
                    return $"Book Title: {Books[book].Title}, Book Author: {Books[book].Author}";
                return "Sorry We Don't Have This Book In Our Library...";
            }
        }
        public string this[string title]
        {
            get
            {
                Book book = Books.Find(x => x.Title == title);
                if (book != null)
                    return $"There is '{book.Title}' Book";
                return "Sorry We Don't Have This Book In Our Library...";
            }
        }
        public void AddBook(Book book)
        {
            Books.Add(book);
            BooksAdded?.Invoke(book); // Fire The Event
        }
        public void FindBook(string search)
        {
            Book? book = Books.Find((e) => e.Title.Contains(search) || e.Author.Contains(search));
            BooksBorrowedAndReturned?.Invoke(book, search);            
        }        
    }
}
