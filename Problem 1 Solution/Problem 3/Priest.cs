using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3
{
    class Priest : SpellCaster
    {
        private string name;

        public Priest() : this("No Name")
        {
            Console.WriteLine("Priest class default constructor body");
        }
        public Priest(string Name) : base()
        {
            this.name = Name;
            Console.WriteLine("Priest class Master constructor body");
        }

        public string GetName()
        {
            return name;
        }
        public void SetName(string Name)
        {
            name = Name;
        }

        public override void PrintState()
        {
            //Console.WriteLine("Private:\t {0}", privateInt);
            Console.WriteLine("Name:\t {0}", name);
            Console.WriteLine("Mana:\t {0}", Mana);
            Console.WriteLine("Health:\t {0}", healthPoints);
            Console.WriteLine("Level:\t {0}", level);
        }
    }
}
