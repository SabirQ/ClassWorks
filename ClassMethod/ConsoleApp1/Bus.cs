using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Bus:Car
    {
        public int PassengerCount;
        public Bus(string brand, string model, string color, int maxspeed, int count) : base(brand, model, color, maxspeed)
        {
            PassengerCount = count;
        }
        public string Override()
        {
            return Info() + $"\nPassengerCount={PassengerCount}";
        }
    }
}
