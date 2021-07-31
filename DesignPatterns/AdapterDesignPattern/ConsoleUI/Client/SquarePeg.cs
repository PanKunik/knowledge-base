namespace ConsoleUI.Client
{
    // This is 'Client' class that is incompatibile with 'Service' class RoundHole.
    // Assume, that we can't change our service code to accept other objects than of type RoundPeg.
    // We have to 'adapt' this class to the 'Service' code.
    public class SquarePeg
    {
        private readonly int _width;

        public SquarePeg(int width)
        {
            _width = width;
        }

        public int GetWidth() => _width;
    }
}
