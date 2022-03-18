using System;

namespace learningCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // polymorphism = Greek word that means to "have many forms"
            //                objects can be identified by more than one type
            //                ex. a dog is also: canine, animal, organism

            Car car = new Car();
            Bicycle bicycle = new Bicycle();
            Boat boat = new Boat();

            Vehicle[] vehicles = { car, bicycle, boat };

            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.go();
            }

            Console.ReadKey();

        }
    }
    class Vehicle
    {
        public virtual void Go()
        {

        }
    }
    class Car: Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("the car is moving");
        }
    }
    class Bicycle: Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("the bicycle is moving");
        }
    }
    class Boat: Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("the boat is moving");
        }
    }
}
