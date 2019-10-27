using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_3
{
    public class Character
    {
        //fields
        private int privateInt;
        public int healthPoints;
        public int level;

        //constructors

        //set default values for the character class. These values should not
        //be accessible for players, they are simply starting values for any 
        //character
        public Character()
        {
            //privateInt = 25;
            healthPoints = 100;
            level = 1;
            Console.WriteLine("Character default constructor");
        }

        
        public virtual void PrintState()
        {
            //print the state of the different values within the class
            //notice this is the only class that is able to share privateInt
            Console.WriteLine("PrivateInt: {0}", privateInt);
            Console.WriteLine("Health:\t {0}", healthPoints);
            Console.WriteLine("Level:\t {0}", level);
        }
    }
}