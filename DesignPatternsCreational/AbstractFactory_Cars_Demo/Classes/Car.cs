using System;
using System.Timers;

namespace AbstractFactory_Cars_Begin.Classes
{
    public class Car
    {
        private Timer _fuelComsumptionTimer;

        public IEngine Engine { get; private set; }
        public FuelStorage FuelStorage { get; private set; }
        public int Speed { get; private set; }

        public Car(ICarFactory carFactory)
        {
            Engine = carFactory.CreateEngine();
            FuelStorage = carFactory.CreateFuelStorage();

            _fuelComsumptionTimer = new Timer(500);
            _fuelComsumptionTimer.Elapsed += FuelComsumptionTimer_Elapsed;
        }

        public void TurnOn()
        {
            if (Engine.State == EngineState.Stopped)
            {
                Engine.State = EngineState.Started;
                Console.WriteLine($"Car is turned on and has FuelStorage with {FuelStorage.AvailableUnits} {FuelStorage.Unit}");
                _fuelComsumptionTimer.Start();
            }
            else
            {
                throw new InvalidOperationException("The car is already started.");
            }
        }

        public void AccelerateBy(int speedIncrement)
        {
            if (Engine.State == EngineState.Started)
            {
                Engine.State = EngineState.Moving;
            }

            if (Engine.State == EngineState.Moving)
            {
                Speed += speedIncrement;
                Console.WriteLine($"Car accelerated by {speedIncrement} km/h. Speed is now {Speed} km/h");
            }
            else
            {
                throw new InvalidOperationException("You should first start the car and then accelerate.");
            }
        }

        public void TurnOff()
        {
            if (Engine.State != EngineState.Stopped)
            {
                Engine.State = EngineState.Stopped;
                Console.WriteLine("Car is turned off");
                _fuelComsumptionTimer.Stop();
            }
            else
            {
                throw new InvalidOperationException("The car is already stopped.");
            }
        }

        private void FuelComsumptionTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            var consumption = Engine.GetComsumptionInHalfASecondBasedOnSpeed(Speed);
            FuelStorage.AvailableUnits -= consumption;
            if (FuelStorage.AvailableUnits > 0)
            {
                Console.WriteLine($"Consumption={consumption} {FuelStorage.Unit} for speed={Speed} km/h so, FuelStorage has {FuelStorage.AvailableUnits} {FuelStorage.Unit}");
            }
            else
            {
                FuelStorage.AvailableUnits = 0;
                Console.WriteLine("Fuel storage is empty, so the car is being stopped");
                TurnOff();
            }
        }
    }
}
