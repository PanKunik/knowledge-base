namespace DesignPattern.Strategy;

public interface IStrategy
{
    string GetTravelTime(string source, string destination);
}