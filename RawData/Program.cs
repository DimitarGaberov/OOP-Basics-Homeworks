using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawData
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());
            var cars = new List<Car>();
            for (int i = 0; i < count; i++)
            {
                var carInfo = Console.ReadLine().Split(' ').ToArray();
                var model = carInfo[0];
                var engine = new Engine(int.Parse(carInfo[1]), int.Parse(carInfo[2]));
                var cargo = new Cargo(int.Parse(carInfo[3]), carInfo[4]);
                var firstTire = new Tire(double.Parse(carInfo[5]), int.Parse(carInfo[6]));
                var secondTire = new Tire(double.Parse(carInfo[7]), int.Parse(carInfo[8]));
                var thirdTire = new Tire(double.Parse(carInfo[9]), int.Parse(carInfo[10]));
                var fourthTire = new Tire(double.Parse(carInfo[11]), int.Parse(carInfo[12]));

                var car = new Car(model, engine, cargo, firstTire, secondTire, thirdTire, fourthTire);
                cars.Add(car);
            }

            var command = Console.ReadLine();

            if (command == "fragile")
            {
                foreach (var car in cars.Where(c => c.Cargo.Type == command && (c.FirstTire.Pressure < 1
                                                                            || c.SecondTire.Pressure < 1
                                                                            || c.ThirdTire.Pressure < 1
                                                                            || c.FourthTire.Pressure < 1)))
                {
                    Console.WriteLine(car.Model);
                }
            }
            else
            {
                foreach (var car in cars.Where(c => c.Cargo.Type == command && c.Engine.Power > 250))
                {
                    Console.WriteLine(car.Model);
                }
            }
        }
    }
}
