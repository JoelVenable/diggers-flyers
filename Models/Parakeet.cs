using System;
using System.Collections.Generic;
using System.Text;
using diggers_flyers.Interfaces;

namespace diggers_flyers
{
    class Parakeet : IFlyable, IWalkable
    {
        public int Wingspan { get; } = 10;

        public int MaxRunSpeed { get; } = 2;
        public int NumLegs { get; } = 2;

        public void Walk()
        {
            Console.WriteLine("Walkin' along...");
        }

        public void Run()
        {
            Console.WriteLine($"Running at {MaxRunSpeed} to take off...");
        }

        public void Fly()
        {
            Console.WriteLine("I believe I can fly!!");


        }

    }
}
