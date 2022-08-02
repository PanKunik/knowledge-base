namespace DesignPattern.Strategy;

public class BusStrategy : IStrategy
{
    public string GetTravelTime(string source, string destination)
    {
        return "IT takes 60 minutes to reach from " + source + " to " + destination + " using Bus.";
    }
}