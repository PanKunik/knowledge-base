using DesignPattern.Strategy;

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