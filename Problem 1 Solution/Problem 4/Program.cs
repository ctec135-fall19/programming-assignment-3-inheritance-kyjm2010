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
            Owner b = new Owner("Kyle");
            Console.WriteLine("Initial list of cars owned");
            b.PrintState();
            Console.WriteLine();

            Car c = new Car("McClaren F1");
            Car d = new Car("Ferrari GTB4");

            b.BuyCar(c);
            Console.WriteLine("List of cars after buying car C");
            b.PrintState();
            Console.WriteLine();

            Console.WriteLine("Attempting to sell a car not owned by the owner");
            b.SellCar(d);
            Console.WriteLine();

            b.BuyCar(d);
            Console.WriteLine("Now that car d is bought, the owner can sell it");
            b.PrintState();
            Console.WriteLine();

            b.SellCar(d);


            Console.WriteLine();
            Console.WriteLine("Example of composition");
            Vehicle a = new Vehicle("Corvette", 6.2M);
            a.PrintState();
        }

        
    }
}
