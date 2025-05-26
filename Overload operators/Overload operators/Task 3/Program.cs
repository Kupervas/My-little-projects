using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Overload_operators.Task_3
{
     class Program
     {
        static void Main(string[] args)
        {
            CreditCard card1 = new CreditCard(1000.50m, 123);
            CreditCard card2 = new CreditCard(500.00m, 456);
            CreditCard card3 = new CreditCard(2000.00m, 123);

            card1 = card1 + 250.75m;
            Console.WriteLine($"card1 amount after +250.75: {card1.Amount}");

            card2 = card2 - 100.00m;
            Console.WriteLine($"card2 amount after -100.00: {card2.Amount}");

            Console.WriteLine($"card1 == card2: {card1 == card2}"); 
            Console.WriteLine($"card1 == card3: {card1 == card3}"); 

            Console.WriteLine($"card1 != card2: {card1 != card2}"); 

            Console.WriteLine($"card1 > card2: {card1 > card2}");
            Console.WriteLine($"card2 < card3: {card2 < card3}");
        }
    }
}