namespace DesignPattern.Strategy;

public class TravelStrategy
{
    private IStrategy _strategy;

    public TravelStrategy(IStrategy strategy)
    {
        _strategy = strategy;
    }

    public void GetTravelTime(string source, string destination)
    {
        var result = _strategy.GetTravelTime(source, destination);
        Console.WriteLine(result);
    }

    public void SetStrategy(IStrategy strategy)
    {
        _strategy = strategy;
    }
}