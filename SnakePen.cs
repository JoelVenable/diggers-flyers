using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using diggers_flyers.Interfaces;
using diggers_flyers.Models;

namespace diggers_flyers
{
    class SnakePen : System.Collections.IEnumerable

    {
        public List<ISlitherable> Animals { get; set; } = new List<ISlitherable>()
        {
            new TimberRattlesnake(),
            new CopperheadSnake()
        };

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
