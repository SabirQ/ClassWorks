using System;
using System.Collections.Generic;
using System.Text;

namespace CityCountry
{
    class Country
    {
        public int CountryID;
        public string Name;
        public int Population;
        public static int Counter=1;
        public City[] Cities = new City[0];
        public Country(string name)
        {
            Name = name;            
            CountryID= Counter;
            Counter++;
        }

        public override string ToString()
        {
            return Name;
        }
        public void AddCity(City city)
        {
            if (CheckExistence(city))
            {
                Array.Resize(ref Cities, Cities.Length + 1);
                Cities[Cities.Length - 1] = city;
                Population += city.Population;
                Console.WriteLine("Elave edildi ,brat");
            }
            else
            {
                Console.WriteLine("Bu adda sheher artiq movcuddur,brat");
            }
            
        }
        public bool CheckExistence(City city)
        {
            bool result = true;
            foreach (City item in Cities)
            {
                if (item.Name==city.Name)
                {
                    result = false;
                    
                }
            }
            return result;
        }
        public void ChangePopulation(int id,int newp)
        {
            City ExCity = null;
            foreach (City item in Cities)
            {
                if (item.CityID==id)
                {
                    ExCity = item;
                }
            }
            if (ExCity!=null)
            {
                int difference = ExCity.Population - newp;
                ExCity.Population = newp;
                Population -= difference;
                Console.WriteLine("deyishdik ,brat");
            }
            else
            {
                Console.WriteLine("bele sheher yoxdu,brat");
            }
        }
    }
}
