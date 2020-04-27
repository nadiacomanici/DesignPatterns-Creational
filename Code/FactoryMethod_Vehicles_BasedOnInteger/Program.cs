using FactoryMethod_Vehicles_BasedOnInteger.Classes;

namespace FactoryMethod_Vehicles_BasedOnInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            var vehicleCreator = new VehicleCreator();
            for (int i = 1; i <= 4; i++)
            {
                var vehicle = vehicleCreator.GetVehicle(i);
                vehicle.Accelerate();
                vehicle.Stop();
            }
        }
    }
}
