using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overload_operators.Task_2
{
    public class City
    {
        public int Population { get; set; }
        public City(int population)
        {
            Population = population;
        }
        public static City operator +(City city, int amount)
        {
            return new City(city.Population + amount);
        }
        public static City operator +(int amount, City city)
        {
            return new City(city.Population + amount);
        }
        public static City operator -(City city, int amount)
        {
            return new City(city.Population - amount);
        }
        public static bool operator ==(City city1, City city2)
        {
            if (ReferenceEquals(city1, city2)) return true;
            if (city1 is null || city2 is null) return false;
            return city1.Population == city2.Population;
        }
        public static bool operator !=(City city1, City city2)
        {
            return !(city1 == city2);
        }
        public static bool operator <(City city1, City city2)
        {
            return city1.Population < city2.Population;
        }
        public static bool operator >(City city1, City city2)
        {
            return city1.Population > city2.Population;
        }
        public override bool Equals(object obj)
        {
            if (obj is City city)
                return this == city;
            return false;
        }
        public override int GetHashCode()
        {
            return Population.GetHashCode();
        }
    }
}