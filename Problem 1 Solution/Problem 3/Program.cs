using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3
{
    class Program
    {
        #region Main(string[] args)
        // description of method: Class heirarchy that demonstrates the effect
        //of the private and protected access modifiers on access to fields 
        //from child classes. As well as demonstrating the calling sequence of
        //constructors and demonstrating the setting and getting field values 
        // Inputs: Character, Melee, SpellCaster, Warrior and Priest classes 
        //with their respective properties, methods, and constructors
        // Outputs: Console.writelines highlighting the various constructor
        //calls as they are accessed. Showing how a private int can only be 
        //shared by the class it resides in. Set and get Name methods displayed
        //and labeled
        // Behavior: Prints the default constructor of the character class with
        //its default values. Runs through the other class default constructors
        //showing how values are inherited from base classes while also showing
        //the calling sequence these constructors go through. Set and get 
        //methods are instantiated and values are printed to the user.
        #endregion

        static void Main(string[] args)
        {
            //print the default constructor and it's values
            //take note of privateInt
            Character a = new Character();
            a.PrintState();

            //use the default constructor of the melee class
            //to show that protected values are passed and
            //private values cannot be passed
            //Notice the constructor sequence character default runs first
            //followed by melee master, and finally melee default
            //we see a new value of Rage being added to our new melee character
            Console.WriteLine();
            Melee b = new Melee();
            b.PrintState();

            //same thing takes place as above; however, we can see Rage is 
            //instead replaced with mana for this particular class
            Console.WriteLine();
            SpellCaster c = new SpellCaster();
            c.PrintState();

            //Constructor sequence now includes the warrior master and 
            //warrior default body respectively
            //from the default constructor, we can see the name is simply
            //set to "no name" prior to setting
            Console.WriteLine();
            Warrior d = new Warrior();
            d.PrintState();
            //We call the warrior SetName method to give our character a name
            d.SetName("Hulkhands");
            Console.WriteLine();
            //printstate reflects our new values
            d.PrintState();

            //same thing as above just being showcased in a separate grandchild
            //class for good measure
            Console.WriteLine();
            Priest e = new Priest();
            e.PrintState();
            e.SetName("Chuck");
            Console.WriteLine();
            e.PrintState();

            //using the warrior and priest GetName methods inside a writeline
            //statement returns the single name value for the respective 
            //characters
            Console.WriteLine();
            Console.WriteLine("Using get method to show thename of our warrior:");
            Console.WriteLine(d.GetName());
            Console.WriteLine();
            Console.WriteLine("Using get method to show thename of our Priest:");
            Console.WriteLine(e.GetName());

            
        }
    }
}
