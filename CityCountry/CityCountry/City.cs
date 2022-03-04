using System;
using System.Collections.Generic;
using System.Text;

namespace CityCountry
{
    class City
    {
        public int CityID;
        public string Name;
        public int Population;
        public static int count = 100;
        public City(string name,int population)
        {
            Name = name;
            Population = population;
            CityID = count;
            count++;
        }
        public override string ToString()
        {
            return $"Name:{Name}\nPopulation:{Population}";
        }
        
    }

}
