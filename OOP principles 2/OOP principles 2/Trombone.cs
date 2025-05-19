using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_principles_2
{
    public class Trombone : MusicalInstrument
    {
        public Trombone(string name, string description) : base(name, description) { }

        public override void Sound()
        {
            Console.WriteLine("Звук: Гучний і глибокий звук тромбона.");
        }

        public override void History()
        {
            Console.WriteLine("Історія: Тромбон був створений у XV столітті в Європі.");
        }
    }
}
