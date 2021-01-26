using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace Digital_Books_LIbrary.Services
{
    class Register
    {
        public  string Name { get; set; }
        public  int age { get; set; }
        public string password { get; set; }
        public string login { get; set; }
        private string _email;
        private int _phoneNo;

       public string Email
        {
            //check the correctness of the email
            get => _email;
            private set
            {
                Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                Match match = regex.Match(_email);
                if (regex.IsMatch(value))
                {
                     Console.Write(_email + " is correct");
                    _email = value;
                    
                }
                    
                else
                {
                    Console.Write(_email + " is incorrect");
                }
                    


            }
        }

        public int PhoneNo
        {
            get => _phoneNo;  
            set
            {
                //Here we check the correctness of the number format
                //allows this type of entry (123)-456-7890
                Regex regex = new Regex(@"^?\(?\d{3}?\)??-??\(?\d{3}?\)??-??\(?\d{4}?\)??-?$");
                if (regex.IsMatch(value.ToString()))
                {
                    Console.Write(_phoneNo + " is correct");
                    _phoneNo = value;

                }

                else
                {
                    Console.Write(_phoneNo + " is incorrect");
                }
                _phoneNo = value;
                    }

        }  


    }

   }



