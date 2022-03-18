using System;

namespace learningCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Car[] garage = { new Car("McLaren"), new Car("Lotus"), new Car("Aston Martin") };

            foreach (Car car in garage)
            {
                Console.WriteLine(car.model);
            }

            Console.ReadKey();
        
        }
        class Car
        {
            public String model;

            public Car(String model)
            {
                this.model = model;
            }
        }
    }
}
