using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_Cars_Demo.Classes.Contracts
{
    public interface ICarFactory
    {
        Engine CreateEngine();

        FuelStorage CreateFuelStorage();
    }
}
