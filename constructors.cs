using System;

namespace learningCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // constructor = a special method in a class
            //               same name as the class name 
            //               can be used to assign arguments to fields when creating an object

            Car car1 = new Car("Ford", "Mustang", 2022, "red");
            Car car2 = new Car("Chevy", "Corvette", 2021, "blue");

            car1.Drive();
            car2.Drive();

            Console.ReadKey();
        }
    }
    class Car
    {
        String make;
        String model;
        int year;
        String color;

        public Car(String make, String model, int year, String color)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.color = color;
        }
        public void Drive()
        {
            Console.WriteLine("You drive the " + make + " " + model);
        }
    }
}
