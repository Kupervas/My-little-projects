using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_principles_2
{
    public class Ukulele: MusicalInstrument
    {
        public Ukulele(string name, string description):base(name, description) { }

        public override void Sound()
        {
            Console.WriteLine("Звук: Легкий, веселий і дзвінкий звук укулеле.");
        }

        public override void History()
        {
            Console.WriteLine("Історія: Укулеле походить з Гаваїв, з'явилося у XIX столітті.");
        }
    }
}
