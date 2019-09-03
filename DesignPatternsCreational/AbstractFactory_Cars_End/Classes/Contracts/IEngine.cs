namespace AbstractFactory_Cars_End.Classes.Contracts
{
    public interface IEngine
    {
        EngineState State { get; set; }

        double GetComsumptionInHalfASecondBasedOnSpeed(double speed);
    }
}