using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_principles_2
{
    public class Chelo : MusicalInstrument
    { 
        public Chelo(string name,string description):base(name,description) { }
        public override void Sound()
        {
            Console.WriteLine("Звук: Глибокий, м'який і насичений звук віолончелі.");
        }

        public override void History()
        {
            Console.WriteLine("Історія: Віолончель розвивалась у Європі з XVI століття.");
        }
    }

}
