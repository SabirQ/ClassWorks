using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    static class Helper
    {
        public static User[] UserAdd(User[] users,User user)
        {
            Array.Resize(ref users, users.Length + 1);
            users[users.Length - 1] = user;
            return users;
        }
        public static User FindUser(User[] users,int id)
        {
            User result = new User();
            foreach (User user in users)
            {
                if (user.Id==id)
                {
                    result = user;

                    
                }
                
                
            }
            return result;
        }
        public static void ShowUser(User[] users)
        {
            if (users.Length>0)
            {
                foreach (User user in users)
                {
                    Console.WriteLine($"Name:{user.Name}\nSurname:{user.Surname}\nUsername:{user.Username}\nPassword:{user.Password}\nID:{user.Id}");
                }
            }
            else
            {
                Console.WriteLine("users array is empty");
            }
            
            
        }
    }
}
