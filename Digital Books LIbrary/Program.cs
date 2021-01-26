using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Digital_Books_LIbrary.Catalogue;
using Digital_Books_LIbrary.Interfaces;
using System.Text.Json;
using System.Text.Json.Serialization;
using Digital_Books_LIbrary;
using Digital_Books_LIbrary.Services;
using System.Text.RegularExpressions;

namespace Digital_Books_LIbrary
{

    class Program
    {
        public static void Main(string[] args)
        {
            // collections
            List<Author> authors = new List<Author>();
            List<Book> books = new List<Book>();
            List<User> users = new List<User>();

            string jsonAuthors, jsonBooks, jsonUsers;

            //first need to parse the files : authors; books; users
            jsonAuthors = File.ReadAllText("authors.json");
            jsonBooks = File.ReadAllText("books.json");
            jsonUsers = File.ReadAllText("users.json");

            authors = JsonSerializer.Deserialize<List<Author>>(jsonAuthors);
            books = JsonSerializer.Deserialize<List<Book>>(jsonBooks);
            users = JsonSerializer.Deserialize<List<User>>(jsonUsers);

            //fill the books of each author
            foreach (var author in authors)
            {
                author.Books = books.FindAll(s => s.AuthorID == author.Id);
            }

            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }

            Console.Clear();
            //Finding books by properties
            // Books with 'of' in Name
            List<Book> booksByName = FindBooksByName("of");
            Console.WriteLine(booksByName.Count + " with 'of' in their name");

            // Books in 'Drama' Genre
            List<Book> booksByGenre = FindBooksByGenre("Drama");
            Console.WriteLine(booksByGenre.Count + " in Drama genre");

            // Books from 1968
            List<Book> booksByYear = FindBooksByYear(1968);
            Console.WriteLine(booksByYear.Count + " of 1968");

            
            while (showMenu)
            {
                showMenu = MainMenu();
            }

            Console.Clear();

            List<Book> FindBooksByName(string name)
            {
                return books.FindAll(x => x.Name.Contains(name));
            }

            List<Book> FindBooksByGenre(string genre)
            {
                return books.FindAll(x => x.Genre.Equals(genre));
            }

            List<Book> FindBooksByYear(int year)
            {
                return books.FindAll(x => x.Year == year);
            }

            bool MainMenu()
            {
                Console.Clear();
                Console.WriteLine("Main Menu");
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1) Books");
                Console.WriteLine("2) Authors");
                Console.WriteLine("3) Users");
                Console.WriteLine("4) Register");
                Console.WriteLine("5) Exit");
                Console.Write("\r\nSelect an option: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("Books");
                        Console.WriteLine("Name -- Year -- Genre");

                        foreach (var item in books)
                        {
                            Console.WriteLine($"{item.Name} -- {item.Year} -- {item.Genre}");
                        }

                   
                        Console.ReadLine();

                        try
                        {
                            Console.WriteLine("Choose book from the below options:");
                            Console.WriteLine("1) Name \n2) Author \n3) Year \n4) Genre");
                            

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        
                        return true;
                    case "2":
                        Console.WriteLine("Authors");
                        Console.WriteLine("Name -- Country");

                        foreach (var item in authors)
                        {
                            Console.WriteLine($"{item.Name} -- {item.Country}");
                        }

                        Console.ReadLine();
                        return true;
                    case "3":
                        Console.WriteLine("Users");
                        Console.WriteLine("Name -- Email -- Phone");

                        foreach (var item in users)
                        {
                            Console.WriteLine($"{item.Name} -- {item.Email} -- {item.PhoneNo}");
                        }

                        Console.ReadLine();
                        return true;
                    case "4":
                        try
                        {
                            Console.WriteLine("Welcome to the Digital Library");
                            Console.WriteLine("Create a new user");

                            int id;
                            string name, age, password, login, email, phoneNo = string.Empty;
                            Console.Write("Enter an id :");
                            id = int.Parse(Console.ReadLine());
                            Console.Write("Enter a name :");
                            name = Console.ReadLine();
                            Console.Write("Enter age :");
                            age = Console.ReadLine();
                            Console.Write("Enter a login :");
                            login = Console.ReadLine();
                            Console.Write("Enter a password :");
                            password = Console.ReadLine();

                            Console.Write(" Please only enter phone number with this format (123)-456-7890 ");
                            Console.Write(System.Environment.NewLine);
                            Console.Write("Enter a phone number :");
                            phoneNo = Console.ReadLine();
                            //allows this type of entry (123)-456-7890


                            Regex regex = new Regex(@"^?\(?\d{3}?\)??-??\(?\d{3}?\)??-??\(?\d{4}?\)??-?$");
                            if(regex.IsMatch(phoneNo))
                            {
                                
                                Console.Write(phoneNo + " is correct ");
                                Console.Write(System.Environment.NewLine);
                                
                                
                                
                            }
                            else
                            {
                                
                                Console.Write(phoneNo + " is incorrect ");
                                Console.Write(System.Environment.NewLine);
                                Console.Write(phoneNo + " wrong format .... registrastion failed ");
                                Console.Write(System.Environment.NewLine);
                            }
                           


                            Console.Write("Enter email :");
                            email = Console.ReadLine();
                            //Here we are checking the email correctness
                            Regex regex1 = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                            if (regex1.IsMatch(email))
                            {
                                Console.Write(email + " is correct ");
                                Console.Write(System.Environment.NewLine);
                                

                            }
                            else
                            {
                                Console.Write(email + " is incorrect and is not saved ");
                                Console.Write(System.Environment.NewLine);

                            }


                            var libraryUser = new User
                                (
                                id: id,
                                name: name,
                                login: login,
                                password: password,
                                birthdate: DateTime.Now,
                                phone: phoneNo,
                                mail: email
                                );

                            Console.WriteLine("Successful Registration");

                            users.Add(libraryUser);


                            string jsonString = JsonSerializer.Serialize(users);
                            File.WriteAllText("users.json", jsonString);

                            Console.ReadKey();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        return true;
                    case "5":

                        return false;
                    default:
                        return true;
                }
            }
        }
    }
}
