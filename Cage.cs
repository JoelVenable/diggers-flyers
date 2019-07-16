using System;
using System.Collections.Generic;
using System.Text;
using diggers_flyers.Interfaces;
using diggers_flyers.Models;

namespace diggers_flyers
{
    class Cage

    {
        public List<IWalkable> Animals { get; set; } = new List<IWalkable>()
        {
            new Gerbil(),
            new Mouse()
        };
    }
}
