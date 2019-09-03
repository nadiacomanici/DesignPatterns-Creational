using AbstractFactory_Cars_End.Classes.Contracts;

namespace AbstractFactory_Cars_End.Classes.Electric
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

                    case double n when (0 < n && n <= 30):
                        return 0.2;

                    case double n when (30 < n && n <= 50):
                        return 0.5;

                    case double n when (50 < n && n <= 100):
                        return 3;

                    case double n when (100 < n):
                        return 4;
                }
            }
            return 0;
        }
    }
}