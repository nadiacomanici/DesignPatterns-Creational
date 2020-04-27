namespace AbstractFactory_Cars_Demo.Classes
{
    public enum EngineState
    {
        Stopped,
        Started,
        Moving
    }

    public abstract class Engine
    {
        public EngineState State { get; set; }

        public abstract double GetComsumptionInHalfASecondBasedOnSpeed(double speed);
    }
}
