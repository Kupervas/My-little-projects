using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overload_operators.Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            City city1 = new City(100000);
            City city2 = new City(650000);

            city1 = city1 + 200000;
            Console.WriteLine($"city1 population after +200000: {city1.Population}");

            city2 = city2 - 150000;
            Console.WriteLine($"city2 population after -150000: {city2.Population}");

            Console.WriteLine($"city1 == city2: {city1 == city2}");
            Console.WriteLine($"city1 != city2: {city1 != city2}");
            Console.WriteLine($"city1 < city2: {city1 < city2}");
            Console.WriteLine($"city1 > city2: {city1 > city2}");
        }
    }
}
