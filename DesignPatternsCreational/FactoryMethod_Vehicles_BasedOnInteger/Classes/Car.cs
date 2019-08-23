using System;

namespace FactoryMethod_Vehicles_BasedOnInteger.Classes
{
    internal class Car : IVehicle
    {
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