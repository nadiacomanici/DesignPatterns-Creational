using System;

namespace FactoryMethod_Vehicles_BasedOnInteger.Classes
{
    internal class Car : IVehicle
    {
        public int NumberOfWheels => 4;

        public void Accelerate()
        {
            Console.WriteLine("Acelerate from Car");
        }

        public void Stop()
        {
            Console.WriteLine("Stop from Car");
        }
    }
}