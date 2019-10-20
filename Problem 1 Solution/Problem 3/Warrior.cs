using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3
{
  
    class Warrior : Melee
    {
        private string name;

        public Warrior() : this("No Name")
        {
            Console.WriteLine("Warrior class default constructor body");
        }
        public Warrior(string Name) : base()
        {
            this.name = Name;
            Console.WriteLine("Warrior class Master constructor body");
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
            Console.WriteLine("Rage:\t {0}", Rage);
            Console.WriteLine("Health:\t {0}", healthPoints);
            Console.WriteLine("Level:\t {0}", level);
        }

    }
}
