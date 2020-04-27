using System;
using System.Timers;

namespace AbstractFactory_Cars_End.Classes.Contracts
{
    public abstract class FuelStorage
    {
        private Timer _fillStorageTimer;

        public double CapacityInUnits { get; protected set; }
        public double AvailableUnits { get; set; }
        public string UnitName { get; protected set; }

        public bool IsFilling
        {
            get { return _fillStorageTimer.Enabled; }
        }

        public FuelStorage(double capacityInUnits, double availableUnits, string unitName)
        {
            CapacityInUnits = capacityInUnits;
            AvailableUnits = availableUnits;
            UnitName = unitName;

            _fillStorageTimer = new Timer(500);
            _fillStorageTimer.Elapsed += FillStorageTimer_Elapsed;
        }

        public void StartFilling()
        {
            Console.WriteLine($"Started filling storage from {AvailableUnits} {UnitName} and capacity={CapacityInUnits} {UnitName}");
            _fillStorageTimer.Start();
        }

        public void StopFilling()
        {
            Console.WriteLine($"Stopped filling storage at {AvailableUnits} {UnitName} and capacity={CapacityInUnits} {UnitName}");
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
                Console.WriteLine($"Availability is being increased by={increment} {UnitName} so, there are {AvailableUnits} {UnitName} available and capacity={CapacityInUnits} {UnitName}");
            }
        }

        protected abstract double GetUnitsToFillInHalfASecond();
    }
}
