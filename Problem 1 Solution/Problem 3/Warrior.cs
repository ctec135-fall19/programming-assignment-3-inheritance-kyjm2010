using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3
{
    //warrior class inherits from the melee class

    class Warrior : Melee
    {
        //create a value for a name
        private string name;

        //set the default warrior constructor to reflect a default value of
        //"No Name" for name
        public Warrior() : this("No Name")
        {
            Console.WriteLine("Warrior class default constructor body");
        }
        //master constructor for warrior class that accepts a string argument 
        //for name
        public Warrior(string Name) : base()
        {
            this.name = Name;
            Console.WriteLine("Warrior class Master constructor body");
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

        //Print values associated with the warrior character
        public override void PrintState()
        {
            //uncomment the line below to see the error when attempting to 
            //pass private values via inheritance

            //Console.WriteLine("Private:\t {0}", privateInt);
            Console.WriteLine("Name:\t {0}", name);
            Console.WriteLine("Rage:\t {0}", Rage);
            Console.WriteLine("Health:\t {0}", healthPoints);
            Console.WriteLine("Level:\t {0}", level);
        }

    }
}
