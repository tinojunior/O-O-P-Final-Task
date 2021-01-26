using Digital_Books_LIbrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

using System.Text.Json.Serialization;

namespace Digital_Books_LIbrary.Catalogue
{
    public class Author : IAuthor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int YearOfBirth { get; set; }
        [JsonIgnore]
        public List<Book> Books { get; set; }
        public string Country { get; set; }

        public override string ToString()
        {
            return string.Format("Author Catalog:\n\tId: {0}, Name: {1}, Year of Birth: {2}, Books: {3}, Country: {4}," +
                "Description: {5}", Id, Name, YearOfBirth, string.Join<Book>(",", Books.ToArray()));
            //we are having this error because the string and class of Authors is empty.
        }
        public Author()
        {

        }

        public Author(int id, string name, int yearofbirth, string country)
        {
            Id = id;
            Name = name;
            YearOfBirth = yearofbirth;
            Country = country;
            Books = new List<Book>();
        }

        public void print()
        {
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Year: {YearOfBirth}");
            Console.WriteLine($"Country: {Country}");

        }

        public void Find()
        {
            Console.WriteLine($"Find {Name} by {Country} of Author");
        }
    }
}
