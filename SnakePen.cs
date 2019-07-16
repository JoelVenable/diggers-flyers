using System;
using System.Collections.Generic;
using System.Text;
using diggers_flyers.Interfaces;
using diggers_flyers.Models;

namespace diggers_flyers
{
    class SnakePen

    {
        public List<ISlitherable> Animals { get; set; } = new List<ISlitherable>()
        {
            new TimberRattlesnake(),
            new CopperheadSnake()
        };
    }
}
