using System;
using System.Collections.Generic;
using System.Text;
using diggers_flyers.Interfaces;

namespace diggers_flyers.Models
{
    class CopperheadSnake : IWalkable
    {
        public int MaxRunSpeed { get; } = 9;

        public int NumLegs { get; } = 0;

        public void Walk()
        {
            Console.WriteLine("The snake slithers");
        }

        public void Run()
        {
            Console.WriteLine("The snake slithers faster.");
        }
    }
}
