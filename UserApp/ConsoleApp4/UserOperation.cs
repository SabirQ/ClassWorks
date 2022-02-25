using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class UserOperation : IAccount
    {


        public User[] users = { };

        public void CreateAccount(string name, string surname, string username, string password)
        {
            User user = new User();

            user.Name = name;
            user.Surname = surname;
            user.Username = username;
            user.Password = password;
            Helper.UserAdd(users, user);

        }




    } 
}
