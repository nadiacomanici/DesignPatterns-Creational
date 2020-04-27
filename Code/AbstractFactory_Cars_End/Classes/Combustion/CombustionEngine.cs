using AbstractFactory_Cars_End.Classes.Contracts;

namespace AbstractFactory_Cars_End.Classes.Combustion
{
    public class CombustionEngine : IEngine
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

                    case double n when (0 < n && n <= 50):
                        return 0.5;

                    case double n when (50 < n && n <= 80):
                        return 0.7;

                    case double n when (80 < n && n <= 110):
                        return 1;

                    case double n when (110 < n):
                        return 2;
                }
            }
            return 0;
        }
    }
}
