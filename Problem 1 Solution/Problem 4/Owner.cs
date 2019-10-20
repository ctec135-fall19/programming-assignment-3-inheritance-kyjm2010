using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3
{
    public class Owner
    {
        //aggregation relationship 

        //
        public List<Car> Cars = new List<Car>
        {
            new Car("DeLorean"),
            new Car("Lamborghini Diablo"),

        };

        public string OwnerName = "";

        public Owner(string Name)
        {
            OwnerName = Name; 
        }

        public void PrintState()
        {
            Console.WriteLine("Owner:\t {0}", OwnerName);
           foreach(Car element in Cars)
            {
                Console.WriteLine("Car:\t {0}", element.CarName);
            }
        }
    }
    //simple car class that takes in a string name value
    public class Car
    {
        public string CarName = "";

        public Car(string name)
        {
            CarName = name;
        }

        public void PrintState()
        {
            Console.WriteLine("Car Name: {0}", CarName);
        }
    }
}
