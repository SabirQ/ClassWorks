using System;

namespace CityCountry
{
    class Program
    {
        static void Main(string[] args)
        {
            Country country = new Country("Azerbaycan");
            City city = new City("Barda", 300000);
            City city1 = new City("Barda", 1200);

            City city2 = new City("Baki", 4000000);
            country.AddCity(city);
            country.AddCity(city1);
            country.AddCity(city2);
            Console.WriteLine(country.Population);
            Console.WriteLine(city.Population);
            country.ChangePopulation(100, 400000);
            Console.WriteLine(city.Population);
            Console.WriteLine(country.Population);
            Console.WriteLine(city2.Population);
            country.ChangePopulation(102,1000000 );
            Console.WriteLine(city2.Population);
            Console.WriteLine(country.Population);
            Helper.CityLIst(country);
        }
    }
}
