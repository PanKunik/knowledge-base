using ConsoleUI.Client;
using System;

namespace ConsoleUI.Adapter
{
    // This is 'Adapter' class. It allows to fit SquarePeg class to RoundHole object.
    // This adapter have to extend the interface, that we want our object to be compatibile.
    // Square peg adapter extends round peg adatper.
    public class SquarePegAdapter : RoundPeg
    {
        // We wrap the SquarePeg to imitate RoundPeg
        private readonly SquarePeg _peg;

        public SquarePegAdapter(SquarePeg peg) : base(peg.GetWidth())
        {
            _peg = peg;
        }

        // This method allows to get radius of a square peg (adaptee method)
        public new double GetRadius() => _peg.GetWidth() * Math.Sqrt(2) / 2;
    }
}
