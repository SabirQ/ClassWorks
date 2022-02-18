using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Car
    {
        public Car()
        {
            Console.WriteLine("Car created");
        }
        public Car(string brand, string model) : this()
        {
            Brand = brand;
            Model = model;
        }
        public Car(string brand, string model, string color, int maxspeed) : this(brand, model)
        {

            Color = color;
            MaxSpeed = maxspeed;
        }
        public string Brand;
        public string Model;
        public string Color;
        public int MaxSpeed;

        public string Info()
        {
            return $"Brand={Brand}\nModel={Model}\nColor={Color}\nMaxSpeed={MaxSpeed}";
        }
        public string BrandModel()
        {
            return $"Brand={Brand}\nModel={Model}";
        }
    }
}
