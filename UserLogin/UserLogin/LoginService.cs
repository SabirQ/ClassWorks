using System;
using System.Collections.Generic;
using System.Text;

namespace UserLogin
{
    class LoginService
    {
        List<User> _users = new List<User>();
        List<User> Users => _users;
        public void Register()
        {

        }
        public string CheckName()
        {
            Console.WriteLine("Please enter your name");
            string name = Console.ReadLine().Trim().ToLower();
            do
            {
                Console.WriteLine("Please enter correct value");
                name = Console.ReadLine().Trim().ToLower();

            } while (name.Length < 3 || CheckLetters(name) == false);
            return Capitalized(name);

        }
        public string CheckSurname()
        {
            Console.WriteLine("Please enter your surname");
            string surname = Console.ReadLine().Trim().ToLower();
            do
            {
                Console.WriteLine("Please enter correct value");
                surname = Console.ReadLine().Trim().ToLower();

            } while (surname.Length < 3 || CheckLetters(surname) == false);
            return Capitalized(surname);
        }
        public string CheckUsername()
        {
            string username = Console.ReadLine().Trim();


        }
        public string CheckPassword()
        {
            Console.WriteLine("Please enter password");
            string password = Console.ReadLine();
            do
            {
                Console.WriteLine("Please enter correct value");
                password = Console.ReadLine();

            } while (CheckPassword(password) == false);
            return password;
        }
        public byte CheckAge()
        {
            Console.WriteLine("Please enter your age");
            byte age = 0;
            string str = (Console.ReadLine());
            bool result = byte.TryParse(str, out age);
            do
            {
                Console.WriteLine("Please enter correct value");
                str = (Console.ReadLine());
                result = byte.TryParse(str, out age);
            } while (!result || age < 7 && age > 200);
            return age;
        }
        public string Capitalized(string item)
        {
            StringBuilder str = new StringBuilder();
            str = str.Append(Char.ToUpper(item[0]));
            for (int i = 1; i < item.Length; i++)
            {
                str = str.Append(item[i]);

            }
            return str.ToString();
        }
        public bool CheckLetters(string item)
        {
            bool result = true;
            for (int i = 0; i < item.Length; i++)
            {
                if (!char.IsLetter(item[i]))
                {
                    result = false;
                    break;
                }
            }
            return result;
        }
        public bool CheckPassword(string password)
        {
            bool result = false;
            bool result1 = false;
            bool result2 = false;
            bool result3 = false;
            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsLetter(password[i]))
                {
                    if (char.IsUpper(password[i]))
                    {
                        result = true;
                    }
                    if (char.IsLower(password[i]))
                    {
                        result1 = true;
                    }
                }
                if (char.IsDigit(password[i]))
                {
                    result2 = true;
                }
            }
            
            if (result == true && result1 == true && result2 == true)
            {
                result3 = true;
            }
            return result3;
        }
        public bool CheckUsername(string username)
        {
            bool result = false;
            bool result1 = false;
            bool result2 = true;
            for (int i = 0; i < username.Length; i++)
            {
                if (char.IsLetter(username[i]))
                {
                    result = true;
                }
                if (char.IsDigit(username[i]))
                {
                    result1 = true;
                }
                if (!char.IsLetter(username[i]))
                {
                    result = true;
                }

            }
        }
    }
}
