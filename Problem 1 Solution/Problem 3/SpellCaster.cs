using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_3
{
    //soellcaster class is also able to inherit from the character class
    public class SpellCaster : Character
    {
        //create a new value unique to spellcasters
        protected int Mana;

        //set the default melee constructor to reflect a default value of
        //25 for mana
        public SpellCaster() : this(25)
        {
            Console.WriteLine("spellcaster class default constructor body");
        }
        public SpellCaster(int mana) : base()
        {
            this.Mana = mana;
            Console.WriteLine("Spellcaster class master constructor body");
        }

        public override void PrintState()
        {
            //we can see that privateInt is inaccessible due to protection 
            //level, however protected variables are ableto be inheritted 
            //by the childclass

            //uncomment the next line to see the error that is thrown
            //Console.WriteLine("PrivateInt: {0}", privateInt);
            Console.WriteLine("Mana:\t {0}", Mana);
            Console.WriteLine("Health:\t {0}", healthPoints);
            Console.WriteLine("Level:\t {0}", level);
        }
    }
}