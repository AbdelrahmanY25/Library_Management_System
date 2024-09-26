using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        private string _title;
        private string _author;
        private string _isbn;
        public string Title => _title;
        public string Author => _author;
        public string ISBN => _isbn;
        public bool Availability { get; set; }       
    }
}
