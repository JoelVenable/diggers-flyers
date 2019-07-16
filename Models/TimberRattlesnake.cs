using System;
using System.Collections.Generic;
using System.Text;
using diggers_flyers.Interfaces;

namespace diggers_flyers.Models
{
    class TimberRattlesnake : IWalkable
    {
        public int MaxRunSpeed { get; } = 10;

        public void Walk()
        {
            Console.WriteLine("The snake slithers.");
        }

        public void Run()
        {
            Console.WriteLine("The snake slithers quickly!");
        }

        public int NumLegs { get; } = 0;
     }
}
