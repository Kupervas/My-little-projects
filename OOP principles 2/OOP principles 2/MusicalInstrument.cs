using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_principles_2
{
    public abstract class MusicalInstrument
    {
        private string name;
        private string description;

        public string Name
        {
            get { return name; }
            protected set { name = value; }
        }

        public string Description
        {
            get { return description; }
            protected set { description = value; }
        }
        public MusicalInstrument(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public virtual void Show()
        {
            Console.WriteLine($"Назва: {Name}"); 
        }

        public virtual void Desc()
        {
            Console.WriteLine($"Опис: {Description}");
        }
        public abstract void Sound();
        public abstract void History();

    }
}

