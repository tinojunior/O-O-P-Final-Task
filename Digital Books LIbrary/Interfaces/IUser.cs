using System;
using System.Collections.Generic;
using System.Text;

namespace Digital_Books_LIbrary.Interfaces
{
    interface IUser
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

        public enum Role { User, Administrator }

        void Find();
        void Add();
        void Remove();

    }
}
