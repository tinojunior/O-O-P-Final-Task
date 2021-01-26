using Digital_Books_LIbrary.Catalogue;
using System;
using System.Collections.Generic;
using System.Text;

namespace Digital_Books_LIbrary.Interfaces
{
    interface IBook
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }

        public List<Author> Authors { get; set; }

        public int Year { get; set; }

        public string Description { get; set; }

        void Add();
        void Remove();

    }
}
