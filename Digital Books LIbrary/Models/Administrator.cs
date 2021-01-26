using Digital_Books_LIbrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Digital_Books_LIbrary.Models
{
    class Administrator : IUser
    {
        public int ID { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get ; set; }
        public DateTime Birthdate { get; set; }
        public string PhoneNo { get; set; }
        public List<string> Books {get; set; }
        public string Email { get; set; }
        public int AuthorId { get; set; }

        public void Add()
        {
            //add a new user
        }

        public void Find()
        {
            //find a new user
        }

        public void Remove()
        {
            //remove a user
        }
    }
}
