using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2
{
    class SportsCar : Vehicle
    {

        //fields 

        protected string vehicleModel;
        protected string trimPackage;

        //constructors
        public SportsCar() { }
        public SportsCar(string Make, int invNum, string Model, string Trim): base(Make, invNum)
        {
            this.vehicleModel = Model;
            this.trimPackage = Trim;
        }

        //methods

        public void SportsCarMethod()
        {
            Console.WriteLine("This is a message that prints from the child class");
        }

        public override void PrintState()
        {
            Console.WriteLine("Vehicle Object");
            Console.WriteLine("\tVehicle Make: {0}", vehicleMake);
            Console.WriteLine("\tVehicle Model: {0}", vehicleModel);
            Console.WriteLine("\tTrim Package: {0}", trimPackage);
            //Console.WriteLine("\tThis vehicle is at lot: {0}", inventoryNumber);
        }
    }
}
