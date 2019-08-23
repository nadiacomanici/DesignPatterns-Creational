using System;

namespace FactoryMethod_Vehicles_BasedOnInteger.Classes
{
    internal class Tricycle : IVehicle
    {
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