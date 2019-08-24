using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_Cars_Demo.Classes
{
    public class ElectricEngine : Engine
    {
        public override double GetComsumptionInHalfASecondBasedOnSpeed(double speed)
        {
            if (State != EngineState.Stopped)
            {
                switch (speed)
                {
                    case double n when (n == 0):
                        return 0.01;

                    case double n when (0 < n && n <= 50):
                        return 0.3;

                    case double n when (50 < n && n <= 80):
                        return 0.4;

                    case double n when (80 < n && n <= 110):
                        return 4;

                    case double n when (110 < n):
                        return 8;
                }
            }
            return 0;
        }
    }
}
