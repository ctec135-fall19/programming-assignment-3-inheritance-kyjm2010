//Author: Kyle McDonald
//Date:   10/24/2019
//CTEC 135: Microsoft Software Development with C#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3
{
    #region ipo
    // description of method: Program that demonstrates aggregation and 
    //                        composition
    // Inputs:  Owner, car, Vehicle and Engine classes with their respective
    //          properties, methods, and constructors
    // Outputs: aggregation shows a singular Car class as well as an owner and
    //          the list of cars they own.
    //          Composition shows the vehicle class creating a new engine class
    //          that is dependent on the life of the vehicle class
    // Behavior: Uses aggreagation and compilation to show how classes can 
    //           interract with eachother and either be independent or 
    //           dependent of one another.

    #endregion 
    class Program
    {
        static void Main(string[] args)
        {
            //create a new owner
            Owner b = new Owner("Kyle");
            Console.WriteLine("Initial list of cars owned");
            b.PrintState();
            Console.WriteLine();

            //create a couple cars independent from the owner 
            Car c = new Car("McClaren F1");
            Car d = new Car("Ferrari GTB4");

            //owner buys car b and the value is added to the owners list of 
            //cars
            b.BuyCar(c);
            Console.WriteLine("List of cars after buying car C");
            b.PrintState();
            Console.WriteLine();

            //attempt to sell a car that is not currently owned
            Console.WriteLine("Attempting to sell a car not owned by the owner");
            b.SellCar(d);
            Console.WriteLine();

            //buy car d
            b.BuyCar(d);
            Console.WriteLine("Now that car d is bought, the owner can sell it");
            b.PrintState();
            Console.WriteLine();

            //sell a car 
            b.SellCar(d);
            Console.WriteLine();
            //show that car d is still available
            d.PrintState();

            //create a vehicle using the master constructor
            Console.WriteLine();
            Console.WriteLine("Example of composition");
            Vehicle a = new Vehicle("Corvette", 6.2M);
            a.PrintState();

            //the engine has no independent value so we are unable to print 
            //its value separate from that of the vehicle. Conversely, we need
            //the 6.2 liter engine in order to create the Corvette
            
        }

        
    }
}
