using System;
using System.Collections.Generic;
using System.Text;
using diggers_flyers.Interfaces;

namespace diggers_flyers.Models
{
    class BetaFish : ISwimmable
    {

        public int MaxDepth { get; } = 120;

        public void Swim()
        {
            Console.WriteLine("The fish swims...");
        }
    }
}
