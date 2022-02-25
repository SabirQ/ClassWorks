using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            UserOperation operation = new UserOperation();
            
            operation.CreateAccount("sabir", "quliyev", "sabirq", "1234567s");
            operation.CreateAccount("sabi", "quliye", "sabi", "12345");
            operation.CreateAccount("sa", "qu", "sab", "123");
            

            Helper.ShowUser(operation.users);

            Console.WriteLine(Helper.FindUser(operation.users, 3));

            
           
            Helper.ShowUser(operation.users);
        }
    }
}
