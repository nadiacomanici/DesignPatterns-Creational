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

                    case double n when (0 < n && n <= 30):
                        return 0.3;

                    case double n when (30 < n && n <= 50):
                        return 0.4;

                    case double n when (50 < n && n <= 100):
                        return 0.7;

                    case double n when (100 < n):
                        return 3;
                }
            }
            return 0;
        }
    }
}
