using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2
{
    class Vehicle
    {
        //field

        protected string vehicleMake;
        private int inventoryNumber;

        //constructors

        public Vehicle() { }
        public Vehicle(string Make, int invNum)
        {
            this.vehicleMake = Make;
            this.inventoryNumber = invNum;
        }

        //methods
        public void VehicleMethod()
        {
            Console.WriteLine("This is a message that prints from the parent class");
        }

        public string GetMake() 
        { 
            return vehicleMake; 
        }

        public void SetMake(string Make)
        {
            vehicleMake = Make;
        }

        public int GetInvId()
        {
            return inventoryNumber;
        }

        public void SetInv(int Num)
        {
            inventoryNumber = Num;
        }

        public virtual void PrintState()
        {
            Console.WriteLine("Vehicle Object");
            Console.WriteLine("\tVehicle Make: {0}", vehicleMake);
            Console.WriteLine("\tThis vehicle is in lot: {0}", inventoryNumber);
        }

    }
}
