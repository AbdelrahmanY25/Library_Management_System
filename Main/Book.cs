namespace Main
{
    public class Book
    {
        public Book(string title, string author, string isbn)
        {
            _title = title;
            _author = author;
            _isbn = isbn;
            Availability = true;
        }

        private readonly string _title;
        private readonly string _author;
        private readonly string _isbn;
        public string Title => _title;
        public string Author => _author;
        public string ISBN => _isbn;
        public bool Availability { get; set; }       
    }
}
