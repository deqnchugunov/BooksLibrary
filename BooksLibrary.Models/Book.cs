using System;
using System.Collections.Generic;
using System.Text;

namespace BooksLibrary.Models
{
    public class Book
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Desciption { get; set; }

        public string CoverImage { get; set; }

        public int AuthorId { get; set; }

        public Author Author { get; set; }
    }
}
