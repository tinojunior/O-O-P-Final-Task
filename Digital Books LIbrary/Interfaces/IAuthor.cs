using Digital_Books_LIbrary.Catalogue;
using System;
using System.Collections.Generic;
using System.Text;

namespace Digital_Books_LIbrary.Interfaces
{
    interface IAuthor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int YearOfBirth { get; set; }
        public List<Book> Books { get; set; }
        public string Country { get; set; }

        void Find();

    }
}
