using Digital_Books_LIbrary.Interfaces;
using DocumentFormat.OpenXml.Bibliography;
using System;
using System.Collections.Generic;
using System.Text;

using System.Text.Json.Serialization;

namespace Digital_Books_LIbrary.Catalogue
{
    public class Book : IBook
    {
        public int Id { get; set; }

        public int AuthorID { get; set; } //main author of the book

        public  string Name { get; set; }
        public string Genre { get; set; }

        [JsonIgnore]
        public List<Author> Authors { get; set; }

        public int Year { get; set; }

        public string Description { get; set; }
        List<Author> IBook.Authors { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override string ToString()
        {
            return string.Format("Book Catalog:\n\tId: {0}, Name: {1}, Genre: {2}, Authors: {3}, Year: {4}," +
                "Description: {5}", Id, Name, Genre, string.Join<Author>(",", Authors.ToArray()));
            //we are having this error because the string and class of Authors is empty.fixed
        }

        public Book()
        {

        }
        public Book(int id, string name, string genre, int year, string description)
        {
            Id = id;
            Name = name;
            Genre = genre;
            Year = year;
            Description = description;
            Authors = new List<Author>();

        }
        public void print()
        {
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Genre: {Genre}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Year: {Description}");
        }

        public void Add()
        {
            Console.WriteLine($"Add New {Name} and insert the {Year} of Book");

        }

        public void Remove()
        {
            Console.WriteLine($"Remove New {Name} and insert the {Year} of Book");
        }
    }
}
