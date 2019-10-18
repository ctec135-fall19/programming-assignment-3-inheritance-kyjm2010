using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle a = new Vehicle("Ford", 20102335);
            SportsCar sc = new SportsCar();
            a.PrintState();
            sc.PrintState();
            a.SetMake("Chevrolet");
            a.SetInv(90909090);
            a.PrintState();
            sc.PrintState();
            sc.GetMake();
            sc.VehicleMethod();
        }

        
    }
}
