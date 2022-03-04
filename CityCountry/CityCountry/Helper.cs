using System;
using System.Collections.Generic;
using System.Text;

namespace CityCountry
{
   static class Helper
    {
        public static void CityLIst(Country country)
        {
            foreach (City city in country.Cities)
            {
                Console.WriteLine(city);
            }
        }
        
    }
}
