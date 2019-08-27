using System.Threading;
using AbstractFactory_Cars_Demo.Classes;
using AbstractFactory_Cars_Demo.Classes.Combustion;
using AbstractFactory_Cars_Demo.Classes.Contracts;
using AbstractFactory_Cars_Demo.Classes.Electric;

namespace AbstractFactory_Cars_Demo
{

    class Program
    {
        static void Main(string[] args)
        {
            //var car = new Car(new ElectricCarFactory(8, 4, "kW"));
            var car = new Car(new CombustionCarFactory(10, 8, "liters"));
            car.TurnOn();
            while (car.Engine.State != EngineState.Stopped)
            {
                car.AccelerateBy(30);
                Thread.Sleep(1000);
            }

            car.FuelStorage.StartFilling();
            Thread.Sleep(3000);
            if (car.FuelStorage.IsFilling)
            {
                car.FuelStorage.StopFilling();
            }
        }
    }
}
