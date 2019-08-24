using System;
using System.Threading;
using AbstractFactory_Cars_Demo.Classes;

namespace AbstractFactory_Cars_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            DoWork(new CombustionCarFactory());
            Console.WriteLine("==========================");
            DoWork(new ElectricCarFactory());
        }

        private static void DoWork(ICarFactory factory)
        {
            var car = new Car(factory);
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
