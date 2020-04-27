using System;

namespace FactoryMethod_Vehicles_BasedOnInteger.Classes
{
    public class UniCycle : IVehicle
    {
        public int NumberOfWheels => 1;

        public void Accelerate()
        {
            Console.WriteLine("Acelerate from UniCycle");
        }

        public void Stop()
        {
            Console.WriteLine("Stop from UniCycle");
        }
    }
}
