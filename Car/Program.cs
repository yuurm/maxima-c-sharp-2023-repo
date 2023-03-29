using System;

namespace Car
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            Car car = new Car(2010, Car.CarColor.Black, 10000, 50);
            

            Console.WriteLine(car.GetCarYear());
            Console.WriteLine(car.GetMileage());
            
            
            Console.WriteLine($"1. {car}");
            
            car.GoOneMile();
            car.GoOneMile();
            car.GoOneMile();
            
            Console.WriteLine(car.GetMileage());
            
            Console.WriteLine(car.GetCarYear());
           
            Console.WriteLine($"2. {car}");
            
            Console.WriteLine(car.GetFuel());
            
            car.ConsumeFuel(1);
            
            Console.WriteLine(car.GetFuel());
            
            car.Refuel(1);
            
            Console.WriteLine(car.GetFuel());
            
            

           
            
        }

    }
}