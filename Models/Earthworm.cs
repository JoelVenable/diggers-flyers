using System;
using System.Collections.Generic;
using System.Text;

using diggers_flyers.Interfaces;

namespace diggers_flyers.Models
{
    class Earthworm : IDiggable
    {
        public void Dig()
        {
            Console.WriteLine("Making some new soil...");
        }
    }
}
