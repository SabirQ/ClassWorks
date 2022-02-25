using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    partial class User    // Fields
    {
        public string Name;
        public string Surname;
        public string Username;
        public string Password;
        public int Id;
        public static int Counter = 0;
    }
    partial class User     //Constructor
    {
        public User()
        {
            Counter++;
            Id = Counter;
        }

    }
    
}

