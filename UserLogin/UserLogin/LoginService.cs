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

            } while (surname.Length<3||CheckLetters(surname)==false);            
            return Capitalized(surname);
        }
        public string CheckUsername()
        {
            string username = Console.ReadLine().Trim();
            

        }
        public string CheckPassword()
        {
            string password =Console.ReadLine();
        }
        public byte CheckAge()
        {
            Console.WriteLine("Please enter your age");
            byte age= 0;
            string str = (Console.ReadLine());
            bool result = byte.TryParse(str, out age);
            do
            {
                Console.WriteLine("Please enter correct value");
                str = (Console.ReadLine());
                result = byte.TryParse(str, out age);
            } while (!result||age<7&&age>200);
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
       
    }
}
