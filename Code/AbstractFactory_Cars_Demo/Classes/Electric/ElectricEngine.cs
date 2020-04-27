using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory_Cars_Demo.Classes.Contracts;

namespace AbstractFactory_Cars_Demo.Classes.Electric
{
    public class ElectricEngine : IEngine
    {
        public EngineState State { get; set; }

        public double GetComsumptionInHalfASecondBasedOnSpeed(double speed)
        {
            if (State != EngineState.Stopped)
            {
                switch (speed)
                {
                    case double n when (n == 0):
                        return 0.01;

                    case double n when (0 < n && n <= 70):
                        return 0.2;

                    case double n when (70 < n && n <= 110):
                        return 4;

                    case double n when (110 < n):
                        return 8;
                }
            }
            return 0;
        }
    }
}
