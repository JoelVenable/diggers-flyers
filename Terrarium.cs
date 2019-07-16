using System;
using System.Collections.Generic;
using System.Text;
using diggers_flyers.Interfaces;
using diggers_flyers.Models;

namespace diggers_flyers
{
    class Terrarium

    {
        public List<IDiggable> Animals { get; set; } = new List<IDiggable>()
        {
            new Ant(),
            new Earthworm(),
            new Mouse()
        };
    }
}
