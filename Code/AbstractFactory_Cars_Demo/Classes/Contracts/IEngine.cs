namespace AbstractFactory_Cars_Demo.Classes.Contracts
{
    public enum EngineState
    {
        Stopped,
        Started,
        Moving
    }

    public interface IEngine
    {
        EngineState State { get; set; }

        double GetComsumptionInHalfASecondBasedOnSpeed(double speed);
    }
}
