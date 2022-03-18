using System;

Namespace learningCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // static = modifier to declare a a static member which belongs to the class itself rather than any specific object

            Car car1 = new Car("McLaren");
            Car car2 = new Car("Lotus");
            Car car3 = new Car("Tesla");

            Console.WriteLine(Car.numberOfCars);
            Car.StartRace();

            Console.ReadKey();
        }
        class Car
        {
            String model;
            public static int numberOfCars;

            public Car(String model)
            {
                this.model = model;
                numberOfCars++;
            }
            public static void StartRace()
            {
                Console.WriteLine(("the race has begun"));
            }
        }
    }
}
