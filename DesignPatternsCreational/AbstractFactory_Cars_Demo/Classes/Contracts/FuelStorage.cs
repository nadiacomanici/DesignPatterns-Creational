using System;
using System.Timers;

namespace AbstractFactory_Cars_Begin.Classes
{

    public abstract class FuelStorage
    {
        private Timer _fillStorageTimer;

        public double CapacityInUnits { get; protected set; }
        public double AvailableUnits { get; set; }
        public string Unit { get; protected set; }

        public bool IsFilling
        {
            get { return _fillStorageTimer.Enabled; }
        }

        public FuelStorage(double capacityInUnits, double availableUnits, string unit)
        {
            CapacityInUnits = capacityInUnits;
            AvailableUnits = availableUnits;
            Unit = unit;

            _fillStorageTimer = new Timer(500);
            _fillStorageTimer.Elapsed += FillStorageTimer_Elapsed;
        }

        public void StartFilling()
        {
            Console.WriteLine($"Started filling storage from {AvailableUnits} {Unit} and capacity={CapacityInUnits} {Unit}");
            _fillStorageTimer.Start();
        }

        public void StopFilling()
        {
            Console.WriteLine($"Stopped filling storage at {AvailableUnits} {Unit} and capacity={CapacityInUnits} {Unit}");
            _fillStorageTimer.Stop();
        }

        private void FillStorageTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (AvailableUnits >= CapacityInUnits)
            {
                AvailableUnits = CapacityInUnits;
                StopFilling();
            }
            else
            {
                var increment = GetUnitsToFillInHalfASecond();
                AvailableUnits += increment;
                Console.WriteLine($"Availability is being increased by={increment} {Unit} so, there are {AvailableUnits} {Unit} available and capacity={CapacityInUnits} {Unit}");
            }
        }

        protected abstract double GetUnitsToFillInHalfASecond();
    }
}