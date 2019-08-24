using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_Cars_Demo.Classes
{
    public class ElectricCarFactory : ICarFactory
    {
        public Engine CreateEngine()
        {
            return new ElectricEngine();
        }

        public FuelStorage CreateFuelStorage()
        {
            return new Battery(8, 4, "KW");
        }
    }
}
