## **Strategy Pattern**
Strategy pattern is a behavioral design pattern that allows you to define algorithms family, encapsulate them and make them easy interchangable at runtime. This pattern lets the algorithm vary independently from clients that use it.

### **Participants**
1. `Strategy` - declares an interface common to all supported algorithms. `Context` uses this interface to call the algorithm defined by `ConcreteStrategy`,
2. `ConcreteStrategy` - implements the algorithm using the `Strategy` interface,
3. `Context` - is configured with a `ConcreteStrategy` object. Maintains a reference to a `Strategy` pattern. May define an interface that lets the `Strategy` access its data.

### **Example**
We define `Strategy` interface named `IStrategy`. It looks like this:
```c#
public interface IStrategy
{
    string GetTravelTime(string source, string destination);
}
```

This is a base contract for our `concrete strategies`.

Next we define concrete strategies based on the interface. They contain algorithms responsible for calculating travel time. In this example we will have 3 strategies. For keeping this example as simple as possible I will ommit the algorithm calculations and return just a string with hardcoded values:

#### **Car strategy**
```c#
public class CarStrategy : IStrategy
{
    public string GetTravelTime(string source, string destination)
    {
        return "It takes 40 minutes to reach from " + source + " to " + destination + " using a Car.";
    }
}
```

#### **Bike strategy**
```c#
public class BikeStrategy : IStrategy
{
    public string GetTravelTime(string source, string destination)
    {
        return "It takes 25 minutes to reach from " + source + " to " + destination + " using Bike.";
    }
}
```

#### **Bus strategy**
```c#
public class BusStrategy : IStrategy
{
    public string GetTravelTime(string source, string destination)
    {
        return "IT takes 60 minutes to reach from " + source + " to " + destination + " using Bus.";
    }
}
```

Now we need out `Context` class that will execute containing `Strategy`. We will anme it `TravelStrategy`:

```c#
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
}
```

Our `TravelStrategy` class need the strategy on construction. To make the algorithm easy to change we can implement `SetStrategy(IStrategy strategy)` method to switch the strategy at runtime.

```c#
public void SetStrategy(IStrategy strategy)
{
    _strategy = strategy;
}
```

In our `Program.cs` file we create simple loop that asks the user for an input. Based on the input it selects appropriate strategy and "calculate" the estimated travel time between source and destination.

```c#
var travelStrategy = new TravelStrategy(new BusStrategy());
int userInput;
do
{
    userInput = Console.ReadKey().KeyChar;

    IStrategy? strategy = userInput switch
    {
        49 => new BikeStrategy(),
        50 => new CarStrategy(),
        _ => new BusStrategy()
    };

    travelStrategy.SetStrategy(strategy);
    travelStrategy.GetTravelTime("London", "Manchester");
}
while (userInput != 48);
```

As you can see we can change the `GetTravelTime()` algorithm by setting the strategy with `SetStrategy()` method. We don't have to instantiate `TravelStrategy` class again.