using Digital_Books_LIbrary.Catalogue;
using System;
using System.Collections.Generic;
using System.Text;

namespace Digital_Books_LIbrary.Models
{
    class Favorites
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Author> Authors;

        public List<Book> Books { get; set; }

        public override string ToString()
        {
                  return string.Format("Favorite Catalog:\n\tId: {0}, Name: {1}, Authors: {2}, Books: {3}"
                , Id, Name, string.Join<Book>(",", Books.ToArray()), string.Join<Author>(",", Authors.ToArray()));
            
        }
    }
}
