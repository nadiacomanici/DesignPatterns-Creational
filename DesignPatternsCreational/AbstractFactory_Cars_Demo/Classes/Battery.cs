using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_Cars_Demo.Classes
{
    public class Battery : FuelStorage
    {
        public Battery(double capacityInUnits, double availableUnits, string unit) :
            base(capacityInUnits, availableUnits, unit)
        { }

        protected override double GetUnitsToFillInHalfASecond()
        {
            return 0.5;
        }
    }
}
