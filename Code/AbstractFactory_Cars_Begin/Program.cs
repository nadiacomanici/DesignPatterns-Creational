using System.Threading;
using AbstractFactory_Cars_Begin.Classes;

namespace AbstractFactory_Cars_Begin
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car(new Engine(), new FuelStorage(10, 8, "liters"));

            // Start the car and let it accelerate and move until it runs out of fuel
            car.TurnOn();
            while (car.IsEngineRunning)
            {
                car.AccelerateBy(30);
                Thread.Sleep(1000);
            }

            // Start filling the fuel. If the fuel storage did not automatically stop after the 3 seconds, stop filling it.
            car.StartFillingFuelStorage();
            Thread.Sleep(3000);
            if (car.IsFuelStorageFilling)
            {
                car.StopFillingFuelStorage();
            }
        }
    }
}
