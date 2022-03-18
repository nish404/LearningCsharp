using System;

namespace learningCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // abstract classes = modifier that indicates missing components or incomplete implementation

            Car car = new Car();
            Bicycle bicycle = new Bicycle();
            Boat boat = new Boat();
            //Vehicle vehicle = new Vehicle(); //can't create vehicle object

            Console.ReadKey();
        
        }
    }
    abstract class Vehicle
    {
        public int speed = 0;

        public void go()
        {
            Console.WriteLine("this vehicle is moving");
        }
    }
    class Car: Vehicle
    {
        public int wheels = 4;
        int maxSpeed = 500;
    }
    class Bicycle: Vehicle
    {
        public int wheels = 2;
        int maxSpeed = 50;
    }
    class Boat: Vehicle
    {
        public int wheels = 0;
        int maxSpeed = 100;
    }
}
