using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Digital_Books_LIbrary.Catalogue;
using Digital_Books_LIbrary.Models;
using Digital_Books_LIbrary.Interfaces;

namespace Digital_Books_LIbrary
{
     public class User : IUser
    {
        public int ID { get; set; }
        
        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }

        public string PhoneNo { get; set; } 

        public List<string> Books { get; set; }

        public string Email { get; set; }

        public int AuthorId { get; set; }

        public enum Role { User , Administrator }

        public User(int id, string name,string login, string password, DateTime birthdate, string phone,string mail)
        {
            ID = id;
            Name = name;
            Login = login;
            Password = password;
            Birthdate = birthdate;
            PhoneNo = phone;
            Email = mail;
            //Books = new List<Book>();
        }

        public User()
        {

        }

        public User(string name, int id, string login)
        {
            Name = name;
            ID = id;
            Login = login;
        }

        public User(string name, int id, string login, string password, DateTime birthdate) : this(name, id, login)
        {
            Name = name;
            ID = id;
            Login = login;
            Password = password;
            Birthdate = birthdate;
        }



        public void Find()
        {
            
        }

        public void Add()
        {
            
        }

        public void Remove()
        {
            
        }
    }
}
