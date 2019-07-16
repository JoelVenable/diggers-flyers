using System;
using System.Collections.Generic;
using System.Text;
using diggers_flyers.Interfaces;
using diggers_flyers.Models;

namespace diggers_flyers
{
    class Aquarium
    {
        public List<ISwimmable> Animals { get; set; } = new List<ISwimmable>()
        {
            new BetaFish(),
            new Terrapin()
        };
    }
}
