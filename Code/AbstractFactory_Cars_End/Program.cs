using System.Threading;
using AbstractFactory_Cars_End.Classes;
using AbstractFactory_Cars_End.Classes.Combustion;
using AbstractFactory_Cars_End.Classes.Contracts;

namespace AbstractFactory_Cars_End
{
    class Program
    {
        static void Main(string[] args)
        {
            //var car = new Car(new CombustionCarFactory());
            var car = new Car(new ElectricCarFactory());
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
