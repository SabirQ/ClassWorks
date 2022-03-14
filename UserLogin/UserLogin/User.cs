using System;
using System.Collections.Generic;
using System.Text;

namespace UserLogin
{
    class User
    {
        private string _username;
        private string _password;
        private string _name;
        private string _surname;
        private byte _age;
        public string Username
        { get 
            {
                return _username;
            }
            set
            {
                _username = value;
            }
        }
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                _surname = value;
            }
        }
        public byte Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
            }
        }

        public User(string name,string surname,string username,string password,byte age)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Username = username;
            Password = password;
        }
    }
}
