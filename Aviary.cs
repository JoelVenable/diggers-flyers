using System;
using System.Collections.Generic;
using System.Text;
using diggers_flyers.Interfaces;
using diggers_flyers.Models;

namespace diggers_flyers
{
    class Aviary

    {
        public List<IFlyable> Animals { get; set; } = new List<IFlyable>()
        {
            new Finch(),
            new Parakeet()
        };
    }
}
