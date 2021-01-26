using Digital_Books_LIbrary.Catalogue;
using Digital_Books_LIbrary.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Digital_Books_LIbrary.Services
{
    public class JSONServices : IJSONServices
    {
        private BooksService bookListService;
        private AuthorsService authorsService;
        public object author;
        public object book;
        public object user;
        public JSONServices()
        {
            this.bookListService = new BooksService();
            this.authorsService = new AuthorsService();
        }

       public List<Book> LoadBooks(int id, string name, string genre, int year, string description)
        {
            String JSONRESULT = JsonConvert.SerializeObject(book);
            File.WriteAllText(@"books.json", JSONRESULT);
            Console.WriteLine("Stored!");

            JSONRESULT = String.Empty;
            JSONRESULT = File.ReadAllText(@"books.json");
            Book resultBook = JsonConvert.DeserializeObject<Book>(JSONRESULT);
            Console.WriteLine(resultBook.ToString());


            var dictionary = JsonConvert.DeserializeObject<IDictionary>(JSONRESULT);
            foreach (DictionaryEntry entry in dictionary)
            {
                Console.WriteLine(entry.Key + ":" + entry.Value);
            }
            return null;
        }

         public List<Author> LoadAuthors(int id, string name, int yearofbirth, string country)
        {
            String JSONRESULT1 = JsonConvert.SerializeObject(author);
            File.WriteAllText(@"authors.json", JSONRESULT1);
            Console.WriteLine("Stored!");

            JSONRESULT1 = String.Empty;
            JSONRESULT1 = File.ReadAllText(@"authors.json");
            Book resultBook = JsonConvert.DeserializeObject<Book>(JSONRESULT1);
            Console.WriteLine(resultBook.ToString());


            var dictionary1 = JsonConvert.DeserializeObject<IDictionary>(JSONRESULT1);
            foreach (DictionaryEntry entry in dictionary1)
            {
                Console.WriteLine(entry.Key + ":" + entry.Value);
            }

            return null;

        }

        public List<User> LoadUsers(int id, string name, string login, string password, DateTime birthdate, string phone, char mail)
        {

            String JSONRESULT2 = JsonConvert.SerializeObject(user);
            File.WriteAllText(@"users.json", JSONRESULT2);
            Console.WriteLine("Stored!");


            JSONRESULT2 = String.Empty;
            JSONRESULT2 = File.ReadAllText(@"books.json");
            User resultUser = JsonConvert.DeserializeObject<User>(JSONRESULT2);
            Console.WriteLine(resultUser.ToString());

            var dictionary2 = JsonConvert.DeserializeObject<IDictionary>(JSONRESULT2);
            foreach (DictionaryEntry entry in dictionary2)
            {
                Console.WriteLine(entry.Key + ":" + entry.Value);
            }

            return null;

        }

        

    }
   
}
