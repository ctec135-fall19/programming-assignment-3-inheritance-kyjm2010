using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_3
{
    //melee class inherits from the character class
    public class Melee : Character
    {
        //instantiate a new value 
        protected int Rage;

        //set the default melee constructor to reflect a default value of
        //25 for Rage
        public Melee() : this(25)
        {
            Console.WriteLine("Melee class default constructor body");
        }
        public Melee(int rage) : base()
        {
            this.Rage = rage;
            Console.WriteLine("Melee class master constructor");
        }

        public override void PrintState()
        {
            //we can see that privateInt is inaccessible due to protection 
            //level, however protected variables are ableto be inheritted 
            //by the childclass
            //Console.WriteLine("PrivateInt: {0}", privateInt);
            Console.WriteLine("Rage:\t {0}", Rage);
            Console.WriteLine("Health:\t {0}", healthPoints);
            Console.WriteLine("Level:\t {0}", level);
        }
    }
}