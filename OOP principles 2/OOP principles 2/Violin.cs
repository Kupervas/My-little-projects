using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_principles_2
{
      public class Violin : MusicalInstrument
    {
        public Violin(string name, string description) : base(name, description) { }

        public override void Sound()
        {
            Console.WriteLine("Звук: Високий мелодійний звук скрипки");
        }
        public override void History()
        {
            Console.WriteLine("Історія: Скрипка виникла в Італії у XVI столітті.");
        }
    }
}
