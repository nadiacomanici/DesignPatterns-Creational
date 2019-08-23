using System.Threading;
using AbstractFactory_Cars_Begin.Classes;

namespace AbstractFactory_Cars_Begin
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car(new Engine(), new FuelStorage(10, 8, "liters"));
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
