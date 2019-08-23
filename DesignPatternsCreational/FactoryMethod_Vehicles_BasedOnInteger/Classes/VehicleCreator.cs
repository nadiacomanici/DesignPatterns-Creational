using System;

namespace FactoryMethod_Vehicles_BasedOnInteger.Classes
{
    public class VehicleCreator
    {
        public IVehicle GetVehicle(int numberOfWheels)
        {
            switch (numberOfWheels)
            {
                case 1:
                    return new UniCycle();
                case 2:
                    return new Bicycle();
                case 3:
                    return new Tricycle();
                case 4:
                    return new Car();
                default:
                    throw new ArgumentException("Invalid number of wheels");
            }
        }
    }
}
