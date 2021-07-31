namespace ConsoleUI.Client
{
    // This is 'Client' class that is compatibile with 'Service' class.
    // This Round peg can fit into Round hole if the radius is lower or equal to hole radius.
    public class RoundPeg
    {
        private readonly int _radius;

        public RoundPeg(int radius)
        {
            _radius = radius;
        }

        public int GetRadius() => _radius;
    }
}
