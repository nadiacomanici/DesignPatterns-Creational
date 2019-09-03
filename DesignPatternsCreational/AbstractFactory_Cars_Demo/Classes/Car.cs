using System;
using System.Timers;

namespace AbstractFactory_Cars_Demo.Classes
{
    public class Car
    {
        private Timer _fuelComsumptionTimer;

        private readonly Engine _engine;
        private readonly FuelStorage _fuelStorage;

        public int Speed { get; private set; }

        public bool IsEngineRunning
        {
            get { return _engine.State != EngineState.Stopped; }
        }

        public bool IsFuelStorageFilling
        {
            get { return _fuelStorage.IsFilling; }
        }

        public Car(Engine engine, FuelStorage fuelStorage)
        {
            _engine = engine;
            _fuelStorage = fuelStorage;

            _fuelComsumptionTimer = new Timer(500);
            _fuelComsumptionTimer.Elapsed += FuelComsumptionTimer_Elapsed;
        }

        public void TurnOn()
        {
            if (_engine.State == EngineState.Stopped)
            {
                _engine.State = EngineState.Started;
                Console.WriteLine($"Car is turned on and has FuelStorage with {_fuelStorage.AvailableUnits} {_fuelStorage.UnitName}");
                _fuelComsumptionTimer.Start();
            }
            else
            {
                throw new InvalidOperationException("The car is already started.");
            }
        }

        public void AccelerateBy(int speedIncrement)
        {
            if (_engine.State == EngineState.Started)
            {
                _engine.State = EngineState.Moving;
            }

            if (_engine.State == EngineState.Moving)
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
            if (_engine.State != EngineState.Stopped)
            {
                _engine.State = EngineState.Stopped;
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
            var consumption = _engine.GetComsumptionInHalfASecondBasedOnSpeed(Speed);
            _fuelStorage.AvailableUnits -= consumption;
            if (_fuelStorage.AvailableUnits > 0)
            {
                Console.WriteLine($"Consumption={consumption} {_fuelStorage.UnitName} for speed={Speed} km/h so, FuelStorage has {_fuelStorage.AvailableUnits} {_fuelStorage.UnitName}");
            }
            else
            {
                _fuelStorage.AvailableUnits = 0;
                Console.WriteLine("Fuel storage is empty, so the car is being stopped");
                TurnOff();
            }
        }

        internal void StartFillingFuelStorage()
        {
            _fuelStorage.StartFilling();
        }

        internal void StopFillingFuelStorage()
        {
            _fuelStorage.StopFilling();
        }
    }
}
