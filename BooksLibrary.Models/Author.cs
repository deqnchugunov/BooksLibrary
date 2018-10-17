using System.Collections.Generic;

namespace BooksLibrary.Models
{
    public class Author
    {
        public Author()
        {
            this.Books = new List<Book>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}