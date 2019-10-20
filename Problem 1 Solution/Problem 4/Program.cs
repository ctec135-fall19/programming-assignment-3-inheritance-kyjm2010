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
            Console.WriteLine("Example of aggregation");
            Car a = new Car("Mustang");
            a.PrintState();

            Owner b = new Owner("Kyle");
            b.PrintState();

            Console.WriteLine();
            Console.WriteLine("Example of composition");
            Vehicle c = new Vehicle("Corvette", 6.2M);
            c.PrintState();
        }

        
    }
}
