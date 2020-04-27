using System;

namespace FactoryMethod_Vehicles_BasedOnInteger.Classes
{
    internal class Tricycle : IVehicle
    {
        public int NumberOfWheels => 3;

        public void Accelerate()
        {
            Console.WriteLine("Acelerate from Tricycle");
        }

        public void Stop()
        {
            Console.WriteLine("Stop from Tricycle");
        }
    }
}