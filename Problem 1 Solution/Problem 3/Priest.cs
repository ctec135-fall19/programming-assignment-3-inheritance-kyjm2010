using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3
{
    //priest class inherits from the spellcaster class
    class Priest : SpellCaster
    {
        //create a value for a name
        private string name;

        //set the default priest constructor to reflect a default value of
        //"No Name" for name
        public Priest() : this("No Name")
        {
            Console.WriteLine("Priest class default constructor body");
        }

        //master constructor for priest class that accepts a string argument 
        //for name
        public Priest(string Name) : base()
        {
            this.name = Name;
            Console.WriteLine("Priest class Master constructor body");
        }

        //setup get and set methods for the name field
        public string GetName()
        {
            return name;
        }
        public void SetName(string Name)
        {
            name = Name;
        }

        //Print values associated with the character
        public override void PrintState()
        {
            //uncomment the line below to see the error when attempting to 
            //pass private values via inheritance

            //Console.WriteLine("Private:\t {0}", privateInt);
            Console.WriteLine("Name:\t {0}", name);
            Console.WriteLine("Mana:\t {0}", Mana);
            Console.WriteLine("Health:\t {0}", healthPoints);
            Console.WriteLine("Level:\t {0}", level);
        }
    }
}
