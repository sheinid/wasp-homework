using System;

namespace Autopark
{
    public class Program
    {
        static void Main(string[] args)
        {
            Autopark autopark = new Autopark("Autopark");

            PassengerCar psgCar1 = new PassengerCar("Kia", 240, 2011);
            PassengerCar psgCar2 = new PassengerCar("BMW", 300, 2014);
            PassengerCar psgCar3 = new PassengerCar("Mercedes", 320, 2006);

            Truck truck1 = new Truck("MAN", 390, 2011);
            Truck truck2 = new Truck("Scania", 380, 2009);
            Truck truck3 = new Truck("Iveco", 420, 2013);
            
            autopark.AddCarToAutopark(psgCar1);
            autopark.AddCarToAutopark(psgCar2);
            autopark.AddCarToAutopark(psgCar3);
            autopark.AddCarToAutopark(truck1);
            autopark.AddCarToAutopark(truck2);
            autopark.AddCarToAutopark(truck3);
            
            Console.WriteLine(autopark.ToString());
            Console.ReadKey();
        }
    }
}