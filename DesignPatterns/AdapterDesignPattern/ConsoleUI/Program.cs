using ConsoleUI.Adapter;
using ConsoleUI.Client;
using ConsoleUI.Service;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var roundHole = new RoundHole(6);
            var roundPeg = new RoundPeg(6);

            Console.WriteLine($"Does round peg with radius { roundPeg.GetRadius() } fits in round hole with radius { roundHole.GetRadius() }?");
            Console.WriteLine($"Will it fit?: { roundHole.Fits(roundPeg) }.");

            var smallSquarePeg = new SquarePeg(5);
            var largeSquarePeg = new SquarePeg(10);

            Console.WriteLine($"Does square peg with width { smallSquarePeg.GetWidth() } fits in round hole with radius { roundHole.GetRadius() }?");
            // Console.WriteLine($"Will it fit?: { roundHole.Fits(smallSquarePeg) }"); <-- Here we have an error - incompatibile interfaces
            // We have to adapt square peg to the round hole (it would simulate round peg).

            var smallSquarePegAdatper = new SquarePegAdapter(smallSquarePeg);
            Console.WriteLine($"His radius is: { smallSquarePegAdatper.GetRadius() }.");
            Console.WriteLine($"Will it fit?: { roundHole.Fits(smallSquarePegAdatper) }.");


            Console.WriteLine($"Does square peg with width { largeSquarePeg.GetWidth() } fits in round hole with radius { roundHole.GetRadius() }?");
            var largeSquarePegAdapter = new SquarePegAdapter(largeSquarePeg);
            Console.WriteLine($"His radius is: { largeSquarePegAdapter.GetRadius() }.");
            Console.WriteLine($"Will if fit?: { roundHole.Fits(largeSquarePegAdapter) }.");
        }
    }
}
