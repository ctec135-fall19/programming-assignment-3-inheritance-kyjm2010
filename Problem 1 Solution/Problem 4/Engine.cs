using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3
{
    //composition relationship

    //the class engine defines a class with a single decimal variable
    // and a master constructor
    class Engine
    {
        public decimal Size;

        public Engine(decimal size)
        {
            this.Size = size;
        }
    }

    class Vehicle
    {
        //the vehicle class creates an engine within it's master constructor,
        //because of this if the vehicle is destroyed, the engine is destroyed
        //as well. 

        //setting properties for an engine class and VehicleModel to be called 
        //upon later in printstate
        public Engine engine;
        public string VehicleModel = "";

        //the master vehicle constructor passes a decimal value which is then
        //used to create a new instance of then egine class. Without the engine
        //the vehicle cannot be created, without the vehicle the engine does 
        //not exist
        public Vehicle (string Model, decimal iM)
        {
            VehicleModel = Model;
            engine = new Engine(iM);
            
        }
        //printsate that shows the vehicle model and engine size defined
        public void PrintState()
        {
            Console.WriteLine("Vehicle Model:\t {0}", VehicleModel);
            Console.WriteLine("Engine Size:\t {0}L", engine.Size);
        }
    }
}
