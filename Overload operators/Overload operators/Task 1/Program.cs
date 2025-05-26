using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overload_operators.Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee(10000);
            Employee emp2 = new Employee(12000);

            emp1 = emp1 + 2000;
            Console.WriteLine($"emp1 salary after +2000: {emp1.Salary}");

            emp2 = emp2 - 1500;
            Console.WriteLine($"emp2 salary after -1500: {emp2.Salary}");

            Console.WriteLine($"emp1 == emp2: {emp1 == emp2}");
            Console.WriteLine($"emp1 != emp2: {emp1 != emp2}");
            Console.WriteLine($"emp1 < emp2: {emp1 < emp2}");
            Console.WriteLine($"emp1 > emp2: {emp1 > emp2}");
        }
    }
}
