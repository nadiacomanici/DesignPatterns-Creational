namespace AbstractFactory_Cars_Begin.Classes
{
    public interface IEngine
    {
        EngineState State { get; set; }

        double GetComsumptionInHalfASecondBasedOnSpeed(double speed);
    }
}
