using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedRacing
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfCars = int.Parse(Console.ReadLine());
            var cars = new List<Car>();

            for (int i = 0; i < numberOfCars; i++)
            {
                var carInfo = Console.ReadLine().Split(' ').ToArray();
                var model = carInfo[0];
                var fuel = double.Parse(carInfo[1]);
                var consumption = double.Parse(carInfo[2]);

                cars.Add(new Car(model, fuel, consumption));
            }

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                var tokens = input.Split(' ').ToArray();
                var currentModel = tokens[1];
                var distanceToTravel = double.Parse(tokens[2]);

                var currentCar = cars.Where(c => c.model == currentModel).FirstOrDefault();
                if (currentCar.HasEnoughFuel(distanceToTravel))
                {
                    currentCar.fuelAmount -= currentCar.fuelConsumption * distanceToTravel;
                    currentCar.distance += distanceToTravel;
                }
                else
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.model} {car.fuelAmount:f2} {car.distance}");
            }
        }
    }
}
