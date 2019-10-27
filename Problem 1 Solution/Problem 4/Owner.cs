
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

        //list of cars can be passed into the owner class
        public List<Car> Cars = new List<Car>();

        //create a method to sell a car by adding a specific car name to
        //the Cars list
        public void BuyCar(Car car)
        {
            Cars.Add(car);

        }

        //create a method to sell a car by removing a specific car name from 
        //the Cars list
        public void SellCar(Car car)
        {
            if (!Cars.Remove(car))
            {
                Console.WriteLine("You can't sell what you don't own!");
            }
            else
            {
                Cars.Remove(car);
                Console.WriteLine("You sold your {0}", car.CarName);
            }
        }

        //method that creates an owner and assigns a given name
        public string OwnerName;

        public Owner(string Name)
        {
            OwnerName = Name; 
        }

        
        public void PrintState()
        {
            //using a foreach loop to print each car the owner owns
            Console.WriteLine("Owner:\t {0}", OwnerName);
           foreach(Car a in Cars)
            {
                
                Console.WriteLine(a.CarName);
            }
           
        }
    }
    //simple car class that takes in a string name value
    public class Car
    {
        public string CarName;

        public Car(string name)
        {
            CarName = name;
        }

        public void PrintState()
        {
            Console.WriteLine(CarName);
        }
    }
}
