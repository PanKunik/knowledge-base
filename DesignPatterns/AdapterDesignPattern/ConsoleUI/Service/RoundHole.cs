using ConsoleUI.Client;

namespace ConsoleUI.Service
{
    // This is 'Service' class that accepts specified 'Client' classes.
    // This Round hole class accepts Roud peg class.
    public class RoundHole
    {
        private readonly int _radius;

        public RoundHole(int radius)
        {
            _radius = radius;
        }

        public int GetRadius() => _radius;

        public bool Fits(RoundPeg peg) => GetRadius() >= peg.GetRadius();
    }
}
