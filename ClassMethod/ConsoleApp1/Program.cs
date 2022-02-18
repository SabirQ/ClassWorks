using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("BMW","e39","black",240);
            Console.WriteLine(car.Info());
            Bus bus = new Bus("mercedes", "r45", "red", 190, 56);
            Console.WriteLine(bus.Override());
            
        }
    }
    


        
    
    
        

}
